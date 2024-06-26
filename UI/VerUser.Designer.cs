﻿namespace UI
{
    partial class VerUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUser));
            panel2 = new Panel();
            header = new Label();
            MostrarUsuarios = new DataGridView();
            panel1 = new Panel();
            btnVoltar = new Button();
            btnCadUser = new Button();
            txtID = new TextBox();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SenhaH = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            UserAcesso = new DataGridViewTextBoxColumn();
            ConfirmarEmail = new DataGridViewTextBoxColumn();
            ConfirmarSenha = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            btnLimpar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(header);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 83);
            panel2.TabIndex = 11;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            header.ForeColor = SystemColors.Control;
            header.Location = new Point(296, 15);
            header.Margin = new Padding(4, 0, 4, 0);
            header.Name = "header";
            header.Size = new Size(315, 41);
            header.TabIndex = 11;
            header.Text = "Usuarios cadastrados";
            header.TextAlign = ContentAlignment.TopCenter;
            // 
            // MostrarUsuarios
            // 
            MostrarUsuarios.AllowUserToAddRows = false;
            MostrarUsuarios.AllowUserToDeleteRows = false;
            MostrarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Email, SenhaH, Senha, UserAcesso, ConfirmarEmail, ConfirmarSenha, Ativo_inativo });
            MostrarUsuarios.Location = new Point(119, 190);
            MostrarUsuarios.Name = "MostrarUsuarios";
            MostrarUsuarios.ReadOnly = true;
            MostrarUsuarios.RowHeadersWidth = 62;
            MostrarUsuarios.RowTemplate.Height = 33;
            MostrarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarUsuarios.Size = new Size(644, 308);
            MostrarUsuarios.TabIndex = 13;
            MostrarUsuarios.CellContentClick += MostrarUsuarios_CellContentClick;
            MostrarUsuarios.CellMouseDoubleClick += MostrarUsuarios_CellMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnCadUser);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 592);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(899, 83);
            panel1.TabIndex = 28;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Dock = DockStyle.Left;
            btnVoltar.ForeColor = SystemColors.Control;
            btnVoltar.Location = new Point(9, 10);
            btnVoltar.Margin = new Padding(4, 5, 4, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(199, 63);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadUser
            // 
            btnCadUser.BackColor = Color.DarkGreen;
            btnCadUser.Cursor = Cursors.Hand;
            btnCadUser.Dock = DockStyle.Right;
            btnCadUser.ForeColor = SystemColors.Control;
            btnCadUser.Location = new Point(641, 10);
            btnCadUser.Margin = new Padding(4, 5, 4, 5);
            btnCadUser.Name = "btnCadUser";
            btnCadUser.Padding = new Padding(6, 7, 6, 7);
            btnCadUser.Size = new Size(249, 63);
            btnCadUser.TabIndex = 7;
            btnCadUser.Text = "Cadastrar usuario";
            btnCadUser.UseVisualStyleBackColor = false;
            btnCadUser.Click += btnVerEquips_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(239, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 23;
            txtID.Visible = false;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(119, 153);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(258, 31);
            txtPesquisar.TabIndex = 29;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(396, 147);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(258, 42);
            btnPesquisar.TabIndex = 30;
            btnPesquisar.Text = "Pesquisar por nome ou e-mail";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "id_usuario";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 80;
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
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 300;
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
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(119, 504);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(89, 42);
            btnLimpar.TabIndex = 31;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // VerUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 675);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(panel1);
            Controls.Add(MostrarUsuarios);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "VerUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar usuarios";
            Load += VerUser_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label header;
        private DataGridView MostrarUsuarios;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnVoltar;
        private Button btnCadUser;
        private TextBox txtID;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SenhaH;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn UserAcesso;
        private DataGridViewTextBoxColumn ConfirmarEmail;
        private DataGridViewTextBoxColumn ConfirmarSenha;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private Button btnLimpar;
    }
}