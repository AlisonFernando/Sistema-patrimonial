﻿namespace UI
{
    partial class TelaCadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadUser));
            txtUserNome = new Label();
            txtEmailUser = new Label();
            txtUserSenha = new Label();
            panel1 = new Panel();
            btnCadUserSucesso = new Button();
            btnCancelarCadUser = new Button();
            txtID = new TextBox();
            inputUserNome = new TextBox();
            inputUserEmail = new TextBox();
            inputUserSenha = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            txtConfirEmail = new TextBox();
            label2 = new Label();
            txtConfirSenha = new TextBox();
            label3 = new Label();
            btn_limpar = new Button();
            MostrarUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            UserAcesso = new DataGridViewTextBoxColumn();
            SenhaH = new DataGridViewTextBoxColumn();
            ConfirmarEmail = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ConfirmarSenha = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            btnDesativar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnVerUser = new Button();
            ComboBoxAcesso = new ComboBox();
            checkAtivo = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtUserNome
            // 
            txtUserNome.AutoSize = true;
            txtUserNome.Location = new Point(127, 127);
            txtUserNome.Margin = new Padding(4, 0, 4, 0);
            txtUserNome.Name = "txtUserNome";
            txtUserNome.Size = new Size(61, 25);
            txtUserNome.TabIndex = 22;
            txtUserNome.Text = "Nome";
            // 
            // txtEmailUser
            // 
            txtEmailUser.AutoSize = true;
            txtEmailUser.Location = new Point(127, 198);
            txtEmailUser.Margin = new Padding(4, 0, 4, 0);
            txtEmailUser.Name = "txtEmailUser";
            txtEmailUser.Size = new Size(61, 25);
            txtEmailUser.TabIndex = 1;
            txtEmailUser.Text = "E-mail";
            // 
            // txtUserSenha
            // 
            txtUserSenha.AutoSize = true;
            txtUserSenha.Location = new Point(134, 345);
            txtUserSenha.Margin = new Padding(4, 0, 4, 0);
            txtUserSenha.Name = "txtUserSenha";
            txtUserSenha.Size = new Size(60, 25);
            txtUserSenha.TabIndex = 2;
            txtUserSenha.Text = "Senha";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCadUserSucesso);
            panel1.Controls.Add(btnCancelarCadUser);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 901);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(567, 83);
            panel1.TabIndex = 19;
            // 
            // btnCadUserSucesso
            // 
            btnCadUserSucesso.BackColor = Color.DarkGreen;
            btnCadUserSucesso.Dock = DockStyle.Right;
            btnCadUserSucesso.ForeColor = Color.White;
            btnCadUserSucesso.Location = new Point(344, 10);
            btnCadUserSucesso.Name = "btnCadUserSucesso";
            btnCadUserSucesso.Padding = new Padding(4, 5, 4, 5);
            btnCadUserSucesso.Size = new Size(214, 63);
            btnCadUserSucesso.TabIndex = 8;
            btnCadUserSucesso.Text = "Aplicar";
            btnCadUserSucesso.UseVisualStyleBackColor = false;
            btnCadUserSucesso.Click += btnCadUserSucesso_Click;
            // 
            // btnCancelarCadUser
            // 
            btnCancelarCadUser.BackColor = Color.DarkGreen;
            btnCancelarCadUser.Dock = DockStyle.Left;
            btnCancelarCadUser.ForeColor = Color.White;
            btnCancelarCadUser.Location = new Point(9, 10);
            btnCancelarCadUser.Margin = new Padding(4, 5, 4, 5);
            btnCancelarCadUser.Name = "btnCancelarCadUser";
            btnCancelarCadUser.Size = new Size(214, 63);
            btnCancelarCadUser.TabIndex = 7;
            btnCancelarCadUser.Text = "Cancelar";
            btnCancelarCadUser.UseVisualStyleBackColor = false;
            btnCancelarCadUser.Click += btnCancelarCadUser_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(231, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(93, 31);
            txtID.TabIndex = 26;
            txtID.Visible = false;
            // 
            // inputUserNome
            // 
            inputUserNome.Location = new Point(109, 157);
            inputUserNome.Margin = new Padding(4, 5, 4, 5);
            inputUserNome.MaxLength = 100;
            inputUserNome.Name = "inputUserNome";
            inputUserNome.Size = new Size(345, 31);
            inputUserNome.TabIndex = 1;
            // 
            // inputUserEmail
            // 
            inputUserEmail.Location = new Point(109, 228);
            inputUserEmail.Margin = new Padding(4, 5, 4, 5);
            inputUserEmail.MaxLength = 100;
            inputUserEmail.Name = "inputUserEmail";
            inputUserEmail.Size = new Size(345, 31);
            inputUserEmail.TabIndex = 2;
            // 
            // inputUserSenha
            // 
            inputUserSenha.Location = new Point(109, 375);
            inputUserSenha.Margin = new Padding(4, 5, 4, 5);
            inputUserSenha.MaxLength = 100;
            inputUserSenha.Name = "inputUserSenha";
            inputUserSenha.Size = new Size(345, 31);
            inputUserSenha.TabIndex = 4;
            inputUserSenha.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 83);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(151, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 11;
            label1.Text = "Cadastrar usuário";
            // 
            // txtConfirEmail
            // 
            txtConfirEmail.Location = new Point(109, 302);
            txtConfirEmail.Margin = new Padding(4, 5, 4, 5);
            txtConfirEmail.MaxLength = 100;
            txtConfirEmail.Name = "txtConfirEmail";
            txtConfirEmail.Size = new Size(351, 31);
            txtConfirEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 272);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 12;
            label2.Text = "Confirmar e-mail";
            // 
            // txtConfirSenha
            // 
            txtConfirSenha.Location = new Point(109, 445);
            txtConfirSenha.Margin = new Padding(4, 5, 4, 5);
            txtConfirSenha.MaxLength = 100;
            txtConfirSenha.Name = "txtConfirSenha";
            txtConfirSenha.Size = new Size(345, 31);
            txtConfirSenha.TabIndex = 5;
            txtConfirSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 415);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 13;
            label3.Text = "Confirmar senha";
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.DarkGreen;
            btn_limpar.ForeColor = Color.White;
            btn_limpar.Location = new Point(47, 808);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(144, 63);
            btn_limpar.TabIndex = 28;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // MostrarUsuarios
            // 
            MostrarUsuarios.AllowUserToAddRows = false;
            MostrarUsuarios.AllowUserToDeleteRows = false;
            MostrarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, UserAcesso, SenhaH, ConfirmarEmail, Email, ConfirmarSenha, Ativo_inativo, Senha });
            MostrarUsuarios.Location = new Point(19, 564);
            MostrarUsuarios.Name = "MostrarUsuarios";
            MostrarUsuarios.ReadOnly = true;
            MostrarUsuarios.RowHeadersVisible = false;
            MostrarUsuarios.RowHeadersWidth = 62;
            MostrarUsuarios.RowTemplate.Height = 33;
            MostrarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarUsuarios.Size = new Size(530, 237);
            MostrarUsuarios.TabIndex = 23;
            MostrarUsuarios.CellMouseDoubleClick += MostrarUsuarios_CellMouseDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "id_usuario";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 50;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // UserAcesso
            // 
            UserAcesso.DataPropertyName = "UserAcesso";
            UserAcesso.HeaderText = "Nivel de acesso";
            UserAcesso.MinimumWidth = 8;
            UserAcesso.Name = "UserAcesso";
            UserAcesso.ReadOnly = true;
            UserAcesso.Visible = false;
            UserAcesso.Width = 190;
            // 
            // SenhaH
            // 
            SenhaH.DataPropertyName = "SenhaHash";
            SenhaH.HeaderText = "SenhaH";
            SenhaH.MinimumWidth = 8;
            SenhaH.Name = "SenhaH";
            SenhaH.ReadOnly = true;
            SenhaH.Visible = false;
            SenhaH.Width = 150;
            // 
            // ConfirmarEmail
            // 
            ConfirmarEmail.DataPropertyName = "ConfirmarEmail";
            ConfirmarEmail.HeaderText = "ConfirmarEmail";
            ConfirmarEmail.MinimumWidth = 8;
            ConfirmarEmail.Name = "ConfirmarEmail";
            ConfirmarEmail.ReadOnly = true;
            ConfirmarEmail.Visible = false;
            ConfirmarEmail.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-mail";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 275;
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.DataPropertyName = "ConfirmarSenha";
            ConfirmarSenha.HeaderText = "ConfirmarSenha";
            ConfirmarSenha.MinimumWidth = 8;
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.ReadOnly = true;
            ConfirmarSenha.Visible = false;
            ConfirmarSenha.Width = 150;
            // 
            // Ativo_inativo
            // 
            Ativo_inativo.DataPropertyName = "Ativo_inativo";
            Ativo_inativo.HeaderText = "Ativo_inativo";
            Ativo_inativo.MinimumWidth = 8;
            Ativo_inativo.Name = "Ativo_inativo";
            Ativo_inativo.ReadOnly = true;
            Ativo_inativo.Visible = false;
            Ativo_inativo.Width = 150;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "Senha";
            Senha.MinimumWidth = 8;
            Senha.Name = "Senha";
            Senha.ReadOnly = true;
            Senha.Visible = false;
            Senha.Width = 150;
            // 
            // btnDesativar
            // 
            btnDesativar.BackColor = Color.DarkGreen;
            btnDesativar.ForeColor = SystemColors.Control;
            btnDesativar.Location = new Point(218, 808);
            btnDesativar.Margin = new Padding(4, 5, 4, 5);
            btnDesativar.Name = "btnDesativar";
            btnDesativar.Size = new Size(134, 62);
            btnDesativar.TabIndex = 24;
            btnDesativar.Text = "Desativar";
            btnDesativar.UseVisualStyleBackColor = false;
            btnDesativar.Click += btnDesativar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(114, 127);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 25;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(114, 198);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 26;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(116, 273);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 27;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(116, 345);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 28;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(116, 415);
            label8.Name = "label8";
            label8.Size = new Size(20, 25);
            label8.TabIndex = 29;
            label8.Text = "*";
            // 
            // btnVerUser
            // 
            btnVerUser.BackColor = Color.DarkGreen;
            btnVerUser.ForeColor = Color.White;
            btnVerUser.Location = new Point(383, 807);
            btnVerUser.Name = "btnVerUser";
            btnVerUser.Size = new Size(134, 63);
            btnVerUser.TabIndex = 30;
            btnVerUser.Text = "Ver usuarios";
            btnVerUser.UseVisualStyleBackColor = false;
            btnVerUser.Click += btnVerUser_Click;
            // 
            // ComboBoxAcesso
            // 
            ComboBoxAcesso.FormattingEnabled = true;
            ComboBoxAcesso.Location = new Point(109, 492);
            ComboBoxAcesso.Name = "ComboBoxAcesso";
            ComboBoxAcesso.Size = new Size(183, 33);
            ComboBoxAcesso.TabIndex = 6;
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Location = new Point(314, 492);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(140, 29);
            checkAtivo.TabIndex = 31;
            checkAtivo.Text = "Ativo/inativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // TelaCadUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 984);
            Controls.Add(checkAtivo);
            Controls.Add(ComboBoxAcesso);
            Controls.Add(btnVerUser);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUserNome);
            Controls.Add(label4);
            Controls.Add(btnDesativar);
            Controls.Add(MostrarUsuarios);
            Controls.Add(btn_limpar);
            Controls.Add(txtConfirSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtConfirEmail);
            Controls.Add(panel2);
            Controls.Add(inputUserSenha);
            Controls.Add(inputUserEmail);
            Controls.Add(inputUserNome);
            Controls.Add(panel1);
            Controls.Add(txtUserSenha);
            Controls.Add(txtEmailUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "TelaCadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar usuario";
            Load += TelaCadUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUserNome;
        private Label txtEmailUser;
        private Label txtUserSenha;
        private Panel panel1;
        private TextBox inputUserNome;
        private TextBox inputUserEmail;
        private TextBox inputUserSenha;
        private Panel panel2;
        private Label label1;
        private TextBox txtConfirEmail;
        private Label label2;
        private TextBox txtConfirSenha;
        private Label label3;
        private Button btn_limpar;
        private DataGridView MostrarUsuarios;
        private Button btnDesativar;
        private TextBox txtID;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button btnCancelarCadUser;
        private Button btnCadUserSucesso;
        private Button btnVerUser;
        private ComboBox ComboBoxAcesso;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn UserAcesso;
        private DataGridViewTextBoxColumn SenhaH;
        private DataGridViewTextBoxColumn ConfirmarEmail;
        private DataGridViewTextBoxColumn ConfirmarSenha;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private CheckBox checkAtivo;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Senha;
    }
}