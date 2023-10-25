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
            btn_Deletar = new Button();
            MostrarEquipamentos = new DataGridView();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(169, 70);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(131, 15);
            NomeEquip.TabIndex = 0;
            NomeEquip.Text = "Nome do Equipamento";
            // 
            // MarcaEquip
            // 
            MarcaEquip.AutoSize = true;
            MarcaEquip.Location = new Point(174, 196);
            MarcaEquip.Name = "MarcaEquip";
            MarcaEquip.Size = new Size(40, 15);
            MarcaEquip.TabIndex = 1;
            MarcaEquip.Text = "Marca";
            // 
            // DescricaoEquip
            // 
            DescricaoEquip.AutoSize = true;
            DescricaoEquip.Location = new Point(169, 109);
            DescricaoEquip.Name = "DescricaoEquip";
            DescricaoEquip.Size = new Size(58, 15);
            DescricaoEquip.TabIndex = 2;
            DescricaoEquip.Text = "Descrição";
            // 
            // PrecoEquip
            // 
            PrecoEquip.AutoSize = true;
            PrecoEquip.Location = new Point(330, 197);
            PrecoEquip.Name = "PrecoEquip";
            PrecoEquip.Size = new Size(37, 15);
            PrecoEquip.TabIndex = 3;
            PrecoEquip.Text = "Preço";
            // 
            // EtiquetaEquip
            // 
            EtiquetaEquip.AutoSize = true;
            EtiquetaEquip.Location = new Point(169, 154);
            EtiquetaEquip.Name = "EtiquetaEquip";
            EtiquetaEquip.Size = new Size(50, 15);
            EtiquetaEquip.TabIndex = 4;
            EtiquetaEquip.Text = "Etiqueta";
            // 
            // inputEquipNome
            // 
            inputEquipNome.Location = new Point(159, 88);
            inputEquipNome.MaxLength = 100;
            inputEquipNome.Name = "inputEquipNome";
            inputEquipNome.Size = new Size(272, 23);
            inputEquipNome.TabIndex = 1;
            // 
            // inputDesEquip
            // 
            inputDesEquip.Location = new Point(159, 127);
            inputDesEquip.MaxLength = 100;
            inputDesEquip.Name = "inputDesEquip";
            inputDesEquip.Size = new Size(272, 23);
            inputDesEquip.TabIndex = 2;
            // 
            // inputEtiquetaEquip
            // 
            inputEtiquetaEquip.Location = new Point(159, 170);
            inputEtiquetaEquip.MaxLength = 10;
            inputEtiquetaEquip.Name = "inputEtiquetaEquip";
            inputEtiquetaEquip.Size = new Size(272, 23);
            inputEtiquetaEquip.TabIndex = 3;
            // 
            // inputPrecoEquip
            // 
            inputPrecoEquip.Location = new Point(315, 215);
            inputPrecoEquip.MaxLength = 10;
            inputPrecoEquip.Name = "inputPrecoEquip";
            inputPrecoEquip.Size = new Size(116, 23);
            inputPrecoEquip.TabIndex = 5;
            inputPrecoEquip.KeyPress += inputPrecoEquip_KeyPress;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.DarkGreen;
            btn_cancelar.Dock = DockStyle.Left;
            btn_cancelar.ForeColor = SystemColors.Control;
            btn_cancelar.Location = new Point(6, 6);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(139, 38);
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
            btn_cadastrar.Location = new Point(447, 6);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Padding = new Padding(4, 4, 4, 4);
            btn_cadastrar.Size = new Size(145, 38);
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
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6, 6, 6, 6);
            panel2.Size = new Size(598, 50);
            panel2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(167, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(242, 28);
            label2.TabIndex = 0;
            label2.Text = "Cadastrar equipamentos";
            // 
            // escolherMarca
            // 
            escolherMarca.FormattingEnabled = true;
            escolherMarca.Location = new Point(159, 214);
            escolherMarca.Name = "escolherMarca";
            escolherMarca.Size = new Size(116, 23);
            escolherMarca.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 237);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 20;
            label1.Text = "Ativo/Inativo";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(159, 255);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(54, 19);
            check_ativo.TabIndex = 6;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.DarkGreen;
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(232, 476);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(150, 38);
            btn_Limpar.TabIndex = 22;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(167, 16);
            txtID.Margin = new Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(106, 23);
            txtID.TabIndex = 23;
            txtID.Visible = false;
            // 
            // btn_Deletar
            // 
            btn_Deletar.BackColor = Color.DarkGreen;
            btn_Deletar.ForeColor = Color.White;
            btn_Deletar.Location = new Point(13, 476);
            btn_Deletar.Margin = new Padding(2, 2, 2, 2);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(150, 38);
            btn_Deletar.TabIndex = 24;
            btn_Deletar.Text = "Deletar";
            btn_Deletar.UseVisualStyleBackColor = false;
            btn_Deletar.Click += btn_Deletar_Click;
            // 
            // MostrarEquipamentos
            // 
            MostrarEquipamentos.AllowUserToAddRows = false;
            MostrarEquipamentos.AllowUserToDeleteRows = false;
            MostrarEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipamentos.Columns.AddRange(new DataGridViewColumn[] { ID_equipamento, ValorNumerico, Nome_equipamento, Ativo, value, description, id_status, Etiqueta, colabID, marca_id });
            MostrarEquipamentos.Location = new Point(13, 306);
            MostrarEquipamentos.Margin = new Padding(2, 2, 2, 2);
            MostrarEquipamentos.Name = "MostrarEquipamentos";
            MostrarEquipamentos.ReadOnly = true;
            MostrarEquipamentos.RowHeadersWidth = 62;
            MostrarEquipamentos.RowTemplate.Height = 33;
            MostrarEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipamentos.Size = new Size(570, 167);
            MostrarEquipamentos.TabIndex = 25;
            MostrarEquipamentos.CellContentDoubleClick += MostrarEquipamentos_CellContentDoubleClick;
            // 
            // ID_equipamento
            // 
            ID_equipamento.DataPropertyName = "ID_equipamento";
            ID_equipamento.HeaderText = "ID_equipamento";
            ID_equipamento.MinimumWidth = 8;
            ID_equipamento.Name = "ID_equipamento";
            ID_equipamento.ReadOnly = true;
            ID_equipamento.Width = 150;
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
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 538);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 6, 6, 6);
            panel1.Size = new Size(598, 50);
            panel1.TabIndex = 26;
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.DarkGreen;
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.Location = new Point(433, 478);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(150, 38);
            btnVisualizar.TabIndex = 27;
            btnVisualizar.Text = "Visualizar equipamentos";
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(159, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 30;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(159, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 31;
            label3.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(159, 154);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 32;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(159, 197);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 33;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(315, 200);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 34;
            label7.Text = "*";
            // 
            // CadEquipamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 588);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnVisualizar);
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
            MaximizeBox = false;
            Name = "CadEquipamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar equipamento";
            Load += CadEquipamento_Load;
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
        private Panel panel1;
        private Label label2;
        private Button btnVisualizar;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
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
    }
}