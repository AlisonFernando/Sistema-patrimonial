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
            Nome = new Label();
            Email = new Label();
            Senha = new Label();
            Agenda = new Label();
            Telefone = new Label();
            InputColabNome = new TextBox();
            inputColabAgenda = new TextBox();
            inputColabEmail = new TextBox();
            inputColabSenha = new TextBox();
            inputColabTel = new TextBox();
            Setor = new Label();
            selectSetorColab = new ComboBox();
            btnCadColab = new Button();
            FotterCadColab = new Panel();
            btnCancelarCad = new Button();
            HeaderCadColab = new Panel();
            label1 = new Label();
            Ativo_inativo = new CheckBox();
            FotterCadColab.SuspendLayout();
            HeaderCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(6, 75);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(6, 119);
            Email.Name = "Email";
            Email.Size = new Size(41, 15);
            Email.TabIndex = 1;
            Email.Text = "E-mail";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(280, 119);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 2;
            Senha.Text = "Senha";
            // 
            // Agenda
            // 
            Agenda.AutoSize = true;
            Agenda.Location = new Point(6, 207);
            Agenda.Name = "Agenda";
            Agenda.Size = new Size(88, 15);
            Agenda.TabIndex = 3;
            Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(280, 75);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 4;
            Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            InputColabNome.Location = new Point(6, 93);
            InputColabNome.MaxLength = 30;
            InputColabNome.Name = "InputColabNome";
            InputColabNome.Size = new Size(253, 23);
            InputColabNome.TabIndex = 1;
            // 
            // inputColabAgenda
            // 
            inputColabAgenda.Location = new Point(6, 225);
            inputColabAgenda.MaxLength = 90;
            inputColabAgenda.Name = "inputColabAgenda";
            inputColabAgenda.Size = new Size(403, 23);
            inputColabAgenda.TabIndex = 7;
            // 
            // inputColabEmail
            // 
            inputColabEmail.Location = new Point(6, 137);
            inputColabEmail.MaxLength = 40;
            inputColabEmail.Name = "inputColabEmail";
            inputColabEmail.Size = new Size(254, 23);
            inputColabEmail.TabIndex = 2;
            // 
            // inputColabSenha
            // 
            inputColabSenha.Location = new Point(280, 137);
            inputColabSenha.MaxLength = 10;
            inputColabSenha.Name = "inputColabSenha";
            inputColabSenha.Size = new Size(129, 23);
            inputColabSenha.TabIndex = 5;
            inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            inputColabTel.Location = new Point(280, 93);
            inputColabTel.MaxLength = 11;
            inputColabTel.Name = "inputColabTel";
            inputColabTel.Size = new Size(129, 23);
            inputColabTel.TabIndex = 4;
            // 
            // Setor
            // 
            Setor.AutoSize = true;
            Setor.Location = new Point(6, 163);
            Setor.Name = "Setor";
            Setor.Size = new Size(34, 15);
            Setor.TabIndex = 11;
            Setor.Text = "Setor";
            // 
            // selectSetorColab
            // 
            selectSetorColab.FormattingEnabled = true;
            selectSetorColab.Items.AddRange(new object[] { "Engenharia", "Criação", "Administração", "Marketing", "Ligação", "TI" });
            selectSetorColab.Location = new Point(6, 181);
            selectSetorColab.Name = "selectSetorColab";
            selectSetorColab.Size = new Size(125, 23);
            selectSetorColab.TabIndex = 3;
            // 
            // btnCadColab
            // 
            btnCadColab.BackColor = Color.DarkGreen;
            btnCadColab.Dock = DockStyle.Right;
            btnCadColab.ForeColor = SystemColors.Control;
            btnCadColab.Location = new Point(271, 6);
            btnCadColab.Name = "btnCadColab";
            btnCadColab.Size = new Size(150, 38);
            btnCadColab.TabIndex = 8;
            btnCadColab.Text = "Cadastrar";
            btnCadColab.UseVisualStyleBackColor = false;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btnCancelarCad);
            FotterCadColab.Controls.Add(btnCadColab);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 435);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(6);
            FotterCadColab.Size = new Size(427, 50);
            FotterCadColab.TabIndex = 15;
            // 
            // btnCancelarCad
            // 
            btnCancelarCad.BackColor = Color.DarkGreen;
            btnCancelarCad.Dock = DockStyle.Left;
            btnCancelarCad.ForeColor = SystemColors.Control;
            btnCancelarCad.Location = new Point(6, 6);
            btnCancelarCad.Name = "btnCancelarCad";
            btnCancelarCad.Size = new Size(150, 38);
            btnCancelarCad.TabIndex = 15;
            btnCancelarCad.Text = "Cancelar";
            btnCancelarCad.UseVisualStyleBackColor = false;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(427, 50);
            HeaderCadColab.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(143, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Colaborador";
            // 
            // Ativo_inativo
            // 
            Ativo_inativo.AutoSize = true;
            Ativo_inativo.Location = new Point(280, 166);
            Ativo_inativo.Name = "Ativo_inativo";
            Ativo_inativo.Size = new Size(54, 19);
            Ativo_inativo.TabIndex = 6;
            Ativo_inativo.Text = "Ativo";
            Ativo_inativo.UseVisualStyleBackColor = true;
            // 
            // CadColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 485);
            Controls.Add(Ativo_inativo);
            Controls.Add(HeaderCadColab);
            Controls.Add(FotterCadColab);
            Controls.Add(selectSetorColab);
            Controls.Add(Setor);
            Controls.Add(inputColabTel);
            Controls.Add(inputColabSenha);
            Controls.Add(inputColabEmail);
            Controls.Add(inputColabAgenda);
            Controls.Add(InputColabNome);
            Controls.Add(Telefone);
            Controls.Add(Agenda);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(Nome);
            MaximizeBox = false;
            Name = "CadColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Colaborador";
            FotterCadColab.ResumeLayout(false);
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnCadColab;
        private Panel FotterCadColab;
        private Button btnCancelarCad;
        private Panel HeaderCadColab;
        private CheckBox Ativo_inativo;
        private Label label1;
    }
}