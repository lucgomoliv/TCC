namespace TCC
{
	public partial class FormParaMigracao : Form
	{
		private readonly List<Pessoa> Pessoas = new List<Pessoa>();
		private bool ModoAlterar = false;

		public FormParaMigracao()
		{
			InitializeComponent();
			dataGridViewPessoas.DataSource = Pessoas;
		}

		private void buttonCadastrar_Click(object sender, EventArgs e)
		{
			if(ModoAlterar)
				AlterarPessoa(GerarPessoa());
			else
				AdicionarPessoa(GerarPessoa());
		}

		private void AdicionarPessoa(Pessoa pessoa)
		{
			Pessoas.Add(pessoa);
			AtualizarDataGrid();
			LimparCampos();
		}

		private void AlterarPessoa(Pessoa pessoaAlterada)
		{
			var pessoa = Pessoas.First(x => x.Cpf == pessoaAlterada.Cpf);
			pessoa.Nome = textBoxNome.Text;
			pessoa.Email = textBoxEmail.Text;
			pessoa.Telefone = textBoxTelefone.Text;
			pessoa.EstadoCivil = comboBoxEstadoCivil.SelectedIndex;
			pessoa.Sexo = radioButtonFeminino.Checked;
			pessoa.PossuiFilhos = radioButtonPossuiFilhosSim.Checked;
			pessoa.ReceberNotificacoes = checkBoxNotificacao.Checked;

			AtualizarDataGrid();
			LimparCampos();
		}

		private void AtualizarDataGrid()
		{
			dataGridViewPessoas.DataSource = new BindingSource() { DataSource = Pessoas };
			dataGridViewPessoas.Refresh();
			dataGridViewPessoas.ClearSelection();
			dataGridViewPessoas.CurrentCell = null;
		}

		private void CarregarPessoa(Pessoa pessoa)
		{
			textBoxNome.Text = pessoa.Nome;
			textBoxCPF.Text = pessoa.Cpf;
			textBoxEmail.Text = pessoa.Email;
			textBoxTelefone.Text = pessoa.Telefone;
			comboBoxEstadoCivil.SelectedIndex = pessoa.EstadoCivil;
			radioButtonFeminino.Checked = pessoa.Sexo;
			radioButtonPossuiFilhosSim.Checked = pessoa.PossuiFilhos;
			checkBoxNotificacao.Checked = pessoa.ReceberNotificacoes;

			buttonCadastrar.Text = "Alterar";
			ModoAlterar = true;
			textBoxCPF.Enabled = false;
		}

		private void ExcluirPessoa(Pessoa pessoa)
		{
			Pessoas.Remove(pessoa);
		}

		private Pessoa GerarPessoa()
		{
			return new Pessoa()
			{
				Nome = textBoxNome.Text,
				Cpf = textBoxCPF.Text,
				Email = textBoxEmail.Text,
				Telefone = textBoxTelefone.Text,
				EstadoCivil = comboBoxEstadoCivil.SelectedIndex,
				Sexo = radioButtonFeminino.Checked,
				PossuiFilhos = radioButtonPossuiFilhosSim.Checked,
				ReceberNotificacoes = checkBoxNotificacao.Checked,
			};
		}

		private void LimparCampos()
		{
			dataGridViewPessoas.ClearSelection();
			dataGridViewPessoas.CurrentCell = null;
			textBoxNome.Text = string.Empty;
			textBoxCPF.Text = string.Empty;
			textBoxEmail.Text = string.Empty;
			textBoxTelefone.Text = string.Empty;
			comboBoxEstadoCivil.SelectedIndex = -1;
			radioButtonFeminino.Checked = false;
			radioButtonMasculino.Checked = true;
			radioButtonPossuiFilhosSim.Checked = false;
			radioButtonPossuiFilhosNao.Checked = true;
			checkBoxNotificacao.Checked = false;

			ModoAlterar = false;
			buttonCadastrar.Text = "Cadastrar";
			textBoxCPF.Enabled = true;
		}

		private void buttonLimpar_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}

		private void buttonExcluir_Click(object sender, EventArgs e)
		{
			ExcluirPessoa(PessoaSelecionada());
			LimparCampos();
			AtualizarDataGrid();
		}

		private void dataGridViewPessoas_SelectionChanged(object sender, EventArgs e)
		{
			var pessoa = PessoaSelecionada();
			if(pessoa != null)
				CarregarPessoa(pessoa);
		}

		private Pessoa PessoaSelecionada()
		{
			if(Pessoas.Count > 0 && dataGridViewPessoas.CurrentRow != null)
				return (Pessoa)dataGridViewPessoas.CurrentRow.DataBoundItem;
			
			return null;
		}
	};
}
