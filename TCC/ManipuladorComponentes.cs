using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC
{
	internal static class ManipuladorComponentes
	{
		public static string MigrarComponente(Componente componente)
		{
			return CriarCampo(componente);
		}

		private static string CriarCampo(Componente componente)
		{
			if (componente.TipoMigracao == "div")
			{
				var sb = new StringBuilder();
				sb.AppendLine($"<div ID=\"{componente.Name}\" style=\"position:absolute; width:{componente.Size.Width}px; height:{componente.Size.Height}px; top:{componente.Location.Y}px; left:{componente.Location.X}px\">");
				
				foreach(var control in componente.Controls)
					sb.AppendLine(CriarCampo(control));

				sb.AppendLine("</div>");
				return sb.ToString();
			}

			return $"<asp:{componente.TipoMigracao}{GerarTabIndex(componente)} style=\"position: absolute; top:{componente.Location.Y}px; left:{componente.Location.X}px\" runat=\"server\" ID=\"{componente.Name}\"{Excecoes(componente)}{CriarEventos(componente)}{GerarTexto(componente)}{GerarChecked(componente)}{(ComponenteAutoFechaTag(componente) ? "/>" : $">{CriarItems(componente)}</asp:{componente.TipoMigracao}>")}";
		}

		private static string GerarTabIndex(Componente componente)
		{
			if (componente.TipoMigracao != "Label")
				return $" tabindex=\"{componente.TabIndex}\"";

			return string.Empty;
		}

		private static string GerarChecked(Componente componente)
		{
			return componente.TipoMigracao switch
			{
				"CheckBox" or "RadioButton" => $" Checked=\"{componente.Checked}\"",
				_ => string.Empty
			};
		}

		private static string GerarTexto(Componente componente)
		{
			if (componente.TipoMigracao == "DropDownList")
				return string.Empty;

			return $" Text=\"{componente.Text}\"";
		}

		private static string CriarEventos(Componente componente)
		{
			var sb = new StringBuilder();

			foreach (var evento in componente.Eventos)
				sb.Append($" {NomeEvento(evento.Key)}=\"{evento.Value}\"");

			if(sb.Length > 0)
				sb.Append(" AutoPostBack=\"true\"");

			return sb.ToString();
		}

		private static string NomeEvento(string key)
		{
			return key switch
			{
				"Click" => "OnClick",
				"CheckedChanged" => "OnCheckedChanged",
				"SelectionChanged" => "OnSelectedIndexChanged",
				_ => ""
			};
		}

		private static string CriarItems(Componente componente)
		{
			if (componente.TipoMigracao == "DropDownList")
			{
				var sb = new StringBuilder();
				sb.AppendLine($"<asp:ListItem Selected=\"True\" Value=\"0\">Selecione um item...</asp:ListItem>");

				foreach (var item in componente.Items)
					sb.AppendLine($"<asp:ListItem Value=\"{item}\">{item}</asp:ListItem>");

				return sb.ToString();
			}

			return string.Empty;
		}

		private static string Excecoes(Componente componente)
		{
			if (componente.TipoMigracao == "RadioButton")
				return $" GroupName=\"{componente.Parent}\"";

			if (componente.TipoMigracao == "DataGrid")
				return $" Width=\"{componente.Size.Width}\" Height=\"{componente.Size.Height}\"";

			return "";
		}

		private static bool ComponenteAutoFechaTag(Componente componente)
		{
			return componente.TipoMigracao switch
			{
				"Button" or "RadioButton" or "CheckBox" => true,
				_ => false,
			};
		}
	}
}
