namespace TCC
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxArquivo = new System.Windows.Forms.TextBox();
			this.btnBuscarArquivo = new System.Windows.Forms.Button();
			this.buttonMigrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDestino = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxArquivo
			// 
			this.textBoxArquivo.Location = new System.Drawing.Point(65, 6);
			this.textBoxArquivo.Name = "textBoxArquivo";
			this.textBoxArquivo.Size = new System.Drawing.Size(321, 23);
			this.textBoxArquivo.TabIndex = 0;
			// 
			// btnBuscarArquivo
			// 
			this.btnBuscarArquivo.Location = new System.Drawing.Point(392, 6);
			this.btnBuscarArquivo.Name = "btnBuscarArquivo";
			this.btnBuscarArquivo.Size = new System.Drawing.Size(27, 23);
			this.btnBuscarArquivo.TabIndex = 1;
			this.btnBuscarArquivo.Text = "...";
			this.btnBuscarArquivo.UseVisualStyleBackColor = true;
			this.btnBuscarArquivo.Click += new System.EventHandler(this.btnBuscarArquivo_Click);
			// 
			// buttonMigrar
			// 
			this.buttonMigrar.Location = new System.Drawing.Point(344, 76);
			this.buttonMigrar.Name = "buttonMigrar";
			this.buttonMigrar.Size = new System.Drawing.Size(75, 23);
			this.buttonMigrar.TabIndex = 2;
			this.buttonMigrar.Text = "Migrar";
			this.buttonMigrar.UseVisualStyleBackColor = true;
			this.buttonMigrar.Click += new System.EventHandler(this.buttonMigrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Origem";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Destino";
			// 
			// textBoxDestino
			// 
			this.textBoxDestino.Location = new System.Drawing.Point(65, 35);
			this.textBoxDestino.Name = "textBoxDestino";
			this.textBoxDestino.Size = new System.Drawing.Size(321, 23);
			this.textBoxDestino.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(392, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(27, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 110);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxDestino);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonMigrar);
			this.Controls.Add(this.btnBuscarArquivo);
			this.Controls.Add(this.textBoxArquivo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBoxArquivo;
		private Button btnBuscarArquivo;
		private Button buttonMigrar;
		private Label label1;
		private Label label2;
		private TextBox textBoxDestino;
		private Button button1;
	}
}