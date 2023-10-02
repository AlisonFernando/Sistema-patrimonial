namespace UI
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
            txtID = new TextBox();
            btnCancelarCadUser = new Button();
            btnCadUserSucesso = new Button();
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
            SenhaH = new DataGridViewTextBoxColumn();
            ConfirmarEmail = new DataGridViewTextBoxColumn();
            ConfirmarSenha = new DataGridViewTextBoxColumn();
            btnDeletar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtUserNome
            // 
            txtUserNome.AutoSize = true;
            txtUserNome.Location = new Point(50, 96);
            txtUserNome.Margin = new Padding(4, 0, 4, 0);
            txtUserNome.Name = "txtUserNome";
            txtUserNome.Size = new Size(61, 25);
            txtUserNome.TabIndex = 22;
            txtUserNome.Text = "Nome";
            // 
            // txtEmailUser
            // 
            txtEmailUser.AutoSize = true;
            txtEmailUser.Location = new Point(305, 96);
            txtEmailUser.Margin = new Padding(4, 0, 4, 0);
            txtEmailUser.Name = "txtEmailUser";
            txtEmailUser.Size = new Size(61, 25);
            txtEmailUser.TabIndex = 1;
            txtEmailUser.Text = "E-mail";
            // 
            // txtUserSenha
            // 
            txtUserSenha.AutoSize = true;
            txtUserSenha.Location = new Point(51, 162);
            txtUserSenha.Margin = new Padding(4, 0, 4, 0);
            txtUserSenha.Name = "txtUserSenha";
            txtUserSenha.Size = new Size(60, 25);
            txtUserSenha.TabIndex = 2;
            txtUserSenha.Text = "Senha";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnCancelarCadUser);
            panel1.Controls.Add(btnCadUserSucesso);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 666);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(567, 83);
            panel1.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(232, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 31);
            txtID.TabIndex = 26;
            txtID.Visible = false;
            // 
            // btnCancelarCadUser
            // 
            btnCancelarCadUser.BackColor = Color.DarkGreen;
            btnCancelarCadUser.Dock = DockStyle.Left;
            btnCancelarCadUser.ForeColor = SystemColors.Control;
            btnCancelarCadUser.Location = new Point(9, 10);
            btnCancelarCadUser.Margin = new Padding(4, 5, 4, 5);
            btnCancelarCadUser.Name = "btnCancelarCadUser";
            btnCancelarCadUser.Size = new Size(214, 63);
            btnCancelarCadUser.TabIndex = 6;
            btnCancelarCadUser.Text = "Cancelar";
            btnCancelarCadUser.UseVisualStyleBackColor = false;
            btnCancelarCadUser.Click += btnCancelarCadUser_Click;
            // 
            // btnCadUserSucesso
            // 
            btnCadUserSucesso.BackColor = Color.DarkGreen;
            btnCadUserSucesso.Dock = DockStyle.Right;
            btnCadUserSucesso.ForeColor = SystemColors.Control;
            btnCadUserSucesso.Location = new Point(344, 10);
            btnCadUserSucesso.Margin = new Padding(4, 5, 4, 5);
            btnCadUserSucesso.Name = "btnCadUserSucesso";
            btnCadUserSucesso.Size = new Size(214, 63);
            btnCadUserSucesso.TabIndex = 7;
            btnCadUserSucesso.Text = "Aplicar";
            btnCadUserSucesso.UseVisualStyleBackColor = false;
            btnCadUserSucesso.Click += btnCadUserSucesso_Click;
            // 
            // inputUserNome
            // 
            inputUserNome.Location = new Point(37, 126);
            inputUserNome.Margin = new Padding(4, 5, 4, 5);
            inputUserNome.MaxLength = 100;
            inputUserNome.Name = "inputUserNome";
            inputUserNome.Size = new Size(237, 31);
            inputUserNome.TabIndex = 1;
            // 
            // inputUserEmail
            // 
            inputUserEmail.Location = new Point(292, 126);
            inputUserEmail.Margin = new Padding(4, 5, 4, 5);
            inputUserEmail.MaxLength = 100;
            inputUserEmail.Name = "inputUserEmail";
            inputUserEmail.Size = new Size(237, 31);
            inputUserEmail.TabIndex = 2;
            // 
            // inputUserSenha
            // 
            inputUserSenha.Location = new Point(38, 192);
            inputUserSenha.Margin = new Padding(4, 5, 4, 5);
            inputUserSenha.MaxLength = 100;
            inputUserSenha.Name = "inputUserSenha";
            inputUserSenha.Size = new Size(237, 31);
            inputUserSenha.TabIndex = 3;
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
            label1.Location = new Point(137, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 11;
            label1.Text = "Cadastrar usuário";
            // 
            // txtConfirEmail
            // 
            txtConfirEmail.Location = new Point(291, 192);
            txtConfirEmail.Margin = new Padding(4, 5, 4, 5);
            txtConfirEmail.MaxLength = 100;
            txtConfirEmail.Name = "txtConfirEmail";
            txtConfirEmail.Size = new Size(237, 31);
            txtConfirEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 12;
            label2.Text = "Confirmar e-mail";
            // 
            // txtConfirSenha
            // 
            txtConfirSenha.Location = new Point(38, 266);
            txtConfirSenha.Margin = new Padding(4, 5, 4, 5);
            txtConfirSenha.MaxLength = 100;
            txtConfirSenha.Name = "txtConfirSenha";
            txtConfirSenha.Size = new Size(237, 31);
            txtConfirSenha.TabIndex = 5;
            txtConfirSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 236);
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
            btn_limpar.Location = new Point(75, 565);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(115, 40);
            btn_limpar.TabIndex = 15;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // MostrarUsuarios
            // 
            MostrarUsuarios.AllowUserToAddRows = false;
            MostrarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, SenhaH, ConfirmarEmail, ConfirmarSenha });
            MostrarUsuarios.Location = new Point(81, 323);
            MostrarUsuarios.Name = "MostrarUsuarios";
            MostrarUsuarios.RowHeadersVisible = false;
            MostrarUsuarios.RowHeadersWidth = 62;
            MostrarUsuarios.RowTemplate.Height = 33;
            MostrarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarUsuarios.Size = new Size(413, 236);
            MostrarUsuarios.TabIndex = 23;
            MostrarUsuarios.CellContentClick += MostrarUsuarios_CellContentClick;
            MostrarUsuarios.CellMouseDoubleClick += MostrarUsuarios_CellMouseDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "id_usuario";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 50;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.Width = 150;
            // 
            // SenhaH
            // 
            SenhaH.DataPropertyName = "SenhaHash";
            SenhaH.HeaderText = "SenhaH";
            SenhaH.MinimumWidth = 8;
            SenhaH.Name = "SenhaH";
            SenhaH.Visible = false;
            SenhaH.Width = 150;
            // 
            // ConfirmarEmail
            // 
            ConfirmarEmail.DataPropertyName = "ConfirmarEmail";
            ConfirmarEmail.HeaderText = "ConfirmarEmail";
            ConfirmarEmail.MinimumWidth = 8;
            ConfirmarEmail.Name = "ConfirmarEmail";
            ConfirmarEmail.Visible = false;
            ConfirmarEmail.Width = 150;
            // 
            // ConfirmarSenha
            // 
            ConfirmarSenha.DataPropertyName = "ConfirmarSenha";
            ConfirmarSenha.HeaderText = "ConfirmarSenha";
            ConfirmarSenha.MinimumWidth = 8;
            ConfirmarSenha.Name = "ConfirmarSenha";
            ConfirmarSenha.Visible = false;
            ConfirmarSenha.Width = 150;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.DarkGreen;
            btnDeletar.ForeColor = SystemColors.Control;
            btnDeletar.Location = new Point(197, 567);
            btnDeletar.Margin = new Padding(4, 5, 4, 5);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(115, 40);
            btnDeletar.TabIndex = 24;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(37, 96);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 25;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(292, 96);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 26;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(291, 162);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 27;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(38, 162);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 28;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(38, 236);
            label8.Name = "label8";
            label8.Size = new Size(20, 25);
            label8.TabIndex = 29;
            label8.Text = "*";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(373, 283);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 30;
            button1.Text = "Ver usuarios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TelaCadUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 749);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUserNome);
            Controls.Add(label4);
            Controls.Add(btnDeletar);
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
        private Button btnCancelarCadUser;
        private Button btnCadUserSucesso;
        private Panel panel2;
        private Label label1;
        private TextBox txtConfirEmail;
        private Label label2;
        private TextBox txtConfirSenha;
        private Label label3;
        private Button btn_limpar;
        private DataGridView MostrarUsuarios;
        private Button btnDeletar;
        private TextBox txtID;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn SenhaH;
        private DataGridViewTextBoxColumn ConfirmarEmail;
        private DataGridViewTextBoxColumn ConfirmarSenha;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}