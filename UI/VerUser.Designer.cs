namespace UI
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
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            SenhaH = new DataGridViewTextBoxColumn();
            ConfirmarEmail = new DataGridViewTextBoxColumn();
            ConfirmarSenha = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarUsuarios).BeginInit();
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
            panel2.Size = new Size(1143, 83);
            panel2.TabIndex = 11;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            header.ForeColor = SystemColors.Control;
            header.Location = new Point(397, 20);
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
            MostrarUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, SenhaH, ConfirmarEmail, ConfirmarSenha });
            MostrarUsuarios.Location = new Point(272, 134);
            MostrarUsuarios.Name = "MostrarUsuarios";
            MostrarUsuarios.ReadOnly = true;
            MostrarUsuarios.RowHeadersWidth = 62;
            MostrarUsuarios.RowTemplate.Height = 33;
            MostrarUsuarios.Size = new Size(611, 309);
            MostrarUsuarios.TabIndex = 13;
            // 
            // ID
            // 
            ID.DataPropertyName = "id_usuario";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
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
            // VerUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label header;
        private DataGridView MostrarUsuarios;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn SenhaH;
        private DataGridViewTextBoxColumn ConfirmarEmail;
        private DataGridViewTextBoxColumn ConfirmarSenha;
    }
}