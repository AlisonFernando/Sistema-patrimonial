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
            txtConfirEmail = new TextBox();
            label2 = new Label();
            txtConfirSenha = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserNome
            // 
            txtUserNome.AutoSize = true;
            txtUserNome.Location = new Point(183, 112);
            txtUserNome.Margin = new Padding(4, 0, 4, 0);
            txtUserNome.Name = "txtUserNome";
            txtUserNome.Size = new Size(61, 25);
            txtUserNome.TabIndex = 0;
            txtUserNome.Text = "Nome";
            // 
            // txtEmailUser
            // 
            txtEmailUser.AutoSize = true;
            txtEmailUser.Location = new Point(183, 185);
            txtEmailUser.Margin = new Padding(4, 0, 4, 0);
            txtEmailUser.Name = "txtEmailUser";
            txtEmailUser.Size = new Size(61, 25);
            txtEmailUser.TabIndex = 1;
            txtEmailUser.Text = "E-mail";
            // 
            // txtUserSenha
            // 
            txtUserSenha.AutoSize = true;
            txtUserSenha.Location = new Point(183, 329);
            txtUserSenha.Margin = new Padding(4, 0, 4, 0);
            txtUserSenha.Name = "txtUserSenha";
            txtUserSenha.Size = new Size(60, 25);
            txtUserSenha.TabIndex = 2;
            txtUserSenha.Text = "Senha";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelarCadUser);
            panel1.Controls.Add(btnCadUserSucesso);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 506);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(610, 83);
            panel1.TabIndex = 3;
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
            btnCancelarCadUser.TabIndex = 1;
            btnCancelarCadUser.Text = "Cancelar";
            btnCancelarCadUser.UseVisualStyleBackColor = false;
            // 
            // btnCadUserSucesso
            // 
            btnCadUserSucesso.BackColor = Color.DarkGreen;
            btnCadUserSucesso.Dock = DockStyle.Right;
            btnCadUserSucesso.ForeColor = SystemColors.Control;
            btnCadUserSucesso.Location = new Point(387, 10);
            btnCadUserSucesso.Margin = new Padding(4, 5, 4, 5);
            btnCadUserSucesso.Name = "btnCadUserSucesso";
            btnCadUserSucesso.Size = new Size(214, 63);
            btnCadUserSucesso.TabIndex = 0;
            btnCadUserSucesso.Text = "Cadastrar";
            btnCadUserSucesso.UseVisualStyleBackColor = false;
            btnCadUserSucesso.Click += btnCadUserSucesso_Click;
            // 
            // inputUserNome
            // 
            inputUserNome.Location = new Point(183, 142);
            inputUserNome.Margin = new Padding(4, 5, 4, 5);
            inputUserNome.MaxLength = 100;
            inputUserNome.Name = "inputUserNome";
            inputUserNome.Size = new Size(237, 31);
            inputUserNome.TabIndex = 4;
            // 
            // inputUserEmail
            // 
            inputUserEmail.Location = new Point(183, 215);
            inputUserEmail.Margin = new Padding(4, 5, 4, 5);
            inputUserEmail.MaxLength = 100;
            inputUserEmail.Name = "inputUserEmail";
            inputUserEmail.Size = new Size(237, 31);
            inputUserEmail.TabIndex = 5;
            // 
            // inputUserSenha
            // 
            inputUserSenha.Location = new Point(183, 359);
            inputUserSenha.Margin = new Padding(4, 5, 4, 5);
            inputUserSenha.MaxLength = 100;
            inputUserSenha.Name = "inputUserSenha";
            inputUserSenha.Size = new Size(237, 31);
            inputUserSenha.TabIndex = 6;
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
            panel2.Size = new Size(610, 83);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(183, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 11;
            label1.Text = "Cadastrar usuário";
            // 
            // txtConfirEmail
            // 
            txtConfirEmail.Location = new Point(183, 284);
            txtConfirEmail.Margin = new Padding(4, 5, 4, 5);
            txtConfirEmail.MaxLength = 100;
            txtConfirEmail.Name = "txtConfirEmail";
            txtConfirEmail.Size = new Size(237, 31);
            txtConfirEmail.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 254);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 12;
            label2.Text = "Confirmar e-mail";
            // 
            // txtConfirSenha
            // 
            txtConfirSenha.Location = new Point(183, 433);
            txtConfirSenha.Margin = new Padding(4, 5, 4, 5);
            txtConfirSenha.MaxLength = 100;
            txtConfirSenha.Name = "txtConfirSenha";
            txtConfirSenha.Size = new Size(237, 31);
            txtConfirSenha.TabIndex = 14;
            txtConfirSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 403);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 13;
            label3.Text = "Confirmar senha";
            // 
            // TelaCadUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 589);
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
            Controls.Add(txtUserNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox txtConfirEmail;
        private Label label2;
        private TextBox txtConfirSenha;
        private Label label3;
    }
}