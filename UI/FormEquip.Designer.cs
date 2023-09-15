namespace UI
{
    partial class CadEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEquip));
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
            escolherMarca = new ComboBox();
            label1 = new Label();
            check_ativo = new CheckBox();
            btn_Limpar = new Button();
            txtID = new TextBox();
            btn_Deletar = new Button();
            MostrarEquipamentos = new DataGridView();
            ID_equipamento = new DataGridViewTextBoxColumn();
            Nome_equipamento = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            Etiqueta = new DataGridViewTextBoxColumn();
            colabID = new DataGridViewTextBoxColumn();
            marca_id = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(17, 117);
            NomeEquip.Margin = new Padding(4, 0, 4, 0);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(199, 25);
            NomeEquip.TabIndex = 0;
            NomeEquip.Text = "Nome do Equipamento";
            // 
            // MarcaEquip
            // 
            MarcaEquip.AutoSize = true;
            MarcaEquip.Location = new Point(351, 117);
            MarcaEquip.Margin = new Padding(4, 0, 4, 0);
            MarcaEquip.Name = "MarcaEquip";
            MarcaEquip.Size = new Size(60, 25);
            MarcaEquip.TabIndex = 1;
            MarcaEquip.Text = "Marca";
            // 
            // DescricaoEquip
            // 
            DescricaoEquip.AutoSize = true;
            DescricaoEquip.Location = new Point(17, 190);
            DescricaoEquip.Margin = new Padding(4, 0, 4, 0);
            DescricaoEquip.Name = "DescricaoEquip";
            DescricaoEquip.Size = new Size(88, 25);
            DescricaoEquip.TabIndex = 2;
            DescricaoEquip.Text = "Descrição";
            // 
            // PrecoEquip
            // 
            PrecoEquip.AutoSize = true;
            PrecoEquip.Location = new Point(351, 190);
            PrecoEquip.Margin = new Padding(4, 0, 4, 0);
            PrecoEquip.Name = "PrecoEquip";
            PrecoEquip.Size = new Size(56, 25);
            PrecoEquip.TabIndex = 3;
            PrecoEquip.Text = "Preço";
            // 
            // EtiquetaEquip
            // 
            EtiquetaEquip.AutoSize = true;
            EtiquetaEquip.Location = new Point(17, 263);
            EtiquetaEquip.Margin = new Padding(4, 0, 4, 0);
            EtiquetaEquip.Name = "EtiquetaEquip";
            EtiquetaEquip.Size = new Size(76, 25);
            EtiquetaEquip.TabIndex = 4;
            EtiquetaEquip.Text = "Etiqueta";
            // 
            // inputEquipNome
            // 
            inputEquipNome.Location = new Point(17, 147);
            inputEquipNome.Margin = new Padding(4, 5, 4, 5);
            inputEquipNome.MaxLength = 100;
            inputEquipNome.Name = "inputEquipNome";
            inputEquipNome.Size = new Size(317, 31);
            inputEquipNome.TabIndex = 1;
            // 
            // inputDesEquip
            // 
            inputDesEquip.Location = new Point(17, 220);
            inputDesEquip.Margin = new Padding(4, 5, 4, 5);
            inputDesEquip.MaxLength = 100;
            inputDesEquip.Name = "inputDesEquip";
            inputDesEquip.Size = new Size(317, 31);
            inputDesEquip.TabIndex = 2;
            // 
            // inputEtiquetaEquip
            // 
            inputEtiquetaEquip.Location = new Point(17, 293);
            inputEtiquetaEquip.Margin = new Padding(4, 5, 4, 5);
            inputEtiquetaEquip.MaxLength = 10;
            inputEtiquetaEquip.Name = "inputEtiquetaEquip";
            inputEtiquetaEquip.Size = new Size(317, 31);
            inputEtiquetaEquip.TabIndex = 3;
            // 
            // inputPrecoEquip
            // 
            inputPrecoEquip.Location = new Point(351, 220);
            inputPrecoEquip.Margin = new Padding(4, 5, 4, 5);
            inputPrecoEquip.MaxLength = 10;
            inputPrecoEquip.Name = "inputPrecoEquip";
            inputPrecoEquip.Size = new Size(164, 31);
            inputPrecoEquip.TabIndex = 5;
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
            btn_cancelar.TabIndex = 1;
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
            btn_cadastrar.Location = new Point(638, 10);
            btn_cadastrar.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Padding = new Padding(6);
            btn_cadastrar.Size = new Size(207, 63);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
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
            panel2.Size = new Size(854, 83);
            panel2.TabIndex = 13;
            // 
            // escolherMarca
            // 
            escolherMarca.FormattingEnabled = true;
            escolherMarca.Location = new Point(351, 147);
            escolherMarca.Margin = new Padding(4, 5, 4, 5);
            escolherMarca.Name = "escolherMarca";
            escolherMarca.Size = new Size(164, 33);
            escolherMarca.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 267);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 20;
            label1.Text = "Ativo/Inativo";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(351, 297);
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
            btn_Limpar.Location = new Point(238, 616);
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
            txtID.Location = new Point(238, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 23;
            txtID.Visible = false;
            // 
            // btn_Deletar
            // 
            btn_Deletar.BackColor = Color.DarkGreen;
            btn_Deletar.ForeColor = Color.White;
            btn_Deletar.Location = new Point(17, 616);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(214, 63);
            btn_Deletar.TabIndex = 24;
            btn_Deletar.Text = "Deletar";
            btn_Deletar.UseVisualStyleBackColor = false;
            btn_Deletar.Click += btn_Deletar_Click;
            // 
            // MostrarEquipamentos
            // 
            MostrarEquipamentos.AllowUserToAddRows = false;
            MostrarEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipamentos.Columns.AddRange(new DataGridViewColumn[] { ID_equipamento, Nome_equipamento, Ativo, value, description, Etiqueta, colabID, marca_id });
            MostrarEquipamentos.Location = new Point(17, 332);
            MostrarEquipamentos.Name = "MostrarEquipamentos";
            MostrarEquipamentos.RowHeadersWidth = 62;
            MostrarEquipamentos.RowTemplate.Height = 33;
            MostrarEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipamentos.Size = new Size(814, 278);
            MostrarEquipamentos.TabIndex = 25;
            MostrarEquipamentos.CellContentDoubleClick += MostrarEquipamentos_CellContentDoubleClick;
            // 
            // ID_equipamento
            // 
            ID_equipamento.DataPropertyName = "ID_equipamento";
            ID_equipamento.HeaderText = "ID_equipamento";
            ID_equipamento.MinimumWidth = 8;
            ID_equipamento.Name = "ID_equipamento";
            ID_equipamento.Width = 150;
            // 
            // Nome_equipamento
            // 
            Nome_equipamento.DataPropertyName = "Nome";
            Nome_equipamento.HeaderText = "Nome";
            Nome_equipamento.MinimumWidth = 8;
            Nome_equipamento.Name = "Nome_equipamento";
            Nome_equipamento.Width = 150;
            // 
            // Ativo
            // 
            Ativo.DataPropertyName = "Ativo_inativo";
            Ativo.HeaderText = "Ativo_inativo";
            Ativo.MinimumWidth = 8;
            Ativo.Name = "Ativo";
            Ativo.Visible = false;
            Ativo.Width = 150;
            // 
            // value
            // 
            value.DataPropertyName = "Valor";
            value.HeaderText = "Valor";
            value.MinimumWidth = 8;
            value.Name = "value";
            value.Width = 150;
            // 
            // description
            // 
            description.DataPropertyName = "Descricao";
            description.HeaderText = "Descrição";
            description.MinimumWidth = 8;
            description.Name = "description";
            description.Width = 150;
            // 
            // Etiqueta
            // 
            Etiqueta.DataPropertyName = "Etiqueta";
            Etiqueta.HeaderText = "Etiqueta";
            Etiqueta.MinimumWidth = 8;
            Etiqueta.Name = "Etiqueta";
            Etiqueta.Width = 150;
            // 
            // colabID
            // 
            colabID.DataPropertyName = "id_colaborador";
            colabID.HeaderText = "colaborador_id";
            colabID.MinimumWidth = 8;
            colabID.Name = "colabID";
            colabID.Visible = false;
            colabID.Width = 150;
            // 
            // marca_id
            // 
            marca_id.DataPropertyName = "id_marca";
            marca_id.HeaderText = "marca_id";
            marca_id.MinimumWidth = 8;
            marca_id.Name = "marca_id";
            marca_id.Visible = false;
            marca_id.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_cadastrar);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 749);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(854, 83);
            panel1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(227, 23);
            label2.Name = "label2";
            label2.Size = new Size(362, 41);
            label2.TabIndex = 0;
            label2.Text = "Cadastrar equipamentos";
            // 
            // CadEquip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 832);
            Controls.Add(panel1);
            Controls.Add(MostrarEquipamentos);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Deletar);
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
            Name = "CadEquip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar equipamento";
            Load += CadEquip_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btn_Deletar;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Etiqueta_identificacao;
        private DataGridViewTextBoxColumn id_colaborador;
        private DataGridViewTextBoxColumn id_marca;
        private DataGridView MostrarEquipamentos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn ID_equipamento;
        private DataGridViewTextBoxColumn Nome_equipamento;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn Etiqueta;
        private DataGridViewTextBoxColumn colabID;
        private DataGridViewTextBoxColumn marca_id;
        private DataGridViewTextBoxColumn Ativo;
        private Panel panel1;
        private Label label2;
    }
}