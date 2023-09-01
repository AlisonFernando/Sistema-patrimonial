namespace UI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            input_email = new TextBox();
            label_email = new Label();
            input_senha = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            btnEsqueciSenha = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(203, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // input_email
            // 
            input_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            input_email.Location = new Point(109, 162);
            input_email.Margin = new Padding(4, 5, 4, 5);
            input_email.MaxLength = 100;
            input_email.Name = "input_email";
            input_email.Size = new Size(280, 31);
            input_email.TabIndex = 4;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_email.Location = new Point(109, 132);
            label_email.Margin = new Padding(4, 0, 4, 0);
            label_email.Name = "label_email";
            label_email.Size = new Size(64, 25);
            label_email.TabIndex = 3;
            label_email.Text = "E-mail";
            // 
            // input_senha
            // 
            input_senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            input_senha.Location = new Point(109, 235);
            input_senha.Margin = new Padding(4, 5, 4, 5);
            input_senha.MaxLength = 100;
            input_senha.Name = "input_senha";
            input_senha.Size = new Size(280, 31);
            input_senha.TabIndex = 6;
            input_senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(111, 205);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_login.BackColor = Color.DarkGreen;
            btn_login.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(106, 283);
            btn_login.Margin = new Padding(4, 5, 4, 5);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(284, 68);
            btn_login.TabIndex = 7;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.Enter += btn_login_Click;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEsqueciSenha.BackColor = Color.DarkGreen;
            btnEsqueciSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEsqueciSenha.ForeColor = SystemColors.ButtonHighlight;
            btnEsqueciSenha.Location = new Point(105, 376);
            btnEsqueciSenha.Margin = new Padding(4, 5, 4, 5);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(284, 68);
            btnEsqueciSenha.TabIndex = 9;
            btnEsqueciSenha.Text = "Esqueci meus dados";
            btnEsqueciSenha.UseVisualStyleBackColor = false;
            btnEsqueciSenha.Click += btnEsqueciSenha_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 83);
            panel1.TabIndex = 10;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 487);
            Controls.Add(panel1);
            Controls.Add(btnEsqueciSenha);
            Controls.Add(btn_login);
            Controls.Add(input_senha);
            Controls.Add(label2);
            Controls.Add(input_email);
            Controls.Add(label_email);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Enter += btn_login_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_email;
        private Label label_email;
        private TextBox input_senha;
        private Label label2;
        public Button btn_login;
        public Button btnEsqueciSenha;
        private Panel panel1;
    }
}