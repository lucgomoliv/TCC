using System.Text;

namespace TCC
{
	internal class Interpretador
	{
		const string extensaoDesigner = ".Designer.cs";

		const string extensaoAspxDesigner = ".aspx.designer.cs";
		const string extensaoAspxCode = ".aspx.cs";
		const string extensaoAspxPadrao = ".aspx";

		string Path { get; set; } = string.Empty;
		string PathDesigner { get; set; } = string.Empty;
		string PathDestino { get; set; } = string.Empty;
		string NomeProjetoDestino { get; set; } = string.Empty;
		Size TamanhoJanela { get; set; } = new Size();
		string NomeArquivo => Path.Split('\\').Last().Split('.').First();

		List<Componente> ListaComponentes { get; set; } = new List<Componente>();

		public Interpretador(string pathOrigem, string pathDestino, string nomeProjetoDestino)
		{
			Path = pathOrigem;
			PathDesigner = pathOrigem.Replace(".cs", extensaoDesigner);
			PathDestino = pathDestino;
			NomeProjetoDestino = nomeProjetoDestino;
		}

		public void MigrarForm()
		{
			InterpretarDesigner();
			GerarArquivoAspx();
			GerarArquivoCode();
			GerarArquivoDesigner();
		}

		private void GerarArquivoDesigner()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"namespace {NomeProjetoDestino}");
			sb.AppendLine("{");
			sb.AppendLine($"\tpublic partial class {NomeArquivo}");
			sb.AppendLine("\t{");

			foreach(var componente in ListaComponentes.Where(x => x.TipoMigracao != "div"))
				sb.AppendLine($"\t\tprotected global::System.Web.UI.WebControls.{componente.TipoMigracao} {componente.Name};");

			sb.AppendLine("\t}");
			sb.AppendLine("}");

			IOUtils.SalvarArquivo($"{PathDestino}\\{NomeArquivo}{extensaoAspxDesigner}", sb.ToString());
		}

		private void GerarArquivoCode()
		{
			var sb = new StringBuilder();
			sb.AppendLine("using System;");
			sb.AppendLine("using System.Web.UI;");
			sb.AppendLine($"namespace {NomeProjetoDestino}");
			sb.AppendLine("{");
			sb.AppendLine($"\tpublic partial class {NomeArquivo} : Page");
			sb.AppendLine("\t{");
			sb.AppendLine("\t\tprotected void Page_Load(object sender, EventArgs e)");
			sb.AppendLine("\t\t{");
			sb.AppendLine("\t\t\t");
			sb.AppendLine("\t\t}");
			sb.AppendLine("");
			sb.AppendLine(GerarMetodos());
			sb.AppendLine("");
			sb.AppendLine("\t}");
			sb.AppendLine("}");

			IOUtils.SalvarArquivo($"{PathDestino}\\{NomeArquivo}{extensaoAspxCode}", sb.ToString());
		}

		private string? GerarMetodos()
		{
			var linhas = File.ReadLines(Path);
			bool classeComecou = false;
			var sb = new StringBuilder();

			foreach(var linha in linhas)
			{
				if (classeComecou && linha == "\t{")
					continue;

				if (classeComecou && linha == "\t};")
					break;

				if (classeComecou)
					sb.AppendLine(linha);

				if (linha.Contains(" class "))
					classeComecou = true;
			}

			return sb.Replace("InitializeComponent();", string.Empty)
					.Replace("private ", "protected ")
					.ToString();
		}

		private void GerarArquivoAspx()
		{
			var sb = new StringBuilder();
			sb.AppendLine(GerarCabecalho());
			sb.AppendLine($"<div style=\"position:relative; width:{TamanhoJanela.Width}px; height:{TamanhoJanela.Height}px\">");

			foreach (var componente in ListaComponentes.Where(x => x.Parent == NomeArquivo))
				sb.AppendLine(ManipuladorComponentes.MigrarComponente(componente));

			sb.AppendLine("</div>");
			sb.AppendLine("</asp:Content>");

			IOUtils.SalvarArquivo($"{PathDestino}\\{NomeArquivo}{extensaoAspxPadrao}", sb.ToString());
		}

		private string GerarCabecalho()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"<%@ Page Title=\"{NomeArquivo}\" Language=\"C#\" MasterPageFile=\"~/Site.Master\" AutoEventWireup=\"true\" CodeBehind=\"{NomeArquivo}.aspx.cs\" Inherits=\"{NomeProjetoDestino}.{NomeArquivo}\" %>");
			sb.Append($"<asp:Content ID=\"BodyContent\" ContentPlaceHolderID=\"MainContent\" runat=\"server\">");

			return sb.ToString();
		}

		private void InterpretarDesigner()
		{
			SepararComponentes();
			PopularPais();
			RemoverComponentesNaoMigraveis();
		}

		private void RemoverComponentesNaoMigraveis()
		{
			//listaComponentes.RemoveAll(x => x.Tipo == "Panel");
		}

		private void PopularPais()
		{
			foreach(var componente in ListaComponentes)
			{
				foreach (var control in componente.Controls)
					control.Parent = componente.Name;

				if (string.IsNullOrEmpty(componente.Parent))
					componente.Parent = NomeArquivo;
			}
		}

		private void SepararComponentes()
		{
			var linhas = File.ReadLines(PathDesigner);
			var comecarLinhaNewComponente = false;
			var comecarPropriedades = false;
			var listaComponentes = new List<Componente>();
			var linhaAnterior = string.Empty;
			var linhaContinua = false;

			foreach (var linha in linhas)
			{
				var conteudoLinha = linha;
				if (linhaContinua)
					conteudoLinha = linhaAnterior + linha;

				if (conteudoLinha.Equals("\t\t\t// "))
				{
					comecarLinhaNewComponente = false;
					comecarPropriedades = true;
					continue;
				}

				linhaContinua = false;
				if (comecarPropriedades && conteudoLinha.Contains("// " + NomeArquivo))
					break;

				if (comecarPropriedades)
					linhaContinua = InterpretarLinhaPropriedades(listaComponentes, conteudoLinha);

				if (comecarLinhaNewComponente && !conteudoLinha.Equals("\t\t{") && !conteudoLinha.Contains("SuspendLayout") && !conteudoLinha.Contains("ISupportInitialize"))
					listaComponentes.Add(InterpretarLinhaNewComponente(conteudoLinha));

				if (conteudoLinha.Contains("InitializeComponent"))
					comecarLinhaNewComponente = true;

				linhaAnterior = conteudoLinha;
			}

			var split = linhas.First(x => x.Contains("this.ClientSize ")).TextoEntreParenteses().Split(',');
			TamanhoJanela = new Size(int.Parse(split[0]), int.Parse(split[1]));

			ListaComponentes = listaComponentes;
		}

		private Componente InterpretarLinhaNewComponente(string linha)
		{
			var split = linha.Split('=');
			var nome = split[0].Split('.').Last().Trim();
			var tipo = split[1].Split('.').Last().Split('(')[0].Trim();

			return new Componente() { Name = nome, Tipo = tipo };
		}

		private bool InterpretarLinhaPropriedades(List<Componente> listaComponentes, string linha)
		{
			if (linha.Contains(';'))
			{
				if (linha.Contains("+="))
				{
					var split = linha.Split("+=");
					var componenteSplit = split[0].Split('.');
					var nome = componenteSplit[1].Trim();
					var propriedade = componenteSplit[2].Trim();
					var valorSplit = split[0];

					if (split.Length > 1)
						valorSplit = split[1].TextoEntreParenteses().Replace("this.", "").Trim();

					if (valorSplit != null && propriedade != "Name")
						listaComponentes.First(x => x.Name == nome).Eventos.Add(propriedade, valorSplit);

					return false;
				}
				else 
				{
					var split = linha.Split('=');

					var componenteSplit = split[0].Split('.');
					var nome = componenteSplit[1].Trim();
					var propriedade = componenteSplit[2].Trim();
					var valorSplit = split[0];

					if (split.Length > 1)
						valorSplit = split[1].Replace(";", "").Trim();

					if (valorSplit != null && propriedade != "Name")
						if (propriedade != "Controls")
							listaComponentes.First(x => x.Name == nome).SetarPropriedade(propriedade, valorSplit.PropriedadeParaValor(propriedade));
						else
							listaComponentes.First(x => x.Name == nome).Controls.Add(listaComponentes.First(x => x.Name == (string)valorSplit.PropriedadeParaValor(propriedade)));

					return false;
				}
			}
			else
				return true;
		}
	}
}
