namespace UI
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
            this.Nome = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.Agenda = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.InputColabNome = new System.Windows.Forms.TextBox();
            this.inputColabAgenda = new System.Windows.Forms.TextBox();
            this.inputColabEmail = new System.Windows.Forms.TextBox();
            this.inputColabSenha = new System.Windows.Forms.TextBox();
            this.inputColabTel = new System.Windows.Forms.TextBox();
            this.Setor = new System.Windows.Forms.Label();
            this.selectSetorColab = new System.Windows.Forms.ComboBox();
            this.btnCadColab = new System.Windows.Forms.Button();
            this.FotterCadColab = new System.Windows.Forms.Panel();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.HeaderCadColab = new System.Windows.Forms.Panel();
            this.inputCodColab = new System.Windows.Forms.TextBox();
            this.codigoColab = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Email2 = new System.Windows.Forms.Label();
            this.FotterCadColab.SuspendLayout();
            this.HeaderCadColab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(6, 75);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 119);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 15);
            this.Email.TabIndex = 1;
            this.Email.Text = "E-mail";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(280, 119);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(39, 15);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // Agenda
            // 
            this.Agenda.AutoSize = true;
            this.Agenda.Location = new System.Drawing.Point(6, 251);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(88, 15);
            this.Agenda.TabIndex = 3;
            this.Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(280, 75);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(51, 15);
            this.Telefone.TabIndex = 4;
            this.Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            this.InputColabNome.Location = new System.Drawing.Point(6, 93);
            this.InputColabNome.Name = "InputColabNome";
            this.InputColabNome.Size = new System.Drawing.Size(253, 23);
            this.InputColabNome.TabIndex = 6;
            // 
            // inputColabAgenda
            // 
            this.inputColabAgenda.Location = new System.Drawing.Point(6, 269);
            this.inputColabAgenda.Name = "inputColabAgenda";
            this.inputColabAgenda.Size = new System.Drawing.Size(403, 23);
            this.inputColabAgenda.TabIndex = 7;
            // 
            // inputColabEmail
            // 
            this.inputColabEmail.Location = new System.Drawing.Point(6, 137);
            this.inputColabEmail.Name = "inputColabEmail";
            this.inputColabEmail.Size = new System.Drawing.Size(254, 23);
            this.inputColabEmail.TabIndex = 8;
            // 
            // inputColabSenha
            // 
            this.inputColabSenha.Location = new System.Drawing.Point(280, 137);
            this.inputColabSenha.MaxLength = 10;
            this.inputColabSenha.Name = "inputColabSenha";
            this.inputColabSenha.Size = new System.Drawing.Size(129, 23);
            this.inputColabSenha.TabIndex = 9;
            this.inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            this.inputColabTel.Location = new System.Drawing.Point(280, 93);
            this.inputColabTel.MaxLength = 11;
            this.inputColabTel.Name = "inputColabTel";
            this.inputColabTel.Size = new System.Drawing.Size(129, 23);
            this.inputColabTel.TabIndex = 10;
            // 
            // Setor
            // 
            this.Setor.AutoSize = true;
            this.Setor.Location = new System.Drawing.Point(6, 207);
            this.Setor.Name = "Setor";
            this.Setor.Size = new System.Drawing.Size(34, 15);
            this.Setor.TabIndex = 11;
            this.Setor.Text = "Setor";
            // 
            // selectSetorColab
            // 
            this.selectSetorColab.FormattingEnabled = true;
            this.selectSetorColab.Items.AddRange(new object[] {
            "Engenharia",
            "Criação",
            "Administração",
            "Marketing",
            "Ligação",
            "TI"});
            this.selectSetorColab.Location = new System.Drawing.Point(6, 225);
            this.selectSetorColab.Name = "selectSetorColab";
            this.selectSetorColab.Size = new System.Drawing.Size(125, 23);
            this.selectSetorColab.TabIndex = 13;
            // 
            // btnCadColab
            // 
            this.btnCadColab.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCadColab.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCadColab.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadColab.Location = new System.Drawing.Point(271, 6);
            this.btnCadColab.Name = "btnCadColab";
            this.btnCadColab.Size = new System.Drawing.Size(150, 38);
            this.btnCadColab.TabIndex = 14;
            this.btnCadColab.Text = "Cadastrar";
            this.btnCadColab.UseVisualStyleBackColor = false;
            // 
            // FotterCadColab
            // 
            this.FotterCadColab.Controls.Add(this.btnCancelarCad);
            this.FotterCadColab.Controls.Add(this.btnCadColab);
            this.FotterCadColab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FotterCadColab.Location = new System.Drawing.Point(0, 312);
            this.FotterCadColab.Name = "FotterCadColab";
            this.FotterCadColab.Padding = new System.Windows.Forms.Padding(6);
            this.FotterCadColab.Size = new System.Drawing.Size(427, 50);
            this.FotterCadColab.TabIndex = 15;
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCancelarCad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelarCad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelarCad.Location = new System.Drawing.Point(6, 6);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(150, 38);
            this.btnCancelarCad.TabIndex = 15;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = false;
            // 
            // HeaderCadColab
            // 
            this.HeaderCadColab.BackColor = System.Drawing.Color.DarkGreen;
            this.HeaderCadColab.Controls.Add(this.inputCodColab);
            this.HeaderCadColab.Controls.Add(this.codigoColab);
            this.HeaderCadColab.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderCadColab.Location = new System.Drawing.Point(0, 0);
            this.HeaderCadColab.Name = "HeaderCadColab";
            this.HeaderCadColab.Size = new System.Drawing.Size(427, 50);
            this.HeaderCadColab.TabIndex = 16;
            // 
            // inputCodColab
            // 
            this.inputCodColab.Location = new System.Drawing.Point(56, 17);
            this.inputCodColab.Name = "inputCodColab";
            this.inputCodColab.Size = new System.Drawing.Size(100, 23);
            this.inputCodColab.TabIndex = 9;
            this.inputCodColab.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codigoColab
            // 
            this.codigoColab.AutoSize = true;
            this.codigoColab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoColab.ForeColor = System.Drawing.SystemColors.Control;
            this.codigoColab.Location = new System.Drawing.Point(12, 20);
            this.codigoColab.Name = "codigoColab";
            this.codigoColab.Size = new System.Drawing.Size(45, 15);
            this.codigoColab.TabIndex = 1;
            this.codigoColab.Text = "Código";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 23);
            this.textBox2.TabIndex = 18;
            // 
            // Email2
            // 
            this.Email2.AutoSize = true;
            this.Email2.Location = new System.Drawing.Point(6, 163);
            this.Email2.Name = "Email2";
            this.Email2.Size = new System.Drawing.Size(101, 15);
            this.Email2.TabIndex = 17;
            this.Email2.Text = "E-mail 2*opcional";
            // 
            // CadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 362);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Email2);
            this.Controls.Add(this.HeaderCadColab);
            this.Controls.Add(this.FotterCadColab);
            this.Controls.Add(this.selectSetorColab);
            this.Controls.Add(this.Setor);
            this.Controls.Add(this.inputColabTel);
            this.Controls.Add(this.inputColabSenha);
            this.Controls.Add(this.inputColabEmail);
            this.Controls.Add(this.inputColabAgenda);
            this.Controls.Add(this.InputColabNome);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Colaborador";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FotterCadColab.ResumeLayout(false);
            this.HeaderCadColab.ResumeLayout(false);
            this.HeaderCadColab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox selectSetorColab;
        private Button btnCadColab;
        private Panel FotterCadColab;
        private Button btnCancelarCad;
        private Panel HeaderCadColab;
        private TextBox inputCodColab;
        private Label codigoColab;
        private TextBox textBox2;
        private Label Email2;
    }
}