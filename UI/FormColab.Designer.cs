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
            this.input_name_colab = new System.Windows.Forms.TextBox();
            this.input_agenda_colab = new System.Windows.Forms.TextBox();
            this.input_email_colab = new System.Windows.Forms.TextBox();
            this.input_senha_colab = new System.Windows.Forms.TextBox();
            this.input_tel_colab = new System.Windows.Forms.TextBox();
            this.Setor = new System.Windows.Forms.Label();
            this.select_colab_setor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 28);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 88);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 15);
            this.Email.TabIndex = 1;
            this.Email.Text = "E-mail";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(286, 28);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(39, 15);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // Agenda
            // 
            this.Agenda.AutoSize = true;
            this.Agenda.Location = new System.Drawing.Point(12, 142);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(88, 15);
            this.Agenda.TabIndex = 3;
            this.Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(286, 88);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(51, 15);
            this.Telefone.TabIndex = 4;
            this.Telefone.Text = "Telefone";
            // 
            // input_name_colab
            // 
            this.input_name_colab.Location = new System.Drawing.Point(12, 46);
            this.input_name_colab.Name = "input_name_colab";
            this.input_name_colab.PlaceholderText = "Digite o nome do colaborador";
            this.input_name_colab.Size = new System.Drawing.Size(268, 23);
            this.input_name_colab.TabIndex = 6;
            // 
            // input_agenda_colab
            // 
            this.input_agenda_colab.Location = new System.Drawing.Point(12, 160);
            this.input_agenda_colab.Name = "input_agenda_colab";
            this.input_agenda_colab.PlaceholderText = "Agenda google do colaborador";
            this.input_agenda_colab.Size = new System.Drawing.Size(381, 23);
            this.input_agenda_colab.TabIndex = 7;
            // 
            // input_email_colab
            // 
            this.input_email_colab.Location = new System.Drawing.Point(12, 106);
            this.input_email_colab.Name = "input_email_colab";
            this.input_email_colab.PlaceholderText = "E-mail do colaborador";
            this.input_email_colab.Size = new System.Drawing.Size(268, 23);
            this.input_email_colab.TabIndex = 8;
            // 
            // input_senha_colab
            // 
            this.input_senha_colab.Location = new System.Drawing.Point(286, 46);
            this.input_senha_colab.MaxLength = 10;
            this.input_senha_colab.Name = "input_senha_colab";
            this.input_senha_colab.PlaceholderText = "Digite uma senha";
            this.input_senha_colab.Size = new System.Drawing.Size(129, 23);
            this.input_senha_colab.TabIndex = 9;
            this.input_senha_colab.UseSystemPasswordChar = true;
            // 
            // input_tel_colab
            // 
            this.input_tel_colab.Location = new System.Drawing.Point(286, 106);
            this.input_tel_colab.MaxLength = 11;
            this.input_tel_colab.Name = "input_tel_colab";
            this.input_tel_colab.PlaceholderText = "Telefone empresarial";
            this.input_tel_colab.Size = new System.Drawing.Size(129, 23);
            this.input_tel_colab.TabIndex = 10;
            // 
            // Setor
            // 
            this.Setor.AutoSize = true;
            this.Setor.Location = new System.Drawing.Point(12, 195);
            this.Setor.Name = "Setor";
            this.Setor.Size = new System.Drawing.Size(34, 15);
            this.Setor.TabIndex = 11;
            this.Setor.Text = "Setor";
            // 
            // select_colab_setor
            // 
            this.select_colab_setor.FormattingEnabled = true;
            this.select_colab_setor.Items.AddRange(new object[] {
            "Engenharia",
            "Criação",
            "Administração",
            "Marketing",
            "Ligação",
            "TI"});
            this.select_colab_setor.Location = new System.Drawing.Point(52, 192);
            this.select_colab_setor.Name = "select_colab_setor";
            this.select_colab_setor.Size = new System.Drawing.Size(125, 23);
            this.select_colab_setor.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(480, 163);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Location = new System.Drawing.Point(53, 406);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 33);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo registro";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(147, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 33);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(241, 406);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 33);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Location = new System.Drawing.Point(335, 406);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 33);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Limpar campos";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // CadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 451);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.select_colab_setor);
            this.Controls.Add(this.Setor);
            this.Controls.Add(this.input_tel_colab);
            this.Controls.Add(this.input_senha_colab);
            this.Controls.Add(this.input_email_colab);
            this.Controls.Add(this.input_agenda_colab);
            this.Controls.Add(this.input_name_colab);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Colaborador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nome;
        private Label Email;
        private Label Senha;
        private Label Agenda;
        private Label Telefone;
        private TextBox input_name_colab;
        private TextBox input_agenda_colab;
        private TextBox input_email_colab;
        private TextBox input_senha_colab;
        private TextBox input_tel_colab;
        private Label Setor;
        private ComboBox select_colab_setor;
        private DataGridView dataGridView1;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}