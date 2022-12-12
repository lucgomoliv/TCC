namespace TCC
{
	partial class FormParaMigracao
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxTelefone = new System.Windows.Forms.TextBox();
			this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
			this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBoxNotificacao = new System.Windows.Forms.CheckBox();
			this.buttonCadastrar = new System.Windows.Forms.Button();
			this.textBoxCPF = new System.Windows.Forms.TextBox();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.radioButtonPossuiFilhosNao = new System.Windows.Forms.RadioButton();
			this.radioButtonPossuiFilhosSim = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonLimpar = new System.Windows.Forms.Button();
			this.buttonExcluir = new System.Windows.Forms.Button();
			this.dataGridViewPessoas = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome Completo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "CPF";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Email";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(114, 70);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(159, 23);
			this.textBoxEmail.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Telefone";
			// 
			// textBoxTelefone
			// 
			this.textBoxTelefone.Location = new System.Drawing.Point(114, 99);
			this.textBoxTelefone.Name = "textBoxTelefone";
			this.textBoxTelefone.Size = new System.Drawing.Size(159, 23);
			this.textBoxTelefone.TabIndex = 6;
			// 
			// comboBoxEstadoCivil
			// 
			this.comboBoxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEstadoCivil.FormattingEnabled = true;
			this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viúvo"});
			this.comboBoxEstadoCivil.Location = new System.Drawing.Point(114, 128);
			this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
			this.comboBoxEstadoCivil.Size = new System.Drawing.Size(159, 23);
			this.comboBoxEstadoCivil.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Estado Civil";
			// 
			// radioButtonMasculino
			// 
			this.radioButtonMasculino.AutoSize = true;
			this.radioButtonMasculino.Checked = true;
			this.radioButtonMasculino.Location = new System.Drawing.Point(114, 157);
			this.radioButtonMasculino.Name = "radioButtonMasculino";
			this.radioButtonMasculino.Size = new System.Drawing.Size(80, 19);
			this.radioButtonMasculino.TabIndex = 10;
			this.radioButtonMasculino.TabStop = true;
			this.radioButtonMasculino.Text = "Masculino";
			this.radioButtonMasculino.UseVisualStyleBackColor = true;
			// 
			// radioButtonFeminino
			// 
			this.radioButtonFeminino.AutoSize = true;
			this.radioButtonFeminino.Location = new System.Drawing.Point(198, 157);
			this.radioButtonFeminino.Name = "radioButtonFeminino";
			this.radioButtonFeminino.Size = new System.Drawing.Size(75, 19);
			this.radioButtonFeminino.TabIndex = 11;
			this.radioButtonFeminino.Text = "Feminino";
			this.radioButtonFeminino.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 159);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "Sexo";
			// 
			// checkBoxNotificacao
			// 
			this.checkBoxNotificacao.AutoSize = true;
			this.checkBoxNotificacao.Location = new System.Drawing.Point(145, 218);
			this.checkBoxNotificacao.Name = "checkBoxNotificacao";
			this.checkBoxNotificacao.Size = new System.Drawing.Size(135, 19);
			this.checkBoxNotificacao.TabIndex = 13;
			this.checkBoxNotificacao.Text = "Receber notificações";
			this.checkBoxNotificacao.UseVisualStyleBackColor = true;
			// 
			// buttonCadastrar
			// 
			this.buttonCadastrar.Location = new System.Drawing.Point(50, 270);
			this.buttonCadastrar.Name = "buttonCadastrar";
			this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
			this.buttonCadastrar.TabIndex = 14;
			this.buttonCadastrar.Text = "Cadastrar";
			this.buttonCadastrar.UseVisualStyleBackColor = true;
			this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
			// 
			// textBoxCPF
			// 
			this.textBoxCPF.Location = new System.Drawing.Point(114, 41);
			this.textBoxCPF.Name = "textBoxCPF";
			this.textBoxCPF.Size = new System.Drawing.Size(159, 23);
			this.textBoxCPF.TabIndex = 2;
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(114, 12);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(159, 23);
			this.textBoxNome.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(0, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 15);
			this.label7.TabIndex = 18;
			this.label7.Text = "Possui Filhos";
			// 
			// radioButtonPossuiFilhosNao
			// 
			this.radioButtonPossuiFilhosNao.AutoSize = true;
			this.radioButtonPossuiFilhosNao.Checked = true;
			this.radioButtonPossuiFilhosNao.Location = new System.Drawing.Point(152, 7);
			this.radioButtonPossuiFilhosNao.Name = "radioButtonPossuiFilhosNao";
			this.radioButtonPossuiFilhosNao.Size = new System.Drawing.Size(47, 19);
			this.radioButtonPossuiFilhosNao.TabIndex = 17;
			this.radioButtonPossuiFilhosNao.TabStop = true;
			this.radioButtonPossuiFilhosNao.Text = "Não";
			this.radioButtonPossuiFilhosNao.UseVisualStyleBackColor = true;
			// 
			// radioButtonPossuiFilhosSim
			// 
			this.radioButtonPossuiFilhosSim.AutoSize = true;
			this.radioButtonPossuiFilhosSim.Location = new System.Drawing.Point(102, 7);
			this.radioButtonPossuiFilhosSim.Name = "radioButtonPossuiFilhosSim";
			this.radioButtonPossuiFilhosSim.Size = new System.Drawing.Size(45, 19);
			this.radioButtonPossuiFilhosSim.TabIndex = 16;
			this.radioButtonPossuiFilhosSim.Text = "Sim";
			this.radioButtonPossuiFilhosSim.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButtonPossuiFilhosNao);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.radioButtonPossuiFilhosSim);
			this.panel1.Location = new System.Drawing.Point(12, 182);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(268, 30);
			this.panel1.TabIndex = 19;
			// 
			// buttonLimpar
			// 
			this.buttonLimpar.Location = new System.Drawing.Point(164, 270);
			this.buttonLimpar.Name = "buttonLimpar";
			this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
			this.buttonLimpar.TabIndex = 22;
			this.buttonLimpar.Text = "Limpar";
			this.buttonLimpar.UseVisualStyleBackColor = true;
			this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
			// 
			// buttonExcluir
			// 
			this.buttonExcluir.Location = new System.Drawing.Point(445, 270);
			this.buttonExcluir.Name = "buttonExcluir";
			this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
			this.buttonExcluir.TabIndex = 23;
			this.buttonExcluir.Text = "Excluir";
			this.buttonExcluir.UseVisualStyleBackColor = true;
			this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
			// 
			// dataGridViewPessoas
			// 
			this.dataGridViewPessoas.AllowUserToAddRows = false;
			this.dataGridViewPessoas.AllowUserToDeleteRows = false;
			this.dataGridViewPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPessoas.Location = new System.Drawing.Point(291, 12);
			this.dataGridViewPessoas.MultiSelect = false;
			this.dataGridViewPessoas.Name = "dataGridViewPessoas";
			this.dataGridViewPessoas.ReadOnly = true;
			this.dataGridViewPessoas.RowTemplate.Height = 25;
			this.dataGridViewPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPessoas.Size = new System.Drawing.Size(249, 225);
			this.dataGridViewPessoas.TabIndex = 24;
			this.dataGridViewPessoas.SelectionChanged += new System.EventHandler(this.dataGridViewPessoas_SelectionChanged);
			// 
			// FormParaMigracao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 305);
			this.Controls.Add(this.dataGridViewPessoas);
			this.Controls.Add(this.buttonExcluir);
			this.Controls.Add(this.buttonLimpar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonCadastrar);
			this.Controls.Add(this.checkBoxNotificacao);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.radioButtonFeminino);
			this.Controls.Add(this.radioButtonMasculino);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxEstadoCivil);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxTelefone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxCPF);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxNome);
			this.Name = "FormParaMigracao";
			this.Text = "FormParaMigracao";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBoxEmail;
		private Label label4;
		private TextBox textBoxTelefone;
		private ComboBox comboBoxEstadoCivil;
		private Label label5;
		private RadioButton radioButtonMasculino;
		private RadioButton radioButtonFeminino;
		private Label label6;
		private CheckBox checkBoxNotificacao;
		private Button buttonCadastrar;
		private TextBox textBoxCPF;
		private TextBox textBoxNome;
		private Label label7;
		private RadioButton radioButtonPossuiFilhosNao;
		private RadioButton radioButtonPossuiFilhosSim;
		private Panel panel1;
		private Button buttonLimpar;
		private Button buttonExcluir;
		private DataGridView dataGridViewPessoas;
	}
}