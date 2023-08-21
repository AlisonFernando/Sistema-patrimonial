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
            Nome = new Label();
            Email = new Label();
            Senha = new Label();
            Agenda = new Label();
            Telefone = new Label();
            InputColabNome = new TextBox();
            inputColabAgenda = new TextBox();
            inputColabEmail = new TextBox();
            inputColabSenha = new TextBox();
            inputColabTel = new TextBox();
            Setor = new Label();
            escolherSetor = new ComboBox();
            btnCadastrar = new Button();
            FotterCadColab = new Panel();
            btnCancelarCad = new Button();
            HeaderCadColab = new Panel();
            label1 = new Label();
            check_ativo = new CheckBox();
            escolherEquip = new ComboBox();
            label2 = new Label();
            dataGridViewEquipamentos = new DataGridView();
            checkedListBox1 = new CheckedListBox();
            Selecionar = new DataGridViewCheckBoxColumn();
            FotterCadColab.SuspendLayout();
            HeaderCadColab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).BeginInit();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(6, 75);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(6, 119);
            Email.Name = "Email";
            Email.Size = new Size(41, 15);
            Email.TabIndex = 1;
            Email.Text = "E-mail";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(137, 163);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 2;
            Senha.Text = "Senha";
            // 
            // Agenda
            // 
            Agenda.AutoSize = true;
            Agenda.Location = new Point(6, 207);
            Agenda.Name = "Agenda";
            Agenda.Size = new Size(88, 15);
            Agenda.TabIndex = 3;
            Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(266, 75);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 4;
            Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            InputColabNome.Location = new Point(6, 93);
            InputColabNome.MaxLength = 30;
            InputColabNome.Name = "InputColabNome";
            InputColabNome.Size = new Size(253, 23);
            InputColabNome.TabIndex = 1;
            // 
            // inputColabAgenda
            // 
            inputColabAgenda.Location = new Point(6, 225);
            inputColabAgenda.MaxLength = 90;
            inputColabAgenda.Name = "inputColabAgenda";
            inputColabAgenda.Size = new Size(403, 23);
            inputColabAgenda.TabIndex = 7;
            // 
            // inputColabEmail
            // 
            inputColabEmail.Location = new Point(6, 137);
            inputColabEmail.MaxLength = 40;
            inputColabEmail.Name = "inputColabEmail";
            inputColabEmail.Size = new Size(254, 23);
            inputColabEmail.TabIndex = 2;
            // 
            // inputColabSenha
            // 
            inputColabSenha.Location = new Point(137, 181);
            inputColabSenha.MaxLength = 10;
            inputColabSenha.Name = "inputColabSenha";
            inputColabSenha.Size = new Size(122, 23);
            inputColabSenha.TabIndex = 5;
            inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            inputColabTel.Location = new Point(266, 93);
            inputColabTel.MaxLength = 11;
            inputColabTel.Name = "inputColabTel";
            inputColabTel.Size = new Size(129, 23);
            inputColabTel.TabIndex = 4;
            // 
            // Setor
            // 
            Setor.AutoSize = true;
            Setor.Location = new Point(6, 163);
            Setor.Name = "Setor";
            Setor.Size = new Size(34, 15);
            Setor.TabIndex = 11;
            Setor.Text = "Setor";
            // 
            // escolherSetor
            // 
            escolherSetor.FormattingEnabled = true;
            escolherSetor.Items.AddRange(new object[] { "Engenharia", "Criação", "Administração", "Marketing", "Ligação", "TI" });
            escolherSetor.Location = new Point(6, 181);
            escolherSetor.Name = "escolherSetor";
            escolherSetor.Size = new Size(125, 23);
            escolherSetor.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Dock = DockStyle.Right;
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(275, 6);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 38);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btnCancelarCad);
            FotterCadColab.Controls.Add(btnCadastrar);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 628);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(6);
            FotterCadColab.Size = new Size(431, 50);
            FotterCadColab.TabIndex = 15;
            // 
            // btnCancelarCad
            // 
            btnCancelarCad.BackColor = Color.DarkGreen;
            btnCancelarCad.Dock = DockStyle.Left;
            btnCancelarCad.ForeColor = SystemColors.Control;
            btnCancelarCad.Location = new Point(6, 6);
            btnCancelarCad.Name = "btnCancelarCad";
            btnCancelarCad.Size = new Size(150, 38);
            btnCancelarCad.TabIndex = 15;
            btnCancelarCad.Text = "Cancelar";
            btnCancelarCad.UseVisualStyleBackColor = false;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(431, 50);
            HeaderCadColab.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(143, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Colaborador";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(266, 137);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(54, 19);
            check_ativo.TabIndex = 6;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // escolherEquip
            // 
            escolherEquip.FormattingEnabled = true;
            escolherEquip.Location = new Point(6, 269);
            escolherEquip.Name = "escolherEquip";
            escolherEquip.Size = new Size(403, 23);
            escolherEquip.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 251);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 18;
            label2.Text = "Equipamentos";
            // 
            // dataGridViewEquipamentos
            // 
            dataGridViewEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipamentos.Columns.AddRange(new DataGridViewColumn[] { Selecionar });
            dataGridViewEquipamentos.Location = new Point(6, 307);
            dataGridViewEquipamentos.Name = "dataGridViewEquipamentos";
            dataGridViewEquipamentos.RowTemplate.Height = 25;
            dataGridViewEquipamentos.Size = new Size(403, 269);
            dataGridViewEquipamentos.TabIndex = 21;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(6, 582);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(403, 40);
            checkedListBox1.TabIndex = 22;
            // 
            // Selecionar
            // 
            Selecionar.HeaderText = "Selecionar";
            Selecionar.Name = "Selecionar";
            // 
            // CadColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 678);
            Controls.Add(checkedListBox1);
            Controls.Add(dataGridViewEquipamentos);
            Controls.Add(label2);
            Controls.Add(escolherEquip);
            Controls.Add(check_ativo);
            Controls.Add(HeaderCadColab);
            Controls.Add(FotterCadColab);
            Controls.Add(escolherSetor);
            Controls.Add(Setor);
            Controls.Add(inputColabTel);
            Controls.Add(inputColabSenha);
            Controls.Add(inputColabEmail);
            Controls.Add(inputColabAgenda);
            Controls.Add(InputColabNome);
            Controls.Add(Telefone);
            Controls.Add(Agenda);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(Nome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Colaborador";
            Load += CadColaborador_Load;
            FotterCadColab.ResumeLayout(false);
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox escolherSetor;
        private Button btnCadastrar;
        private Panel FotterCadColab;
        private Button btnCancelarCad;
        private Panel HeaderCadColab;
        private CheckBox check_ativo;
        private Label label1;
        private ComboBox escolherEquip;
        private Label label2;
        private DataGridView dataGridViewEquipamentos;
        private DataGridViewCheckBoxColumn Selecionar;
        private CheckedListBox checkedListBox1;
    }
}