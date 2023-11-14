namespace UI
{
    partial class TelaEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEsqueciSenha));
            panel1 = new Panel();
            btn_voltar = new Button();
            label1 = new Label();
            MostrarUsuarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SenhaHash = new DataGridViewTextBoxColumn();
            ConfirmarEmail = new DataGridViewTextBoxColumn();
            UserAcesso = new DataGridViewTextBoxColumn();
            ConfirmarSenha = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            panel2 = new Panel();
            txtID = new TextBox();
            btnCancelar = new Button();
            btnRecuperar = new Button();
            btnLimpar = new Button();
            txtUserNome = new Label();
            lblRed1 = new Label();
            txtSenhaLabel = new Label();
            txtSenhaNova = new TextBox();
            lblRed3 = new Label();
            txtEmail = new TextBox();
            txtToken = new TextBox();
            txtTokenEmail = new Label();
            lblRed2 = new Label();
            btnRedefinirSenha = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 83);
            panel1.TabIndex = 19;
            // 
            // btn_voltar
            // 
            btn_voltar.AutoSize = true;
            btn_voltar.BackColor = Color.White;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.ForeColor = Color.DimGray;
            btn_voltar.Image = Properties.Resources.seta_esquerda;
            btn_voltar.Location = new Point(12, 22);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(46, 44);
            btn_voltar.TabIndex = 1;
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(253, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 41);
            label1.TabIndex = 0;
            label1.Text = "Recuperar senha";
            // 
            // MostrarUsuarios
            // 
            MostrarUsuarios.AllowUserToAddRows = false;
            MostrarUsuarios.AllowUserToDeleteRows = false;
            MostrarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Email, SenhaHash, ConfirmarEmail, UserAcesso, ConfirmarSenha, Senha });
            MostrarUsuarios.Location = new Point(123, 513);
            MostrarUsuarios.Name = "MostrarUsuarios";
            MostrarUsuarios.ReadOnly = true;
            MostrarUsuarios.RowHeadersWidth = 62;
            MostrarUsuarios.RowTemplate.Height = 33;
            MostrarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarUsuarios.Size = new Size(525, 225);
            MostrarUsuarios.TabIndex = 21;
            MostrarUsuarios.CellMouseDoubleClick += MostrarUsuarios_CellMouseDoubleClick;
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
            Nome.HeaderText = "Usuario";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 180;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 200;
            // 
            // SenhaHash
            // 
            SenhaHash.DataPropertyName = "SenhaHash";
            SenhaHash.HeaderText = "SenhaHash";
            SenhaHash.MinimumWidth = 8;
            SenhaHash.Name = "SenhaHash";
            SenhaHash.ReadOnly = true;
            SenhaHash.Visible = false;
            SenhaHash.Width = 150;
            // 
            // ConfirmarEmail
            // 
            ConfirmarEmail.DataPropertyName = "ConfirmarEmail";
            ConfirmarEmail.HeaderText = "Confirmar Email";
            ConfirmarEmail.MinimumWidth = 8;
            ConfirmarEmail.Name = "ConfirmarEmail";
            ConfirmarEmail.ReadOnly = true;
            ConfirmarEmail.Visible = false;
            ConfirmarEmail.Width = 150;
            // 
            // UserAcesso
            // 
            UserAcesso.DataPropertyName = "UserAcesso";
            UserAcesso.HeaderText = "UserAcesso";
            UserAcesso.MinimumWidth = 8;
            UserAcesso.Name = "UserAcesso";
            UserAcesso.ReadOnly = true;
            UserAcesso.Visible = false;
            UserAcesso.Width = 150;
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
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(123, 476);
            txtPesquisar.MaxLength = 100;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(379, 31);
            txtPesquisar.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(508, 470);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(140, 43);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnRecuperar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 804);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(757, 83);
            panel2.TabIndex = 25;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(345, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(117, 31);
            txtID.TabIndex = 10;
            txtID.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGreen;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Dock = DockStyle.Left;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(9, 10);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(6);
            btnCancelar.Size = new Size(207, 63);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.BackColor = Color.DarkGreen;
            btnRecuperar.Cursor = Cursors.Hand;
            btnRecuperar.Dock = DockStyle.Right;
            btnRecuperar.ForeColor = SystemColors.Control;
            btnRecuperar.Location = new Point(541, 10);
            btnRecuperar.Margin = new Padding(4, 5, 4, 5);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Padding = new Padding(6);
            btnRecuperar.Size = new Size(207, 63);
            btnRecuperar.TabIndex = 8;
            btnRecuperar.Text = "Recuperar senha";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(123, 744);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 37);
            btnLimpar.TabIndex = 32;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtUserNome
            // 
            txtUserNome.AutoSize = true;
            txtUserNome.Location = new Point(206, 151);
            txtUserNome.Margin = new Padding(4, 0, 4, 0);
            txtUserNome.Name = "txtUserNome";
            txtUserNome.Size = new Size(137, 25);
            txtUserNome.TabIndex = 33;
            txtUserNome.Text = "Digite um email";
            // 
            // lblRed1
            // 
            lblRed1.AutoSize = true;
            lblRed1.ForeColor = Color.Red;
            lblRed1.Location = new Point(191, 151);
            lblRed1.Name = "lblRed1";
            lblRed1.Size = new Size(20, 25);
            lblRed1.TabIndex = 34;
            lblRed1.Text = "*";
            // 
            // txtSenhaLabel
            // 
            txtSenhaLabel.AutoSize = true;
            txtSenhaLabel.Location = new Point(206, 289);
            txtSenhaLabel.Margin = new Padding(4, 0, 4, 0);
            txtSenhaLabel.Name = "txtSenhaLabel";
            txtSenhaLabel.Size = new Size(194, 25);
            txtSenhaLabel.TabIndex = 38;
            txtSenhaLabel.Text = "Digite uma nova senha";
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.Location = new Point(191, 317);
            txtSenhaNova.MaxLength = 100;
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.Size = new Size(379, 31);
            txtSenhaNova.TabIndex = 3;
            // 
            // lblRed3
            // 
            lblRed3.AutoSize = true;
            lblRed3.ForeColor = Color.Red;
            lblRed3.Location = new Point(191, 289);
            lblRed3.Name = "lblRed3";
            lblRed3.Size = new Size(20, 25);
            lblRed3.TabIndex = 39;
            lblRed3.Text = "*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 179);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(379, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtToken
            // 
            txtToken.Location = new Point(191, 248);
            txtToken.MaxLength = 100;
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(379, 31);
            txtToken.TabIndex = 2;
            // 
            // txtTokenEmail
            // 
            txtTokenEmail.AutoSize = true;
            txtTokenEmail.Location = new Point(206, 220);
            txtTokenEmail.Margin = new Padding(4, 0, 4, 0);
            txtTokenEmail.Name = "txtTokenEmail";
            txtTokenEmail.Size = new Size(305, 25);
            txtTokenEmail.TabIndex = 43;
            txtTokenEmail.Text = "Digite o token enviado no seu e-mail";
            // 
            // lblRed2
            // 
            lblRed2.AutoSize = true;
            lblRed2.ForeColor = Color.Red;
            lblRed2.Location = new Point(191, 220);
            lblRed2.Name = "lblRed2";
            lblRed2.Size = new Size(20, 25);
            lblRed2.TabIndex = 44;
            lblRed2.Text = "*";
            // 
            // btnRedefinirSenha
            // 
            btnRedefinirSenha.BackColor = Color.DarkGreen;
            btnRedefinirSenha.ForeColor = Color.White;
            btnRedefinirSenha.Location = new Point(191, 366);
            btnRedefinirSenha.Name = "btnRedefinirSenha";
            btnRedefinirSenha.Size = new Size(140, 43);
            btnRedefinirSenha.TabIndex = 4;
            btnRedefinirSenha.Text = "Redefinir senha";
            btnRedefinirSenha.UseVisualStyleBackColor = false;
            btnRedefinirSenha.Click += btnRedefinirSenha_Click;
            // 
            // TelaEsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 887);
            Controls.Add(btnRedefinirSenha);
            Controls.Add(txtTokenEmail);
            Controls.Add(lblRed2);
            Controls.Add(txtToken);
            Controls.Add(txtEmail);
            Controls.Add(lblRed3);
            Controls.Add(txtSenhaLabel);
            Controls.Add(txtSenhaNova);
            Controls.Add(txtUserNome);
            Controls.Add(lblRed1);
            Controls.Add(btnLimpar);
            Controls.Add(panel2);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(MostrarUsuarios);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "TelaEsqueciSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "|";
            Load += TelaEsqueciSenha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_voltar;
        private Label label1;
        private DataGridView MostrarUsuarios;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Panel panel2;
        private TextBox txtID;
        private Button btnCancelar;
        private Button btnRecuperar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SenhaHash;
        private DataGridViewTextBoxColumn ConfirmarEmail;
        private DataGridViewTextBoxColumn UserAcesso;
        private DataGridViewTextBoxColumn ConfirmarSenha;
        private DataGridViewTextBoxColumn Senha;
        private Button btnLimpar;
        private Label txtUserNome;
        private Label label4;
        private Label label3;
        private TextBox txtSenhaNova;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtToken;
        private Label label2;
        private Label label6;
        private Button btnRedefinirSenha;
        private Label lblRed1;
        private Label txtSenhaLabel;
        private Label lblRed3;
        private Label txtTokenEmail;
        private Label lblRed2;
    }
}