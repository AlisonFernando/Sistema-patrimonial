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
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsDisponiveis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EquipsSelecionados).BeginInit();
            SuspendLayout();
            // 
            // MostrarEquipsDisponiveis
            // 
            MostrarEquipsDisponiveis.AllowUserToAddRows = false;
            MostrarEquipsDisponiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsDisponiveis.Columns.AddRange(new DataGridViewColumn[] { ID_equipamento, Nome, Ativo_inativo, Valor, Descricao, Etiqueta_identificacao, id_colaborador, id_marca });
            MostrarEquipsDisponiveis.Location = new Point(62, 29);
            MostrarEquipsDisponiveis.Name = "MostrarEquipsDisponiveis";
            MostrarEquipsDisponiveis.RowHeadersWidth = 62;
            MostrarEquipsDisponiveis.RowTemplate.Height = 33;
            MostrarEquipsDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsDisponiveis.Size = new Size(814, 225);
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
            id_colaborador.HeaderText = "id_colaborador";
            id_colaborador.MinimumWidth = 8;
            id_colaborador.Name = "id_colaborador";
            id_colaborador.Visible = false;
            id_colaborador.Width = 150;
            // 
            // id_marca
            // 
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
            EquipsSelecionados.Location = new Point(62, 320);
            EquipsSelecionados.Name = "EquipsSelecionados";
            EquipsSelecionados.RowHeadersWidth = 62;
            EquipsSelecionados.RowTemplate.Height = 33;
            EquipsSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EquipsSelecionados.Size = new Size(814, 331);
            EquipsSelecionados.TabIndex = 1;
            // 
            // SelectEquips
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 805);
            Controls.Add(EquipsSelecionados);
            Controls.Add(MostrarEquipsDisponiveis);
            MaximizeBox = false;
            Name = "SelectEquips";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectEquips";
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsDisponiveis).EndInit();
            ((System.ComponentModel.ISupportInitialize)EquipsSelecionados).EndInit();
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
    }
}