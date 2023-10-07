namespace UI
{
    partial class TelaVerEquips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVerEquips));
            MostrarEquipamentos = new DataGridView();
            ID_equipamento = new DataGridViewTextBoxColumn();
            Nome_Equipamento = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Etiqueta = new DataGridViewTextBoxColumn();
            id_colaborador = new DataGridViewTextBoxColumn();
            id_marca = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnVoltar = new Button();
            btnVerEquips = new Button();
            txtID = new TextBox();
            HeaderCadColab = new Panel();
            label1 = new Label();
            txtNomePesquisar = new TextBox();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentos).BeginInit();
            panel1.SuspendLayout();
            HeaderCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // MostrarEquipamentos
            // 
            MostrarEquipamentos.AllowUserToAddRows = false;
            MostrarEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipamentos.Columns.AddRange(new DataGridViewColumn[] { ID_equipamento, Nome_Equipamento, Ativo_inativo, Valor, Descricao, Etiqueta, id_colaborador, id_marca });
            MostrarEquipamentos.Location = new Point(77, 154);
            MostrarEquipamentos.Name = "MostrarEquipamentos";
            MostrarEquipamentos.RowHeadersWidth = 62;
            MostrarEquipamentos.RowTemplate.Height = 33;
            MostrarEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipamentos.Size = new Size(965, 326);
            MostrarEquipamentos.TabIndex = 0;
            MostrarEquipamentos.CellContentClick += MostrarEquipamentos_CellContentClick;
            MostrarEquipamentos.CellMouseDoubleClick += MostrarEquipamentos_CellMouseDoubleClick;
            // 
            // ID_equipamento
            // 
            ID_equipamento.DataPropertyName = "ID_equipamento";
            ID_equipamento.HeaderText = "ID";
            ID_equipamento.MaxInputLength = 0;
            ID_equipamento.MinimumWidth = 8;
            ID_equipamento.Name = "ID_equipamento";
            ID_equipamento.Width = 150;
            // 
            // Nome_Equipamento
            // 
            Nome_Equipamento.DataPropertyName = "Nome";
            Nome_Equipamento.HeaderText = "Nome equipamento";
            Nome_Equipamento.MaxInputLength = 0;
            Nome_Equipamento.MinimumWidth = 8;
            Nome_Equipamento.Name = "Nome_Equipamento";
            Nome_Equipamento.Width = 150;
            // 
            // Ativo_inativo
            // 
            Ativo_inativo.DataPropertyName = "Ativo_inativo";
            Ativo_inativo.HeaderText = "Ativo_inativo";
            Ativo_inativo.MinimumWidth = 8;
            Ativo_inativo.Name = "Ativo_inativo";
            Ativo_inativo.Width = 150;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 8;
            Valor.Name = "Valor";
            Valor.Width = 150;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.MinimumWidth = 8;
            Descricao.Name = "Descricao";
            Descricao.Width = 150;
            // 
            // Etiqueta
            // 
            Etiqueta.DataPropertyName = "Etiqueta";
            Etiqueta.HeaderText = "Etiqueta";
            Etiqueta.MinimumWidth = 8;
            Etiqueta.Name = "Etiqueta";
            Etiqueta.Width = 150;
            // 
            // id_colaborador
            // 
            id_colaborador.DataPropertyName = "id_colaborador";
            id_colaborador.HeaderText = "id_colaborador";
            id_colaborador.MinimumWidth = 8;
            id_colaborador.Name = "id_colaborador";
            id_colaborador.Visible = false;
            id_colaborador.Width = 150;
            // 
            // id_marca
            // 
            id_marca.DataPropertyName = "id_marca";
            id_marca.HeaderText = "id_marca";
            id_marca.MinimumWidth = 8;
            id_marca.Name = "id_marca";
            id_marca.Visible = false;
            id_marca.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnVerEquips);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 550);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(1104, 83);
            panel1.TabIndex = 27;
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
            // btnVerEquips
            // 
            btnVerEquips.BackColor = Color.DarkGreen;
            btnVerEquips.Cursor = Cursors.Hand;
            btnVerEquips.Dock = DockStyle.Right;
            btnVerEquips.ForeColor = SystemColors.Control;
            btnVerEquips.Location = new Point(846, 10);
            btnVerEquips.Margin = new Padding(4, 5, 4, 5);
            btnVerEquips.Name = "btnVerEquips";
            btnVerEquips.Padding = new Padding(6);
            btnVerEquips.Size = new Size(249, 63);
            btnVerEquips.TabIndex = 7;
            btnVerEquips.Text = "Cadastrar equipamentos";
            btnVerEquips.UseVisualStyleBackColor = false;
            btnVerEquips.Click += btnEquips_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(238, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 23;
            txtID.Visible = false;
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
            HeaderCadColab.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(438, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 0;
            label1.Text = "Visualizar Equipamentos";
            // 
            // txtNomePesquisar
            // 
            txtNomePesquisar.Location = new Point(77, 117);
            txtNomePesquisar.MaxLength = 100;
            txtNomePesquisar.Name = "txtNomePesquisar";
            txtNomePesquisar.Size = new Size(150, 31);
            txtNomePesquisar.TabIndex = 29;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(233, 117);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(187, 34);
            btnPesquisar.TabIndex = 30;
            btnPesquisar.Text = "Pesquisar por nome";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(77, 496);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(79, 34);
            btnLimpar.TabIndex = 31;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // TelaVerEquips
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 633);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtNomePesquisar);
            Controls.Add(HeaderCadColab);
            Controls.Add(panel1);
            Controls.Add(MostrarEquipamentos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaVerEquips";
            Text = "Visualizar equipamentos";
            Load += TelaVerEquips_Load;
            ((System.ComponentModel.ISupportInitialize)MostrarEquipamentos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MostrarEquipamentos;
        private Panel panel1;
        private Button btnVoltar;
        private Button btnVerEquips;
        private TextBox txtID;
        private Panel HeaderCadColab;
        private Label label1;
        private TextBox txtNomePesquisar;
        private Button btnPesquisar;
        private DataGridViewTextBoxColumn ID_equipamento;
        private DataGridViewTextBoxColumn Nome_Equipamento;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Etiqueta;
        private DataGridViewTextBoxColumn id_colaborador;
        private DataGridViewTextBoxColumn id_marca;
        private Button btnLimpar;
    }
}