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
            HeaderCadColab = new Panel();
            label1 = new Label();
            check_ativo = new CheckBox();
            btn_selectEquips = new Button();
            btnCancelarCad = new Button();
            FotterCadColab = new Panel();
            btn_Atualizar = new Button();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDesativar = new Button();
            btnRecarregar = new Button();
            MostrarColaboradores = new DataGridView();
            id_colaborador = new DataGridViewTextBoxColumn();
            NomeColab = new DataGridViewTextBoxColumn();
            NomeColaborador = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            EmailColaborador = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            TelefoneColaborador = new DataGridViewTextBoxColumn();
            AgendaColaborador = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            id_setor = new DataGridViewTextBoxColumn();
            SenhaHash = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            SenhaColaborador = new DataGridViewTextBoxColumn();
            SetorColaborador = new DataGridViewTextBoxColumn();
            MostrarColaboradoresDesativados = new DataGridView();
            ID_ColabDesativado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            btnAtivar = new Button();
            btnLimpar2 = new Button();
            btnPesquisar = new Button();
            btnEditarEquips = new Button();
            HeaderCadColab.SuspendLayout();
            FotterCadColab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarColaboradores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarColaboradoresDesativados).BeginInit();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(276, 56);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 99;
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(276, 95);
            Email.Name = "Email";
            Email.Size = new Size(41, 15);
            Email.TabIndex = 98;
            Email.Text = "E-mail";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(275, 134);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 97;
            Senha.Text = "Senha";
            // 
            // Agenda
            // 
            Agenda.AutoSize = true;
            Agenda.Location = new Point(202, 212);
            Agenda.Name = "Agenda";
            Agenda.Size = new Size(88, 15);
            Agenda.TabIndex = 94;
            Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(276, 173);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 96;
            Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            InputColabNome.Location = new Point(262, 74);
            InputColabNome.MaxLength = 30;
            InputColabNome.Name = "InputColabNome";
            InputColabNome.Size = new Size(254, 23);
            InputColabNome.TabIndex = 1;
            // 
            // inputColabAgenda
            // 
            inputColabAgenda.Location = new Point(208, 227);
            inputColabAgenda.MaxLength = 90;
            inputColabAgenda.Name = "inputColabAgenda";
            inputColabAgenda.Size = new Size(403, 23);
            inputColabAgenda.TabIndex = 7;
            // 
            // inputColabEmail
            // 
            inputColabEmail.Location = new Point(262, 113);
            inputColabEmail.MaxLength = 100;
            inputColabEmail.Name = "inputColabEmail";
            inputColabEmail.Size = new Size(254, 23);
            inputColabEmail.TabIndex = 2;
            // 
            // inputColabSenha
            // 
            inputColabSenha.Location = new Point(263, 152);
            inputColabSenha.MaxLength = 100;
            inputColabSenha.Name = "inputColabSenha";
            inputColabSenha.Size = new Size(254, 23);
            inputColabSenha.TabIndex = 3;
            inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            inputColabTel.Location = new Point(263, 190);
            inputColabTel.MaxLength = 11;
            inputColabTel.Name = "inputColabTel";
            inputColabTel.Size = new Size(129, 23);
            inputColabTel.TabIndex = 4;
            inputColabTel.TextChanged += inputColabTel_TextChanged;
            // 
            // Setor
            // 
            Setor.AutoSize = true;
            Setor.Location = new Point(411, 172);
            Setor.Name = "Setor";
            Setor.Size = new Size(34, 15);
            Setor.TabIndex = 95;
            Setor.Text = "Setor";
            // 
            // escolherSetor
            // 
            escolherSetor.FormattingEnabled = true;
            escolherSetor.Items.AddRange(new object[] { "Engenharia", "Criação", "Administração", "Marketing", "Ligação", "TI" });
            escolherSetor.Location = new Point(398, 190);
            escolherSetor.MaxDropDownItems = 5;
            escolherSetor.Name = "escolherSetor";
            escolherSetor.Size = new Size(116, 23);
            escolherSetor.TabIndex = 5;
            escolherSetor.SelectedIndexChanged += escolherSetor_SelectedIndexChanged;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(813, 50);
            HeaderCadColab.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(287, 13);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 91;
            label1.Text = "Tela de colaboradores";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(208, 257);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(54, 19);
            check_ativo.TabIndex = 6;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // btn_selectEquips
            // 
            btn_selectEquips.BackColor = Color.DarkGreen;
            btn_selectEquips.Dock = DockStyle.Right;
            btn_selectEquips.ForeColor = Color.White;
            btn_selectEquips.Location = new Point(653, 6);
            btn_selectEquips.Name = "btn_selectEquips";
            btn_selectEquips.Size = new Size(154, 44);
            btn_selectEquips.TabIndex = 7;
            btn_selectEquips.Text = "Selecionar equipamentos";
            btn_selectEquips.UseVisualStyleBackColor = false;
            btn_selectEquips.Click += btn_selectEquips_Click;
            // 
            // btnCancelarCad
            // 
            btnCancelarCad.BackColor = Color.DarkGreen;
            btnCancelarCad.Dock = DockStyle.Left;
            btnCancelarCad.ForeColor = SystemColors.Control;
            btnCancelarCad.Location = new Point(6, 6);
            btnCancelarCad.Name = "btnCancelarCad";
            btnCancelarCad.Size = new Size(150, 44);
            btnCancelarCad.TabIndex = 8;
            btnCancelarCad.Text = "Cancelar";
            btnCancelarCad.UseVisualStyleBackColor = false;
            btnCancelarCad.Click += btnCancelarCad_Click;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btn_Atualizar);
            FotterCadColab.Controls.Add(txtID);
            FotterCadColab.Controls.Add(btn_selectEquips);
            FotterCadColab.Controls.Add(btnCancelarCad);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 531);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(6, 6, 6, 6);
            FotterCadColab.Size = new Size(813, 56);
            FotterCadColab.TabIndex = 15;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.BackColor = Color.DarkGreen;
            btn_Atualizar.ForeColor = Color.White;
            btn_Atualizar.Location = new Point(332, 7);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(163, 44);
            btn_Atualizar.TabIndex = 25;
            btn_Atualizar.Text = "Atualizar info colaborador";
            btn_Atualizar.UseVisualStyleBackColor = false;
            btn_Atualizar.Click += btn_Atualizar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(161, 19);
            txtID.Margin = new Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(96, 23);
            txtID.TabIndex = 24;
            txtID.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(266, 56);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 17;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(266, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 18;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(401, 173);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 19;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(266, 134);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 20;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(265, 173);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 21;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(190, 209);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 22;
            label7.Text = "*";
            // 
            // btnDesativar
            // 
            btnDesativar.BackColor = Color.DarkGreen;
            btnDesativar.ForeColor = Color.White;
            btnDesativar.Location = new Point(4, 502);
            btnDesativar.Margin = new Padding(2, 2, 2, 2);
            btnDesativar.Name = "btnDesativar";
            btnDesativar.Size = new Size(141, 25);
            btnDesativar.TabIndex = 100;
            btnDesativar.Text = "Desativar colaborador";
            btnDesativar.UseVisualStyleBackColor = false;
            btnDesativar.Click += btnDesativar_Click;
            // 
            // btnRecarregar
            // 
            btnRecarregar.BackColor = Color.DarkGreen;
            btnRecarregar.ForeColor = Color.White;
            btnRecarregar.Location = new Point(148, 502);
            btnRecarregar.Margin = new Padding(2, 2, 2, 2);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(66, 25);
            btnRecarregar.TabIndex = 101;
            btnRecarregar.Text = "Limpar";
            btnRecarregar.UseVisualStyleBackColor = false;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // MostrarColaboradores
            // 
            MostrarColaboradores.AllowUserToAddRows = false;
            MostrarColaboradores.AllowUserToDeleteRows = false;
            MostrarColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarColaboradores.Columns.AddRange(new DataGridViewColumn[] { id_colaborador, NomeColab, NomeColaborador, dataGridViewTextBoxColumn1, EmailColaborador, dataGridViewTextBoxColumn2, TelefoneColaborador, AgendaColaborador, dataGridViewTextBoxColumn4, id_setor, SenhaHash, Ativo_inativo, SenhaColaborador, SetorColaborador });
            MostrarColaboradores.Location = new Point(4, 304);
            MostrarColaboradores.Margin = new Padding(2, 2, 2, 2);
            MostrarColaboradores.Name = "MostrarColaboradores";
            MostrarColaboradores.ReadOnly = true;
            MostrarColaboradores.RowHeadersWidth = 62;
            MostrarColaboradores.RowTemplate.Height = 33;
            MostrarColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarColaboradores.Size = new Size(384, 196);
            MostrarColaboradores.TabIndex = 102;
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
            NomeColab.DataPropertyName = "NomeColab";
            NomeColab.HeaderText = "Nome";
            NomeColab.MaxInputLength = 0;
            NomeColab.MinimumWidth = 8;
            NomeColab.Name = "NomeColab";
            NomeColab.ReadOnly = true;
            NomeColab.Visible = false;
            NomeColab.Width = 200;
            // 
            // NomeColaborador
            // 
            NomeColaborador.DataPropertyName = "NomeColaborador";
            NomeColaborador.HeaderText = "Nome";
            NomeColaborador.MinimumWidth = 8;
            NomeColaborador.Name = "NomeColaborador";
            NomeColaborador.ReadOnly = true;
            NomeColaborador.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            dataGridViewTextBoxColumn1.HeaderText = "E-mail";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // EmailColaborador
            // 
            EmailColaborador.DataPropertyName = "EmailColaborador";
            EmailColaborador.HeaderText = "E-mail";
            EmailColaborador.MinimumWidth = 8;
            EmailColaborador.Name = "EmailColaborador";
            EmailColaborador.ReadOnly = true;
            EmailColaborador.Width = 210;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Telefone";
            dataGridViewTextBoxColumn2.HeaderText = "Telefone";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Visible = false;
            dataGridViewTextBoxColumn2.Width = 150;
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
            // AgendaColaborador
            // 
            AgendaColaborador.DataPropertyName = "AgendaColaborador";
            AgendaColaborador.HeaderText = "Agenda";
            AgendaColaborador.MinimumWidth = 8;
            AgendaColaborador.Name = "AgendaColaborador";
            AgendaColaborador.ReadOnly = true;
            AgendaColaborador.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Nome_setor";
            dataGridViewTextBoxColumn4.HeaderText = "Setor";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 150;
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
            // SetorColaborador
            // 
            SetorColaborador.DataPropertyName = "SetorNome";
            SetorColaborador.HeaderText = "Setor";
            SetorColaborador.MinimumWidth = 8;
            SetorColaborador.Name = "SetorColaborador";
            SetorColaborador.ReadOnly = true;
            SetorColaborador.Width = 150;
            // 
            // MostrarColaboradoresDesativados
            // 
            MostrarColaboradoresDesativados.AllowUserToAddRows = false;
            MostrarColaboradoresDesativados.AllowUserToDeleteRows = false;
            MostrarColaboradoresDesativados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarColaboradoresDesativados.Columns.AddRange(new DataGridViewColumn[] { ID_ColabDesativado, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn15 });
            MostrarColaboradoresDesativados.Location = new Point(421, 304);
            MostrarColaboradoresDesativados.Margin = new Padding(2, 2, 2, 2);
            MostrarColaboradoresDesativados.Name = "MostrarColaboradoresDesativados";
            MostrarColaboradoresDesativados.ReadOnly = true;
            MostrarColaboradoresDesativados.RowHeadersWidth = 62;
            MostrarColaboradoresDesativados.RowTemplate.Height = 33;
            MostrarColaboradoresDesativados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarColaboradoresDesativados.Size = new Size(384, 196);
            MostrarColaboradoresDesativados.TabIndex = 103;
            MostrarColaboradoresDesativados.CellMouseDoubleClick += MostrarColaboradoresDesativados_CellMouseDoubleClick;
            // 
            // ID_ColabDesativado
            // 
            ID_ColabDesativado.DataPropertyName = "ID_colaborador";
            ID_ColabDesativado.HeaderText = "ID";
            ID_ColabDesativado.MaxInputLength = 0;
            ID_ColabDesativado.MinimumWidth = 8;
            ID_ColabDesativado.Name = "ID_ColabDesativado";
            ID_ColabDesativado.ReadOnly = true;
            ID_ColabDesativado.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn6.HeaderText = "Nome";
            dataGridViewTextBoxColumn6.MaxInputLength = 0;
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "NomeColaborador";
            dataGridViewTextBoxColumn7.HeaderText = "Nome";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            dataGridViewTextBoxColumn8.HeaderText = "E-mail";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Visible = false;
            dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "EmailColaborador";
            dataGridViewTextBoxColumn9.HeaderText = "E-mail";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 210;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Telefone";
            dataGridViewTextBoxColumn10.HeaderText = "Telefone";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "TelefoneColaborador";
            dataGridViewTextBoxColumn11.HeaderText = "Telefone";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "AgendaColaborador";
            dataGridViewTextBoxColumn12.HeaderText = "Agenda";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Nome_setor";
            dataGridViewTextBoxColumn13.HeaderText = "Setor";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Visible = false;
            dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "id_setor";
            dataGridViewTextBoxColumn14.HeaderText = "idSetor";
            dataGridViewTextBoxColumn14.MinimumWidth = 8;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "SenhaHash";
            dataGridViewTextBoxColumn16.HeaderText = "SenhaHash";
            dataGridViewTextBoxColumn16.MinimumWidth = 8;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.Visible = false;
            dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "Ativo_inativo";
            dataGridViewTextBoxColumn17.HeaderText = "Ativo_inativo";
            dataGridViewTextBoxColumn17.MinimumWidth = 8;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.Visible = false;
            dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "SenhaColaborador";
            dataGridViewTextBoxColumn18.HeaderText = "Senha";
            dataGridViewTextBoxColumn18.MinimumWidth = 8;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.Visible = false;
            dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "SetorNome";
            dataGridViewTextBoxColumn15.HeaderText = "Setor";
            dataGridViewTextBoxColumn15.MinimumWidth = 8;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGreen;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(113, 283);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 21);
            label8.TabIndex = 104;
            label8.Text = "Colaboradores ativos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGreen;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(508, 283);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(198, 21);
            label9.TabIndex = 105;
            label9.Text = "Colaboradores desativados";
            label9.Click += label9_Click;
            // 
            // btnAtivar
            // 
            btnAtivar.BackColor = Color.DarkGreen;
            btnAtivar.ForeColor = Color.White;
            btnAtivar.Location = new Point(421, 503);
            btnAtivar.Margin = new Padding(2, 2, 2, 2);
            btnAtivar.Name = "btnAtivar";
            btnAtivar.Size = new Size(141, 23);
            btnAtivar.TabIndex = 106;
            btnAtivar.Text = "Ativar colaborador";
            btnAtivar.UseVisualStyleBackColor = false;
            btnAtivar.Click += btnAtivar_Click;
            // 
            // btnLimpar2
            // 
            btnLimpar2.BackColor = Color.DarkGreen;
            btnLimpar2.ForeColor = Color.White;
            btnLimpar2.Location = new Point(566, 503);
            btnLimpar2.Margin = new Padding(2, 2, 2, 2);
            btnLimpar2.Name = "btnLimpar2";
            btnLimpar2.Size = new Size(66, 23);
            btnLimpar2.TabIndex = 107;
            btnLimpar2.Text = "Limpar";
            btnLimpar2.UseVisualStyleBackColor = false;
            btnLimpar2.Click += btnLimpar2_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(521, 70);
            btnPesquisar.Margin = new Padding(2, 2, 2, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(181, 25);
            btnPesquisar.TabIndex = 108;
            btnPesquisar.Text = "Pesquisar por nome ou e-mail";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnEditarEquips
            // 
            btnEditarEquips.BackColor = Color.DarkGreen;
            btnEditarEquips.ForeColor = Color.White;
            btnEditarEquips.Location = new Point(288, 252);
            btnEditarEquips.Margin = new Padding(2, 2, 2, 2);
            btnEditarEquips.Name = "btnEditarEquips";
            btnEditarEquips.Size = new Size(241, 25);
            btnEditarEquips.TabIndex = 109;
            btnEditarEquips.Text = "Editar equipamentos do colaborador";
            btnEditarEquips.UseVisualStyleBackColor = false;
            btnEditarEquips.Visible = false;
            btnEditarEquips.Click += btnEditarEquips_Click;
            // 
            // CadColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(813, 587);
            Controls.Add(btnEditarEquips);
            Controls.Add(btnPesquisar);
            Controls.Add(btnLimpar2);
            Controls.Add(btnAtivar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(MostrarColaboradoresDesativados);
            Controls.Add(MostrarColaboradores);
            Controls.Add(btnRecarregar);
            Controls.Add(btnDesativar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            FotterCadColab.ResumeLayout(false);
            FotterCadColab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarColaboradores).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarColaboradoresDesativados).EndInit();
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
        private Panel HeaderCadColab;
        private CheckBox check_ativo;
        private Label label1;
        private Button btn_selectEquips;
        private Button btnCancelarCad;
        private Panel FotterCadColab;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private Button btnDesativar;
        private Button btnRecarregar;
        private DataGridView MostrarColaboradores;
        private DataGridView MostrarColaboradoresDesativados;
        private Label label8;
        private Label label9;
        private Button btnAtivar;
        private Button btnLimpar2;
        private DataGridViewTextBoxColumn id_colaborador;
        private DataGridViewTextBoxColumn NomeColab;
        private DataGridViewTextBoxColumn NomeColaborador;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn EmailColaborador;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn TelefoneColaborador;
        private DataGridViewTextBoxColumn AgendaColaborador;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn id_setor;
        private DataGridViewTextBoxColumn SenhaHash;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridViewTextBoxColumn SenhaColaborador;
        private DataGridViewTextBoxColumn SetorColaborador;
        private DataGridViewTextBoxColumn ID_ColabDesativado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private Button btnPesquisar;
        private Button btnEditarEquips;
        private Button btn_Atualizar;
    }
}