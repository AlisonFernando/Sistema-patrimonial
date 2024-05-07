namespace UI
{
    partial class CadEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEquipamento));
            NomeEquip = new Label();
            MarcaEquip = new Label();
            DescricaoEquip = new Label();
            PrecoEquip = new Label();
            EtiquetaEquip = new Label();
            inputEquipNome = new TextBox();
            inputDesEquip = new TextBox();
            inputEtiquetaEquip = new TextBox();
            inputPrecoEquip = new TextBox();
            btn_cancelar = new Button();
            btn_cadastrar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            escolherMarca = new ComboBox();
            label1 = new Label();
            check_ativo = new CheckBox();
            btn_Limpar = new Button();
            txtID = new TextBox();
            btn_Desativar = new Button();
            MostrarEquipamentosAtivos = new DataGridView();
            ID_equipamento = new DataGridViewTextBoxColumn();
            ValorNumerico = new DataGridViewTextBoxColumn();
            Nome_equipamento = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            id_status = new DataGridViewTextBoxColumn();
            Etiqueta = new DataGridViewTextBoxColumn();
            colabID = new DataGridViewTextBoxColumn();
            marca_id = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnVisualizar = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MostrarEquipamentosDesativados = new DataGridView();
            ID_equipamentoDesativado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            btnAtivar = new Button();
            button2 = new Button();
            btnPesquisarAtivo = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentosAtivos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentosDesativados).BeginInit();
            SuspendLayout();
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(680, 108);
            NomeEquip.Margin = new Padding(4, 0, 4, 0);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(199, 25);
            NomeEquip.TabIndex = 0;
            NomeEquip.Text = "Nome do Equipamento";
            // 
            // MarcaEquip
            // 
            MarcaEquip.AutoSize = true;
            MarcaEquip.Location = new Point(680, 318);
            MarcaEquip.Margin = new Padding(4, 0, 4, 0);
            MarcaEquip.Name = "MarcaEquip";
            MarcaEquip.Size = new Size(60, 25);
            MarcaEquip.TabIndex = 1;
            MarcaEquip.Text = "Marca";
            // 
            // DescricaoEquip
            // 
            DescricaoEquip.AutoSize = true;
            DescricaoEquip.Location = new Point(680, 173);
            DescricaoEquip.Margin = new Padding(4, 0, 4, 0);
            DescricaoEquip.Name = "DescricaoEquip";
            DescricaoEquip.Size = new Size(88, 25);
            DescricaoEquip.TabIndex = 2;
            DescricaoEquip.Text = "Descrição";
            // 
            // PrecoEquip
            // 
            PrecoEquip.AutoSize = true;
            PrecoEquip.Location = new Point(901, 320);
            PrecoEquip.Margin = new Padding(4, 0, 4, 0);
            PrecoEquip.Name = "PrecoEquip";
            PrecoEquip.Size = new Size(56, 25);
            PrecoEquip.TabIndex = 3;
            PrecoEquip.Text = "Preço";
            // 
            // EtiquetaEquip
            // 
            EtiquetaEquip.AutoSize = true;
            EtiquetaEquip.Location = new Point(680, 248);
            EtiquetaEquip.Margin = new Padding(4, 0, 4, 0);
            EtiquetaEquip.Name = "EtiquetaEquip";
            EtiquetaEquip.Size = new Size(76, 25);
            EtiquetaEquip.TabIndex = 4;
            EtiquetaEquip.Text = "Etiqueta";
            // 
            // inputEquipNome
            // 
            inputEquipNome.Location = new Point(659, 138);
            inputEquipNome.Margin = new Padding(4, 5, 4, 5);
            inputEquipNome.MaxLength = 100;
            inputEquipNome.Name = "inputEquipNome";
            inputEquipNome.Size = new Size(387, 31);
            inputEquipNome.TabIndex = 1;
            // 
            // inputDesEquip
            // 
            inputDesEquip.Location = new Point(659, 203);
            inputDesEquip.Margin = new Padding(4, 5, 4, 5);
            inputDesEquip.MaxLength = 100;
            inputDesEquip.Name = "inputDesEquip";
            inputDesEquip.Size = new Size(387, 31);
            inputDesEquip.TabIndex = 2;
            // 
            // inputEtiquetaEquip
            // 
            inputEtiquetaEquip.Enabled = false;
            inputEtiquetaEquip.Location = new Point(659, 275);
            inputEtiquetaEquip.Margin = new Padding(4, 5, 4, 5);
            inputEtiquetaEquip.MaxLength = 10;
            inputEtiquetaEquip.Name = "inputEtiquetaEquip";
            inputEtiquetaEquip.Size = new Size(387, 31);
            inputEtiquetaEquip.TabIndex = 3;
            // 
            // inputPrecoEquip
            // 
            inputPrecoEquip.Location = new Point(881, 350);
            inputPrecoEquip.Margin = new Padding(4, 5, 4, 5);
            inputPrecoEquip.MaxLength = 10;
            inputPrecoEquip.Name = "inputPrecoEquip";
            inputPrecoEquip.Size = new Size(164, 31);
            inputPrecoEquip.TabIndex = 5;
            inputPrecoEquip.KeyPress += inputPrecoEquip_KeyPress;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.DarkGreen;
            btn_cancelar.Dock = DockStyle.Left;
            btn_cancelar.ForeColor = SystemColors.Control;
            btn_cancelar.Location = new Point(9, 10);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(199, 63);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.DarkGreen;
            btn_cadastrar.Cursor = Cursors.Hand;
            btn_cadastrar.Dock = DockStyle.Right;
            btn_cadastrar.ForeColor = SystemColors.Control;
            btn_cadastrar.Location = new Point(1487, 10);
            btn_cadastrar.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Padding = new Padding(6, 7, 6, 7);
            btn_cadastrar.Size = new Size(207, 63);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Aplicar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(1703, 83);
            panel2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(680, 20);
            label2.Name = "label2";
            label2.Size = new Size(362, 41);
            label2.TabIndex = 0;
            label2.Text = "Cadastrar equipamentos";
            // 
            // escolherMarca
            // 
            escolherMarca.FormattingEnabled = true;
            escolherMarca.Location = new Point(659, 348);
            escolherMarca.Margin = new Padding(4, 5, 4, 5);
            escolherMarca.Name = "escolherMarca";
            escolherMarca.Size = new Size(164, 33);
            escolherMarca.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 387);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 20;
            label1.Text = "Ativo/Inativo";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(659, 427);
            check_ativo.Margin = new Padding(4, 5, 4, 5);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(80, 29);
            check_ativo.TabIndex = 6;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.DarkGreen;
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(54, 853);
            btn_Limpar.Margin = new Padding(4, 5, 4, 5);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(214, 63);
            btn_Limpar.TabIndex = 22;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(239, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 23;
            txtID.Visible = false;
            // 
            // btn_Desativar
            // 
            btn_Desativar.BackColor = Color.DarkGreen;
            btn_Desativar.ForeColor = Color.White;
            btn_Desativar.Location = new Point(274, 853);
            btn_Desativar.Name = "btn_Desativar";
            btn_Desativar.Size = new Size(214, 63);
            btn_Desativar.TabIndex = 24;
            btn_Desativar.Text = "Desativar equipamento";
            btn_Desativar.UseVisualStyleBackColor = false;
            btn_Desativar.Click += btn_Desativar_Click;
            // 
            // MostrarEquipamentosAtivos
            // 
            MostrarEquipamentosAtivos.AllowUserToAddRows = false;
            MostrarEquipamentosAtivos.AllowUserToDeleteRows = false;
            MostrarEquipamentosAtivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipamentosAtivos.Columns.AddRange(new DataGridViewColumn[] { ID_equipamento, ValorNumerico, Nome_equipamento, Ativo, value, description, id_status, Etiqueta, colabID, marca_id });
            MostrarEquipamentosAtivos.Location = new Point(54, 567);
            MostrarEquipamentosAtivos.Name = "MostrarEquipamentosAtivos";
            MostrarEquipamentosAtivos.ReadOnly = true;
            MostrarEquipamentosAtivos.RowHeadersWidth = 62;
            MostrarEquipamentosAtivos.RowTemplate.Height = 33;
            MostrarEquipamentosAtivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipamentosAtivos.Size = new Size(746, 278);
            MostrarEquipamentosAtivos.TabIndex = 25;
            MostrarEquipamentosAtivos.CellMouseDoubleClick += MostrarEquipamentosAtivos_CellMouseDoubleClick;
            // 
            // ID_equipamento
            // 
            ID_equipamento.DataPropertyName = "ID_equipamento";
            ID_equipamento.HeaderText = "ID";
            ID_equipamento.MinimumWidth = 8;
            ID_equipamento.Name = "ID_equipamento";
            ID_equipamento.ReadOnly = true;
            ID_equipamento.Width = 80;
            // 
            // ValorNumerico
            // 
            ValorNumerico.DataPropertyName = "ValorNumerico";
            ValorNumerico.HeaderText = "ValorNumerico";
            ValorNumerico.MinimumWidth = 8;
            ValorNumerico.Name = "ValorNumerico";
            ValorNumerico.ReadOnly = true;
            ValorNumerico.Visible = false;
            ValorNumerico.Width = 150;
            // 
            // Nome_equipamento
            // 
            Nome_equipamento.DataPropertyName = "Nome";
            Nome_equipamento.HeaderText = "Nome";
            Nome_equipamento.MinimumWidth = 8;
            Nome_equipamento.Name = "Nome_equipamento";
            Nome_equipamento.ReadOnly = true;
            Nome_equipamento.Width = 150;
            // 
            // Ativo
            // 
            Ativo.DataPropertyName = "Ativo_inativo";
            Ativo.HeaderText = "Ativo_inativo";
            Ativo.MinimumWidth = 8;
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Visible = false;
            Ativo.Width = 150;
            // 
            // value
            // 
            value.DataPropertyName = "Valor";
            value.HeaderText = "Valor";
            value.MinimumWidth = 8;
            value.Name = "value";
            value.ReadOnly = true;
            value.Width = 150;
            // 
            // description
            // 
            description.DataPropertyName = "Descricao";
            description.HeaderText = "Descrição";
            description.MinimumWidth = 8;
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 150;
            // 
            // id_status
            // 
            id_status.DataPropertyName = "id_status";
            id_status.HeaderText = "id_status";
            id_status.MinimumWidth = 8;
            id_status.Name = "id_status";
            id_status.ReadOnly = true;
            id_status.Visible = false;
            id_status.Width = 150;
            // 
            // Etiqueta
            // 
            Etiqueta.DataPropertyName = "Etiqueta";
            Etiqueta.HeaderText = "Etiqueta";
            Etiqueta.MinimumWidth = 8;
            Etiqueta.Name = "Etiqueta";
            Etiqueta.ReadOnly = true;
            Etiqueta.Width = 150;
            // 
            // colabID
            // 
            colabID.DataPropertyName = "id_colaborador";
            colabID.HeaderText = "colaborador_id";
            colabID.MinimumWidth = 8;
            colabID.Name = "colabID";
            colabID.ReadOnly = true;
            colabID.Visible = false;
            colabID.Width = 150;
            // 
            // marca_id
            // 
            marca_id.DataPropertyName = "id_marca";
            marca_id.HeaderText = "marca_id";
            marca_id.MinimumWidth = 8;
            marca_id.Name = "marca_id";
            marca_id.ReadOnly = true;
            marca_id.Visible = false;
            marca_id.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_cadastrar);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnVisualizar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 944);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(1703, 83);
            panel1.TabIndex = 26;
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.DarkGreen;
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.Location = new Point(734, 12);
            btnVisualizar.Margin = new Padding(4, 5, 4, 5);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(214, 63);
            btnVisualizar.TabIndex = 27;
            btnVisualizar.Text = "Visualizar equipamentos";
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(659, 110);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 30;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(659, 178);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 31;
            label3.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(659, 248);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 32;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(659, 320);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 33;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(881, 325);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 34;
            label7.Text = "*";
            // 
            // MostrarEquipamentosDesativados
            // 
            MostrarEquipamentosDesativados.AllowUserToAddRows = false;
            MostrarEquipamentosDesativados.AllowUserToDeleteRows = false;
            MostrarEquipamentosDesativados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipamentosDesativados.Columns.AddRange(new DataGridViewColumn[] { ID_equipamentoDesativado, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            MostrarEquipamentosDesativados.Location = new Point(901, 567);
            MostrarEquipamentosDesativados.Name = "MostrarEquipamentosDesativados";
            MostrarEquipamentosDesativados.ReadOnly = true;
            MostrarEquipamentosDesativados.RowHeadersWidth = 62;
            MostrarEquipamentosDesativados.RowTemplate.Height = 33;
            MostrarEquipamentosDesativados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipamentosDesativados.Size = new Size(746, 278);
            MostrarEquipamentosDesativados.TabIndex = 35;
            MostrarEquipamentosDesativados.CellMouseDoubleClick += MostrarEquipamentosDesativados_CellMouseDoubleClick;
            // 
            // ID_equipamentoDesativado
            // 
            ID_equipamentoDesativado.DataPropertyName = "ID_equipamento";
            ID_equipamentoDesativado.HeaderText = "ID";
            ID_equipamentoDesativado.MinimumWidth = 8;
            ID_equipamentoDesativado.Name = "ID_equipamentoDesativado";
            ID_equipamentoDesativado.ReadOnly = true;
            ID_equipamentoDesativado.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ValorNumerico";
            dataGridViewTextBoxColumn2.HeaderText = "ValorNumerico";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Visible = false;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn3.HeaderText = "Nome";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Ativo_inativo";
            dataGridViewTextBoxColumn4.HeaderText = "Ativo_inativo";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Valor";
            dataGridViewTextBoxColumn5.HeaderText = "Valor";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Descricao";
            dataGridViewTextBoxColumn6.HeaderText = "Descrição";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "id_status";
            dataGridViewTextBoxColumn7.HeaderText = "id_status";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Visible = false;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Etiqueta";
            dataGridViewTextBoxColumn8.HeaderText = "Etiqueta";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "id_colaborador";
            dataGridViewTextBoxColumn9.HeaderText = "colaborador_id";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "id_marca";
            dataGridViewTextBoxColumn10.HeaderText = "marca_id";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGreen;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(54, 527);
            label8.Name = "label8";
            label8.Size = new Size(235, 32);
            label8.TabIndex = 36;
            label8.Text = "Equipamentos ativos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGreen;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(901, 527);
            label9.Name = "label9";
            label9.Size = new Size(298, 32);
            label9.TabIndex = 37;
            label9.Text = "Equipamentos desativados";
            // 
            // btnAtivar
            // 
            btnAtivar.BackColor = Color.DarkGreen;
            btnAtivar.ForeColor = Color.White;
            btnAtivar.Location = new Point(1121, 853);
            btnAtivar.Name = "btnAtivar";
            btnAtivar.Size = new Size(214, 63);
            btnAtivar.TabIndex = 38;
            btnAtivar.Text = "Ativar equipamento";
            btnAtivar.UseVisualStyleBackColor = false;
            btnAtivar.Click += btnAtivar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.ForeColor = Color.White;
            button2.Location = new Point(901, 853);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(214, 63);
            button2.TabIndex = 39;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnPesquisarAtivo
            // 
            btnPesquisarAtivo.BackColor = Color.DarkGreen;
            btnPesquisarAtivo.ForeColor = Color.White;
            btnPesquisarAtivo.Location = new Point(1051, 137);
            btnPesquisarAtivo.Name = "btnPesquisarAtivo";
            btnPesquisarAtivo.Size = new Size(234, 37);
            btnPesquisarAtivo.TabIndex = 41;
            btnPesquisarAtivo.Text = "Pesquisar equipamento ativo";
            btnPesquisarAtivo.UseVisualStyleBackColor = false;
            btnPesquisarAtivo.Click += btnPesquisarAtivo_Click;
            // 
            // CadEquipamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1703, 1027);
            Controls.Add(btnPesquisarAtivo);
            Controls.Add(button2);
            Controls.Add(btnAtivar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(MostrarEquipamentosDesativados);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(MostrarEquipamentosAtivos);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Desativar);
            Controls.Add(check_ativo);
            Controls.Add(label1);
            Controls.Add(escolherMarca);
            Controls.Add(panel2);
            Controls.Add(inputPrecoEquip);
            Controls.Add(inputEtiquetaEquip);
            Controls.Add(inputDesEquip);
            Controls.Add(inputEquipNome);
            Controls.Add(EtiquetaEquip);
            Controls.Add(PrecoEquip);
            Controls.Add(DescricaoEquip);
            Controls.Add(MarcaEquip);
            Controls.Add(NomeEquip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "CadEquipamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar equipamento";
            Load += CadEquipamento_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentosAtivos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentosDesativados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeEquip;
        private Label MarcaEquip;
        private Label DescricaoEquip;
        private Label PrecoEquip;
        private Label EtiquetaEquip;
        private TextBox inputEquipNome;
        private TextBox inputDesEquip;
        private TextBox inputEtiquetaEquip;
        private TextBox inputPrecoEquip;
        private Button btn_cadastrar;
        private Button btn_cancelar;
        private Panel panel2;
        private ComboBox escolherMarca;
        private Label label1;
        private CheckBox check_ativo;
        private Button btn_Limpar;
        private TextBox txtID;
        private Button btn_Desativar;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Etiqueta_identificacao;
        private DataGridViewTextBoxColumn id_colaborador;
        private DataGridViewTextBoxColumn id_marca;
        private DataGridView MostrarEquipamentosAtivos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private Panel panel1;
        private Label label2;
        private Button btnVisualizar;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView MostrarEquipamentosDesativados;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn ID_equipamento;
        private DataGridViewTextBoxColumn ValorNumerico;
        private DataGridViewTextBoxColumn Nome_equipamento;
        private DataGridViewTextBoxColumn Ativo;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn id_status;
        private DataGridViewTextBoxColumn Etiqueta;
        private DataGridViewTextBoxColumn colabID;
        private DataGridViewTextBoxColumn marca_id;
        private Button btnAtivar;
        private Button button2;
        private DataGridViewTextBoxColumn ID_equipamentoDesativado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button btnPesquisarAtivo;
    }
}