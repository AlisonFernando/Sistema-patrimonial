namespace UI
{
    partial class SelectEquips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectEquips));
            MostrarEquipsDisponiveis = new DataGridView();
            ID_equipamento = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Etiqueta_identificacao = new DataGridViewTextBoxColumn();
            id_colaborador = new DataGridViewTextBoxColumn();
            id_marca = new DataGridViewTextBoxColumn();
            EquipsSelecionados = new DataGridView();
            ID_select = new DataGridViewTextBoxColumn();
            NomeEquip = new DataGridViewTextBoxColumn();
            Ativo_inativoEquip = new DataGridViewTextBoxColumn();
            ValorEquips = new DataGridViewTextBoxColumn();
            DecricaoEquip = new DataGridViewTextBoxColumn();
            EtiquetaEquips = new DataGridViewTextBoxColumn();
            id_colab = new DataGridViewTextBoxColumn();
            id_marcaEquip = new DataGridViewTextBoxColumn();
            btn_limpar = new Button();
            btnCadColab = new Button();
            FotterCadColab = new Panel();
            panel1 = new Panel();
            btn_voltar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsDisponiveis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EquipsSelecionados).BeginInit();
            FotterCadColab.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MostrarEquipsDisponiveis
            // 
            MostrarEquipsDisponiveis.AllowUserToAddRows = false;
            MostrarEquipsDisponiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsDisponiveis.Columns.AddRange(new DataGridViewColumn[] { ID_equipamento, Nome, Ativo_inativo, Valor, Descricao, Etiqueta_identificacao, id_colaborador, id_marca });
            MostrarEquipsDisponiveis.Location = new Point(0, 44);
            MostrarEquipsDisponiveis.Margin = new Padding(2, 2, 2, 2);
            MostrarEquipsDisponiveis.Name = "MostrarEquipsDisponiveis";
            MostrarEquipsDisponiveis.RowHeadersWidth = 62;
            MostrarEquipsDisponiveis.RowTemplate.Height = 33;
            MostrarEquipsDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsDisponiveis.Size = new Size(580, 135);
            MostrarEquipsDisponiveis.TabIndex = 0;
            MostrarEquipsDisponiveis.CellMouseDoubleClick += MostrarEquipsDisponiveis_CellMouseDoubleClick;
            // 
            // ID_equipamento
            // 
            ID_equipamento.DataPropertyName = "ID_equipamento";
            ID_equipamento.HeaderText = "ID";
            ID_equipamento.MinimumWidth = 8;
            ID_equipamento.Name = "ID_equipamento";
            ID_equipamento.Width = 150;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.Width = 150;
            // 
            // Ativo_inativo
            // 
            Ativo_inativo.DataPropertyName = "Ativo_inativo";
            Ativo_inativo.HeaderText = "Ativo";
            Ativo_inativo.MinimumWidth = 8;
            Ativo_inativo.Name = "Ativo_inativo";
            Ativo_inativo.Visible = false;
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
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 8;
            Descricao.Name = "Descricao";
            Descricao.Width = 150;
            // 
            // Etiqueta_identificacao
            // 
            Etiqueta_identificacao.DataPropertyName = "Etiqueta";
            Etiqueta_identificacao.HeaderText = "Etiqueta";
            Etiqueta_identificacao.MinimumWidth = 8;
            Etiqueta_identificacao.Name = "Etiqueta_identificacao";
            Etiqueta_identificacao.Width = 150;
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
            // EquipsSelecionados
            // 
            EquipsSelecionados.AllowUserToAddRows = false;
            EquipsSelecionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EquipsSelecionados.Columns.AddRange(new DataGridViewColumn[] { ID_select, NomeEquip, Ativo_inativoEquip, ValorEquips, DecricaoEquip, EtiquetaEquips, id_colab, id_marcaEquip });
            EquipsSelecionados.Location = new Point(0, 192);
            EquipsSelecionados.Margin = new Padding(2, 2, 2, 2);
            EquipsSelecionados.Name = "EquipsSelecionados";
            EquipsSelecionados.RowHeadersWidth = 62;
            EquipsSelecionados.RowTemplate.Height = 33;
            EquipsSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EquipsSelecionados.Size = new Size(580, 199);
            EquipsSelecionados.TabIndex = 1;
            // 
            // ID_select
            // 
            ID_select.DataPropertyName = "ID_equipamento";
            ID_select.HeaderText = "ID";
            ID_select.MinimumWidth = 8;
            ID_select.Name = "ID_select";
            ID_select.Width = 150;
            // 
            // NomeEquip
            // 
            NomeEquip.DataPropertyName = "Nome_equipamento";
            NomeEquip.HeaderText = "Nome";
            NomeEquip.MinimumWidth = 8;
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Width = 150;
            // 
            // Ativo_inativoEquip
            // 
            Ativo_inativoEquip.HeaderText = "Ativo";
            Ativo_inativoEquip.MinimumWidth = 8;
            Ativo_inativoEquip.Name = "Ativo_inativoEquip";
            Ativo_inativoEquip.Visible = false;
            Ativo_inativoEquip.Width = 150;
            // 
            // ValorEquips
            // 
            ValorEquips.DataPropertyName = "Valor";
            ValorEquips.HeaderText = "Valor";
            ValorEquips.MinimumWidth = 8;
            ValorEquips.Name = "ValorEquips";
            ValorEquips.Width = 150;
            // 
            // DecricaoEquip
            // 
            DecricaoEquip.DataPropertyName = "Descricao";
            DecricaoEquip.HeaderText = "Descrição";
            DecricaoEquip.MinimumWidth = 8;
            DecricaoEquip.Name = "DecricaoEquip";
            DecricaoEquip.Width = 150;
            // 
            // EtiquetaEquips
            // 
            EtiquetaEquips.DataPropertyName = "Etiqueta_identificaco";
            EtiquetaEquips.HeaderText = "Etiqueta";
            EtiquetaEquips.MinimumWidth = 8;
            EtiquetaEquips.Name = "EtiquetaEquips";
            EtiquetaEquips.Width = 150;
            // 
            // id_colab
            // 
            id_colab.DataPropertyName = "id_colaborador";
            id_colab.HeaderText = "id_colaborador";
            id_colab.MinimumWidth = 8;
            id_colab.Name = "id_colab";
            id_colab.Visible = false;
            id_colab.Width = 150;
            // 
            // id_marcaEquip
            // 
            id_marcaEquip.DataPropertyName = "id_marca";
            id_marcaEquip.HeaderText = "id_marca";
            id_marcaEquip.MinimumWidth = 8;
            id_marcaEquip.Name = "id_marcaEquip";
            id_marcaEquip.Visible = false;
            id_marcaEquip.Width = 150;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.DarkGreen;
            btn_limpar.Dock = DockStyle.Left;
            btn_limpar.ForeColor = Color.White;
            btn_limpar.Location = new Point(6, 6);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(138, 44);
            btn_limpar.TabIndex = 2;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btnCadColab
            // 
            btnCadColab.BackColor = Color.DarkGreen;
            btnCadColab.Dock = DockStyle.Right;
            btnCadColab.ForeColor = Color.White;
            btnCadColab.Location = new Point(447, 6);
            btnCadColab.Name = "btnCadColab";
            btnCadColab.Size = new Size(138, 44);
            btnCadColab.TabIndex = 3;
            btnCadColab.Text = "Cadastrar";
            btnCadColab.UseVisualStyleBackColor = false;
            btnCadColab.Click += btnCadColab_Click;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btnCadColab);
            FotterCadColab.Controls.Add(btn_limpar);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 394);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(6, 6, 6, 6);
            FotterCadColab.Size = new Size(591, 56);
            FotterCadColab.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 39);
            panel1.TabIndex = 17;
            // 
            // btn_voltar
            // 
            btn_voltar.AutoSize = true;
            btn_voltar.BackColor = Color.White;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.ForeColor = Color.DimGray;
            btn_voltar.Image = Properties.Resources.seta_esquerda;
            btn_voltar.Location = new Point(11, 2);
            btn_voltar.Margin = new Padding(2, 2, 2, 2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(40, 40);
            btn_voltar.TabIndex = 1;
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 21);
            label1.TabIndex = 0;
            label1.Text = "Equipamentos disponiveis";
            // 
            // SelectEquips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(panel1);
            Controls.Add(FotterCadColab);
            Controls.Add(EquipsSelecionados);
            Controls.Add(MostrarEquipsDisponiveis);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "SelectEquips";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectEquips";
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsDisponiveis).EndInit();
            ((System.ComponentModel.ISupportInitialize)EquipsSelecionados).EndInit();
            FotterCadColab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MostrarEquipsDisponiveis;
        private DataGridViewTextBoxColumn ID_equipamento;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Etiqueta_identificacao;
        private DataGridViewTextBoxColumn id_colaborador;
        private DataGridViewTextBoxColumn id_marca;
        private DataGridView EquipsSelecionados;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome_equip;
        private DataGridViewTextBoxColumn ValorEquip;
        private DataGridViewTextBoxColumn DescricaoEquip;
        private DataGridViewTextBoxColumn EtiquetaEquip;
        private DataGridViewTextBoxColumn ID_select;
        private DataGridViewTextBoxColumn NomeEquip;
        private DataGridViewTextBoxColumn Ativo_inativoEquip;
        private DataGridViewTextBoxColumn ValorEquips;
        private DataGridViewTextBoxColumn DecricaoEquip;
        private DataGridViewTextBoxColumn EtiquetaEquips;
        private DataGridViewTextBoxColumn id_colab;
        private DataGridViewTextBoxColumn id_marcaEquip;
        private Button btn_limpar;
        private Button btnCadColab;
        private Panel FotterCadColab;
        private Panel panel1;
        private Label label1;
        private Button btn_voltar;
    }
}