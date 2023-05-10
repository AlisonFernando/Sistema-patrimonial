namespace UI
{
    partial class CadColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadColaborador));
            this.Nome = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.Agenda = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.InputColabNome = new System.Windows.Forms.TextBox();
            this.inputColabAgenda = new System.Windows.Forms.TextBox();
            this.inputColabEmail = new System.Windows.Forms.TextBox();
            this.inputColabSenha = new System.Windows.Forms.TextBox();
            this.inputColabTel = new System.Windows.Forms.TextBox();
            this.Setor = new System.Windows.Forms.Label();
            this.selectSetorColab = new System.Windows.Forms.ComboBox();
            this.infoCadColab = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoCadColab)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 28);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 88);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 15);
            this.Email.TabIndex = 1;
            this.Email.Text = "E-mail";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(286, 28);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(39, 15);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // Agenda
            // 
            this.Agenda.AutoSize = true;
            this.Agenda.Location = new System.Drawing.Point(12, 142);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(88, 15);
            this.Agenda.TabIndex = 3;
            this.Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(286, 88);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(51, 15);
            this.Telefone.TabIndex = 4;
            this.Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            this.InputColabNome.Location = new System.Drawing.Point(12, 46);
            this.InputColabNome.Name = "InputColabNome";
            this.InputColabNome.PlaceholderText = "Digite o nome do colaborador";
            this.InputColabNome.Size = new System.Drawing.Size(268, 23);
            this.InputColabNome.TabIndex = 6;
            // 
            // inputColabAgenda
            // 
            this.inputColabAgenda.Location = new System.Drawing.Point(12, 160);
            this.inputColabAgenda.Name = "inputColabAgenda";
            this.inputColabAgenda.PlaceholderText = "Agenda google do colaborador";
            this.inputColabAgenda.Size = new System.Drawing.Size(381, 23);
            this.inputColabAgenda.TabIndex = 7;
            // 
            // inputColabEmail
            // 
            this.inputColabEmail.Location = new System.Drawing.Point(12, 106);
            this.inputColabEmail.Name = "inputColabEmail";
            this.inputColabEmail.PlaceholderText = "E-mail do colaborador";
            this.inputColabEmail.Size = new System.Drawing.Size(268, 23);
            this.inputColabEmail.TabIndex = 8;
            // 
            // inputColabSenha
            // 
            this.inputColabSenha.Location = new System.Drawing.Point(286, 46);
            this.inputColabSenha.MaxLength = 10;
            this.inputColabSenha.Name = "inputColabSenha";
            this.inputColabSenha.PlaceholderText = "Digite uma senha";
            this.inputColabSenha.Size = new System.Drawing.Size(129, 23);
            this.inputColabSenha.TabIndex = 9;
            this.inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            this.inputColabTel.Location = new System.Drawing.Point(286, 106);
            this.inputColabTel.MaxLength = 11;
            this.inputColabTel.Name = "inputColabTel";
            this.inputColabTel.PlaceholderText = "Telefone empresarial";
            this.inputColabTel.Size = new System.Drawing.Size(129, 23);
            this.inputColabTel.TabIndex = 10;
            // 
            // Setor
            // 
            this.Setor.AutoSize = true;
            this.Setor.Location = new System.Drawing.Point(12, 195);
            this.Setor.Name = "Setor";
            this.Setor.Size = new System.Drawing.Size(34, 15);
            this.Setor.TabIndex = 11;
            this.Setor.Text = "Setor";
            // 
            // selectSetorColab
            // 
            this.selectSetorColab.FormattingEnabled = true;
            this.selectSetorColab.Items.AddRange(new object[] {
            "Engenharia",
            "Criação",
            "Administração",
            "Marketing",
            "Ligação",
            "TI"});
            this.selectSetorColab.Location = new System.Drawing.Point(52, 192);
            this.selectSetorColab.Name = "selectSetorColab";
            this.selectSetorColab.Size = new System.Drawing.Size(125, 23);
            this.selectSetorColab.TabIndex = 13;
            // 
            // infoCadColab
            // 
            this.infoCadColab.AllowUserToAddRows = false;
            this.infoCadColab.AllowUserToDeleteRows = false;
            this.infoCadColab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoCadColab.Location = new System.Drawing.Point(12, 232);
            this.infoCadColab.Name = "infoCadColab";
            this.infoCadColab.ReadOnly = true;
            this.infoCadColab.RowTemplate.Height = 25;
            this.infoCadColab.Size = new System.Drawing.Size(480, 163);
            this.infoCadColab.TabIndex = 14;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Location = new System.Drawing.Point(53, 406);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 33);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo registro";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(147, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 33);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(241, 406);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 33);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Location = new System.Drawing.Point(335, 406);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 33);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Limpar campos";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // CadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 451);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.infoCadColab);
            this.Controls.Add(this.selectSetorColab);
            this.Controls.Add(this.Setor);
            this.Controls.Add(this.inputColabTel);
            this.Controls.Add(this.inputColabSenha);
            this.Controls.Add(this.inputColabEmail);
            this.Controls.Add(this.inputColabAgenda);
            this.Controls.Add(this.InputColabNome);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Colaborador";
            ((System.ComponentModel.ISupportInitialize)(this.infoCadColab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nome;
        private Label Email;
        private Label Senha;
        private Label Agenda;
        private Label Telefone;
        private TextBox InputColabNome;
        private TextBox inputColabAgenda;
        private TextBox inputColabEmail;
        private TextBox inputColabSenha;
        private TextBox inputColabTel;
        private Label Setor;
        private ComboBox selectSetorColab;
        private DataGridView infoCadColab;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}