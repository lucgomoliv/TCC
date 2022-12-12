using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TCC
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnBuscarArquivo_Click(object sender, EventArgs e)
		{
			using OpenFileDialog openFileDialog = new();
			openFileDialog.InitialDirectory = "c:\\";
			openFileDialog.Filter = "cs files (*.cs)|*.cs";
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
				textBoxArquivo.Text = openFileDialog.FileName;
			else
				textBoxArquivo.Text = string.Empty;
		}

		private void buttonMigrar_Click(object sender, EventArgs e)
		{
			try
			{
				var doc = XDocument.Load(textBoxDestino.Text);
				XNamespace ns = doc.Root.GetDefaultNamespace();
				var namespaceAplicacao = doc.Element(ns + "Project").Element(ns + "PropertyGroup").Element(ns + "RootNamespace")?.Value;
				var pathDestino = Regex.Replace(textBoxDestino.Text, @"[^\\]*$", "");
				new Interpretador(textBoxArquivo.Text, pathDestino, namespaceAplicacao??"").MigrarForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro durante a migração: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			MessageBox.Show("Arquivos migrados gerados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}