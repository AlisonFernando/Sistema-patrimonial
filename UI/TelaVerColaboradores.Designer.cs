namespace UI
{
    partial class TelaVerColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVerColaboradores));
            HeaderCadColab = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnVoltar = new Button();
            btnVerColabs = new Button();
            txtID = new TextBox();
            btnLimpar = new Button();
            btnPesquisar = new Button();
            txtNomePesquisar = new TextBox();
            MostrarColaboradores = new DataGridView();
            id_colaborador = new DataGridViewTextBoxColumn();
            NomeColab = new DataGridViewTextBoxColumn();
            NomeColaborador = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            EmailColaborador = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            TelefoneColaborador = new DataGridViewTextBoxColumn();
            Agenda = new DataGridViewTextBoxColumn();
            Setor = new DataGridViewTextBoxColumn();
            id_setor = new DataGridViewTextBoxColumn();
            SetorColaborador = new DataGridViewTextBoxColumn();
            SenhaHash = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            SenhaColaborador = new DataGridViewTextBoxColumn();
            HeaderCadColab.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarColaboradores).BeginInit();
            SuspendLayout();
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Margin = new Padding(4, 5, 4, 5);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(1104, 83);
            HeaderCadColab.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(378, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 41);
            label1.TabIndex = 0;
            label1.Text = "Visualizar Colaboradores";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnVerColabs);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 550);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(1104, 83);
            panel1.TabIndex = 29;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Dock = DockStyle.Left;
            btnVoltar.ForeColor = SystemColors.Control;
            btnVoltar.Location = new Point(9, 10);
            btnVoltar.Margin = new Padding(4, 5, 4, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(199, 63);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnVerColabs
            // 
            btnVerColabs.BackColor = Color.DarkGreen;
            btnVerColabs.Cursor = Cursors.Hand;
            btnVerColabs.Dock = DockStyle.Right;
            btnVerColabs.ForeColor = SystemColors.Control;
            btnVerColabs.Location = new Point(846, 10);
            btnVerColabs.Margin = new Padding(4, 5, 4, 5);
            btnVerColabs.Name = "btnVerColabs";
            btnVerColabs.Padding = new Padding(6);
            btnVerColabs.Size = new Size(249, 63);
            btnVerColabs.TabIndex = 7;
            btnVerColabs.Text = "Cadastrar colaborador";
            btnVerColabs.UseVisualStyleBackColor = false;
            btnVerColabs.Click += btnVerColabs_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(238, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 23;
            txtID.Visible = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(145, 489);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(117, 38);
            btnLimpar.TabIndex = 35;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(421, 106);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(187, 48);
            btnPesquisar.TabIndex = 34;
            btnPesquisar.Text = "Pesquisar por nome";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtNomePesquisar
            // 
            txtNomePesquisar.Location = new Point(145, 115);
            txtNomePesquisar.MaxLength = 100;
            txtNomePesquisar.Name = "txtNomePesquisar";
            txtNomePesquisar.Size = new Size(270, 31);
            txtNomePesquisar.TabIndex = 33;
            // 
            // MostrarColaboradores
            // 
            MostrarColaboradores.AllowUserToAddRows = false;
            MostrarColaboradores.AllowUserToDeleteRows = false;
            MostrarColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarColaboradores.Columns.AddRange(new DataGridViewColumn[] { id_colaborador, NomeColab, NomeColaborador, Email, EmailColaborador, Telefone, TelefoneColaborador, Agenda, Setor, id_setor, SetorColaborador, SenhaHash, Ativo_inativo, SenhaColaborador });
            MostrarColaboradores.Location = new Point(145, 157);
            MostrarColaboradores.Name = "MostrarColaboradores";
            MostrarColaboradores.ReadOnly = true;
            MostrarColaboradores.RowHeadersWidth = 62;
            MostrarColaboradores.RowTemplate.Height = 33;
            MostrarColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarColaboradores.Size = new Size(815, 326);
            MostrarColaboradores.TabIndex = 32;
            MostrarColaboradores.CellMouseDoubleClick += MostrarColaboradores_CellMouseDoubleClick;
            // 
            // id_colaborador
            // 
            id_colaborador.DataPropertyName = "ID_colaborador";
            id_colaborador.HeaderText = "ID";
            id_colaborador.MaxInputLength = 0;
            id_colaborador.MinimumWidth = 8;
            id_colaborador.Name = "id_colaborador";
            id_colaborador.ReadOnly = true;
            id_colaborador.Width = 50;
            // 
            // NomeColab
            // 
            NomeColab.DataPropertyName = "Nome";
            NomeColab.HeaderText = "Nome";
            NomeColab.MaxInputLength = 0;
            NomeColab.MinimumWidth = 8;
            NomeColab.Name = "NomeColab";
            NomeColab.ReadOnly = true;
            NomeColab.Visible = false;
            NomeColab.Width = 150;
            // 
            // NomeColaborador
            // 
            NomeColaborador.DataPropertyName = "NomeColaborador";
            NomeColaborador.HeaderText = "Nome";
            NomeColaborador.MinimumWidth = 8;
            NomeColaborador.Name = "NomeColaborador";
            NomeColaborador.ReadOnly = true;
            NomeColaborador.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-mail";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Visible = false;
            Email.Width = 190;
            // 
            // EmailColaborador
            // 
            EmailColaborador.DataPropertyName = "EmailColaborador";
            EmailColaborador.HeaderText = "Email";
            EmailColaborador.MinimumWidth = 8;
            EmailColaborador.Name = "EmailColaborador";
            EmailColaborador.ReadOnly = true;
            EmailColaborador.Width = 150;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 8;
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Visible = false;
            Telefone.Width = 150;
            // 
            // TelefoneColaborador
            // 
            TelefoneColaborador.DataPropertyName = "TelefoneColaborador";
            TelefoneColaborador.HeaderText = "Telefone";
            TelefoneColaborador.MinimumWidth = 8;
            TelefoneColaborador.Name = "TelefoneColaborador";
            TelefoneColaborador.ReadOnly = true;
            TelefoneColaborador.Width = 150;
            // 
            // Agenda
            // 
            Agenda.DataPropertyName = "AgendaColaborador";
            Agenda.HeaderText = "Agenda";
            Agenda.MinimumWidth = 8;
            Agenda.Name = "Agenda";
            Agenda.ReadOnly = true;
            Agenda.Width = 150;
            // 
            // Setor
            // 
            Setor.DataPropertyName = "Nome_setor";
            Setor.HeaderText = "Setor";
            Setor.MinimumWidth = 8;
            Setor.Name = "Setor";
            Setor.ReadOnly = true;
            Setor.Visible = false;
            Setor.Width = 150;
            // 
            // id_setor
            // 
            id_setor.DataPropertyName = "id_setor";
            id_setor.HeaderText = "idSetor";
            id_setor.MinimumWidth = 8;
            id_setor.Name = "id_setor";
            id_setor.ReadOnly = true;
            id_setor.Visible = false;
            id_setor.Width = 150;
            // 
            // SetorColaborador
            // 
            SetorColaborador.DataPropertyName = "SetorNome";
            SetorColaborador.HeaderText = "Setor";
            SetorColaborador.MinimumWidth = 8;
            SetorColaborador.Name = "SetorColaborador";
            SetorColaborador.ReadOnly = true;
            SetorColaborador.Width = 150;
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
            // Ativo_inativo
            // 
            Ativo_inativo.DataPropertyName = "Ativo_inativo";
            Ativo_inativo.HeaderText = "Ativo_inativo";
            Ativo_inativo.MinimumWidth = 8;
            Ativo_inativo.Name = "Ativo_inativo";
            Ativo_inativo.ReadOnly = true;
            Ativo_inativo.Visible = false;
            Ativo_inativo.Width = 150;
            // 
            // SenhaColaborador
            // 
            SenhaColaborador.DataPropertyName = "SenhaColaborador";
            SenhaColaborador.HeaderText = "Senha";
            SenhaColaborador.MinimumWidth = 8;
            SenhaColaborador.Name = "SenhaColaborador";
            SenhaColaborador.ReadOnly = true;
            SenhaColaborador.Visible = false;
            SenhaColaborador.Width = 150;
            // 
            // TelaVerColaboradores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 633);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtNomePesquisar);
            Controls.Add(MostrarColaboradores);
            Controls.Add(HeaderCadColab);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaVerColaboradores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Colaboradores";
            Load += TelaVerColaboradores_Load;
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarColaboradores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel HeaderCadColab;
        private Label label1;
        private Panel panel1;
        private Button btnVoltar;
        private Button btnVerColabs;
        private TextBox txtID;
        private Button btnLimpar;
        private Button btnPesquisar;
        private TextBox txtNomePesquisar;
        private DataGridView MostrarColaboradores;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NomeColab;
        private DataGridViewTextBoxColumn NomeColaborador;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn EmailColaborador;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn TelefoneColaborador;
        private DataGridViewTextBoxColumn Agenda;
        private DataGridViewTextBoxColumn Setor;
        private DataGridViewTextBoxColumn id_setor;
        private DataGridViewTextBoxColumn SetorColaborador;
        private DataGridViewTextBoxColumn SenhaHash;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridViewTextBoxColumn SenhaColaborador;
        private DataGridViewTextBoxColumn id_colaborador;
    }
}