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
            btnCancelarCadUser = new Button();
            btnCadUserSucesso = new Button();
            inputUserNome = new TextBox();
            inputUserEmail = new TextBox();
            inputUserSenha = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserNome
            // 
            txtUserNome.AutoSize = true;
            txtUserNome.Location = new Point(128, 67);
            txtUserNome.Name = "txtUserNome";
            txtUserNome.Size = new Size(40, 15);
            txtUserNome.TabIndex = 0;
            txtUserNome.Text = "Nome";
            // 
            // txtEmailUser
            // 
            txtEmailUser.AutoSize = true;
            txtEmailUser.Location = new Point(128, 111);
            txtEmailUser.Name = "txtEmailUser";
            txtEmailUser.Size = new Size(41, 15);
            txtEmailUser.TabIndex = 1;
            txtEmailUser.Text = "E-mail";
            // 
            // txtUserSenha
            // 
            txtUserSenha.AutoSize = true;
            txtUserSenha.Location = new Point(128, 155);
            txtUserSenha.Name = "txtUserSenha";
            txtUserSenha.Size = new Size(39, 15);
            txtUserSenha.TabIndex = 2;
            txtUserSenha.Text = "Senha";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelarCadUser);
            panel1.Controls.Add(btnCadUserSucesso);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 217);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(427, 50);
            panel1.TabIndex = 3;
            // 
            // btnCancelarCadUser
            // 
            btnCancelarCadUser.BackColor = Color.DarkGreen;
            btnCancelarCadUser.Dock = DockStyle.Left;
            btnCancelarCadUser.ForeColor = SystemColors.Control;
            btnCancelarCadUser.Location = new Point(6, 6);
            btnCancelarCadUser.Name = "btnCancelarCadUser";
            btnCancelarCadUser.Size = new Size(150, 38);
            btnCancelarCadUser.TabIndex = 1;
            btnCancelarCadUser.Text = "Cancelar";
            btnCancelarCadUser.UseVisualStyleBackColor = false;
            // 
            // btnCadUserSucesso
            // 
            btnCadUserSucesso.BackColor = Color.DarkGreen;
            btnCadUserSucesso.Dock = DockStyle.Right;
            btnCadUserSucesso.ForeColor = SystemColors.Control;
            btnCadUserSucesso.Location = new Point(271, 6);
            btnCadUserSucesso.Name = "btnCadUserSucesso";
            btnCadUserSucesso.Size = new Size(150, 38);
            btnCadUserSucesso.TabIndex = 0;
            btnCadUserSucesso.Text = "Cadastrar";
            btnCadUserSucesso.UseVisualStyleBackColor = false;
            btnCadUserSucesso.Click += btnCadUserSucesso_Click;
            // 
            // inputUserNome
            // 
            inputUserNome.Location = new Point(128, 85);
            inputUserNome.Name = "inputUserNome";
            inputUserNome.Size = new Size(167, 23);
            inputUserNome.TabIndex = 4;
            // 
            // inputUserEmail
            // 
            inputUserEmail.Location = new Point(128, 129);
            inputUserEmail.Name = "inputUserEmail";
            inputUserEmail.Size = new Size(167, 23);
            inputUserEmail.TabIndex = 5;
            // 
            // inputUserSenha
            // 
            inputUserSenha.Location = new Point(128, 173);
            inputUserSenha.MaxLength = 10;
            inputUserSenha.Name = "inputUserSenha";
            inputUserSenha.Size = new Size(167, 23);
            inputUserSenha.TabIndex = 6;
            inputUserSenha.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 50);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 11;
            label1.Text = "Cadastrar usuário";
            // 
            // TelaCadUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 267);
            Controls.Add(panel2);
            Controls.Add(inputUserSenha);
            Controls.Add(inputUserEmail);
            Controls.Add(inputUserNome);
            Controls.Add(panel1);
            Controls.Add(txtUserSenha);
            Controls.Add(txtEmailUser);
            Controls.Add(txtUserNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaCadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar usuario";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}