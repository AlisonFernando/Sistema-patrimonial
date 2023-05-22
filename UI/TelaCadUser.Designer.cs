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
            this.txtUserNome = new System.Windows.Forms.Label();
            this.txtEmailUser = new System.Windows.Forms.Label();
            this.txtUserSenha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarCadUser = new System.Windows.Forms.Button();
            this.btnCadUserSucesso = new System.Windows.Forms.Button();
            this.inputUserNome = new System.Windows.Forms.TextBox();
            this.inputUserEmail = new System.Windows.Forms.TextBox();
            this.inputUserSenha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserNome
            // 
            this.txtUserNome.AutoSize = true;
            this.txtUserNome.Location = new System.Drawing.Point(128, 67);
            this.txtUserNome.Name = "txtUserNome";
            this.txtUserNome.Size = new System.Drawing.Size(40, 15);
            this.txtUserNome.TabIndex = 0;
            this.txtUserNome.Text = "Nome";
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.AutoSize = true;
            this.txtEmailUser.Location = new System.Drawing.Point(128, 111);
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(41, 15);
            this.txtEmailUser.TabIndex = 1;
            this.txtEmailUser.Text = "E-mail";
            // 
            // txtUserSenha
            // 
            this.txtUserSenha.AutoSize = true;
            this.txtUserSenha.Location = new System.Drawing.Point(128, 155);
            this.txtUserSenha.Name = "txtUserSenha";
            this.txtUserSenha.Size = new System.Drawing.Size(39, 15);
            this.txtUserSenha.TabIndex = 2;
            this.txtUserSenha.Text = "Senha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelarCadUser);
            this.panel1.Controls.Add(this.btnCadUserSucesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(427, 50);
            this.panel1.TabIndex = 3;
            // 
            // btnCancelarCadUser
            // 
            this.btnCancelarCadUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCancelarCadUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelarCadUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarCadUser.Location = new System.Drawing.Point(6, 6);
            this.btnCancelarCadUser.Name = "btnCancelarCadUser";
            this.btnCancelarCadUser.Size = new System.Drawing.Size(150, 38);
            this.btnCancelarCadUser.TabIndex = 1;
            this.btnCancelarCadUser.Text = "Cancelar";
            this.btnCancelarCadUser.UseVisualStyleBackColor = false;
            // 
            // btnCadUserSucesso
            // 
            this.btnCadUserSucesso.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCadUserSucesso.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCadUserSucesso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadUserSucesso.Location = new System.Drawing.Point(271, 6);
            this.btnCadUserSucesso.Name = "btnCadUserSucesso";
            this.btnCadUserSucesso.Size = new System.Drawing.Size(150, 38);
            this.btnCadUserSucesso.TabIndex = 0;
            this.btnCadUserSucesso.Text = "Cadastrar";
            this.btnCadUserSucesso.UseVisualStyleBackColor = false;
            this.btnCadUserSucesso.Click += new System.EventHandler(this.btnCadUserSucesso_Click);
            // 
            // inputUserNome
            // 
            this.inputUserNome.Location = new System.Drawing.Point(128, 85);
            this.inputUserNome.Name = "inputUserNome";
            this.inputUserNome.Size = new System.Drawing.Size(167, 23);
            this.inputUserNome.TabIndex = 4;
            // 
            // inputUserEmail
            // 
            this.inputUserEmail.Location = new System.Drawing.Point(128, 129);
            this.inputUserEmail.Name = "inputUserEmail";
            this.inputUserEmail.Size = new System.Drawing.Size(167, 23);
            this.inputUserEmail.TabIndex = 5;
            // 
            // inputUserSenha
            // 
            this.inputUserSenha.Location = new System.Drawing.Point(128, 173);
            this.inputUserSenha.MaxLength = 10;
            this.inputUserSenha.Name = "inputUserSenha";
            this.inputUserSenha.Size = new System.Drawing.Size(167, 23);
            this.inputUserSenha.TabIndex = 6;
            this.inputUserSenha.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 50);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastrar usuário";
            // 
            // TelaCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inputUserSenha);
            this.Controls.Add(this.inputUserEmail);
            this.Controls.Add(this.inputUserNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserSenha);
            this.Controls.Add(this.txtEmailUser);
            this.Controls.Add(this.txtUserNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar usuario";
            this.Load += new System.EventHandler(this.TelaCadUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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