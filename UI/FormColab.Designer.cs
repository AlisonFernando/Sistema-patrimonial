﻿namespace UI
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
            escolherSetor = new ComboBox();
            HeaderCadColab = new Panel();
            label1 = new Label();
            check_ativo = new CheckBox();
            btnCadastrar = new Button();
            btnCancelarCad = new Button();
            FotterCadColab = new Panel();
            btn_selectEquips = new Button();
            HeaderCadColab.SuspendLayout();
            FotterCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(9, 125);
            Nome.Margin = new Padding(4, 0, 4, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(61, 25);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(9, 198);
            Email.Margin = new Padding(4, 0, 4, 0);
            Email.Name = "Email";
            Email.Size = new Size(61, 25);
            Email.TabIndex = 1;
            Email.Text = "E-mail";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(196, 272);
            Senha.Margin = new Padding(4, 0, 4, 0);
            Senha.Name = "Senha";
            Senha.Size = new Size(60, 25);
            Senha.TabIndex = 2;
            Senha.Text = "Senha";
            // 
            // Agenda
            // 
            Agenda.AutoSize = true;
            Agenda.Location = new Point(9, 345);
            Agenda.Margin = new Padding(4, 0, 4, 0);
            Agenda.Name = "Agenda";
            Agenda.Size = new Size(136, 25);
            Agenda.TabIndex = 3;
            Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(380, 125);
            Telefone.Margin = new Padding(4, 0, 4, 0);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(77, 25);
            Telefone.TabIndex = 4;
            Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            InputColabNome.Location = new Point(9, 155);
            InputColabNome.Margin = new Padding(4, 5, 4, 5);
            InputColabNome.MaxLength = 30;
            InputColabNome.Name = "InputColabNome";
            InputColabNome.Size = new Size(360, 31);
            InputColabNome.TabIndex = 1;
            // 
            // inputColabAgenda
            // 
            inputColabAgenda.Location = new Point(9, 375);
            inputColabAgenda.Margin = new Padding(4, 5, 4, 5);
            inputColabAgenda.MaxLength = 90;
            inputColabAgenda.Name = "inputColabAgenda";
            inputColabAgenda.Size = new Size(574, 31);
            inputColabAgenda.TabIndex = 7;
            // 
            // inputColabEmail
            // 
            inputColabEmail.Location = new Point(9, 228);
            inputColabEmail.Margin = new Padding(4, 5, 4, 5);
            inputColabEmail.MaxLength = 40;
            inputColabEmail.Name = "inputColabEmail";
            inputColabEmail.Size = new Size(361, 31);
            inputColabEmail.TabIndex = 2;
            // 
            // inputColabSenha
            // 
            inputColabSenha.Location = new Point(196, 302);
            inputColabSenha.Margin = new Padding(4, 5, 4, 5);
            inputColabSenha.MaxLength = 10;
            inputColabSenha.Name = "inputColabSenha";
            inputColabSenha.Size = new Size(173, 31);
            inputColabSenha.TabIndex = 5;
            inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            inputColabTel.Location = new Point(380, 155);
            inputColabTel.Margin = new Padding(4, 5, 4, 5);
            inputColabTel.MaxLength = 11;
            inputColabTel.Name = "inputColabTel";
            inputColabTel.Size = new Size(183, 31);
            inputColabTel.TabIndex = 4;
            // 
            // Setor
            // 
            Setor.AutoSize = true;
            Setor.Location = new Point(9, 272);
            Setor.Margin = new Padding(4, 0, 4, 0);
            Setor.Name = "Setor";
            Setor.Size = new Size(54, 25);
            Setor.TabIndex = 11;
            Setor.Text = "Setor";
            // 
            // escolherSetor
            // 
            escolherSetor.FormattingEnabled = true;
            escolherSetor.Items.AddRange(new object[] { "Engenharia", "Criação", "Administração", "Marketing", "Ligação", "TI" });
            escolherSetor.Location = new Point(9, 302);
            escolherSetor.Margin = new Padding(4, 5, 4, 5);
            escolherSetor.Name = "escolherSetor";
            escolherSetor.Size = new Size(177, 33);
            escolherSetor.TabIndex = 3;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Margin = new Padding(4, 5, 4, 5);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(594, 83);
            HeaderCadColab.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(178, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Colaborador";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(380, 228);
            check_ativo.Margin = new Padding(4, 5, 4, 5);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(80, 29);
            check_ativo.TabIndex = 6;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Dock = DockStyle.Right;
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(371, 10);
            btnCadastrar.Margin = new Padding(4, 5, 4, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(214, 53);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelarCad
            // 
            btnCancelarCad.BackColor = Color.DarkGreen;
            btnCancelarCad.Dock = DockStyle.Left;
            btnCancelarCad.ForeColor = SystemColors.Control;
            btnCancelarCad.Location = new Point(9, 10);
            btnCancelarCad.Margin = new Padding(4, 5, 4, 5);
            btnCancelarCad.Name = "btnCancelarCad";
            btnCancelarCad.Size = new Size(214, 53);
            btnCancelarCad.TabIndex = 15;
            btnCancelarCad.Text = "Cancelar";
            btnCancelarCad.UseVisualStyleBackColor = false;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btnCancelarCad);
            FotterCadColab.Controls.Add(btnCadastrar);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 465);
            FotterCadColab.Margin = new Padding(4, 5, 4, 5);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(9, 10, 9, 10);
            FotterCadColab.Size = new Size(594, 73);
            FotterCadColab.TabIndex = 15;
            // 
            // btn_selectEquips
            // 
            btn_selectEquips.BackColor = Color.DarkGreen;
            btn_selectEquips.ForeColor = Color.White;
            btn_selectEquips.Location = new Point(12, 413);
            btn_selectEquips.Name = "btn_selectEquips";
            btn_selectEquips.Size = new Size(220, 44);
            btn_selectEquips.TabIndex = 17;
            btn_selectEquips.Text = "Selecionar equipamentos";
            btn_selectEquips.UseVisualStyleBackColor = false;
            btn_selectEquips.Click += btn_selectEquips_Click;
            // 
            // CadColaborador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 538);
            Controls.Add(btn_selectEquips);
            Controls.Add(check_ativo);
            Controls.Add(HeaderCadColab);
            Controls.Add(FotterCadColab);
            Controls.Add(escolherSetor);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "CadColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Colaborador";
            Load += CadColaborador_Load;
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            FotterCadColab.ResumeLayout(false);
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
        private ComboBox escolherSetor;
        private Panel HeaderCadColab;
        private CheckBox check_ativo;
        private Label label1;
        private Button btnCadastrar;
        private Button btnCancelarCad;
        private Panel FotterCadColab;
        private Button btn_selectEquips;
    }
}