﻿namespace UI
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
            EquipsSelecionados = new DataGridView();
            btn_limpar = new Button();
            btnCadColab = new Button();
            FotterCadColab = new Panel();
            panel1 = new Panel();
            btn_voltar = new Button();
            label1 = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            label2 = new Label();
            label3 = new Label();
            ID_equipamento = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Etiqueta_identificacao = new DataGridViewTextBoxColumn();
            id_colaborador = new DataGridViewTextBoxColumn();
            id_marca = new DataGridViewTextBoxColumn();
            id_setor = new DataGridViewTextBoxColumn();
            ValorNumerico = new DataGridViewTextBoxColumn();
            ID_select = new DataGridViewTextBoxColumn();
            NomeEquip = new DataGridViewTextBoxColumn();
            Ativo_inativoEquip = new DataGridViewTextBoxColumn();
            ValorEquips = new DataGridViewTextBoxColumn();
            DecricaoEquip = new DataGridViewTextBoxColumn();
            EtiquetaEquips = new DataGridViewTextBoxColumn();
            id_colab = new DataGridViewTextBoxColumn();
            id_marcaEquip = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsDisponiveis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EquipsSelecionados).BeginInit();
            FotterCadColab.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MostrarEquipsDisponiveis
            // 
            MostrarEquipsDisponiveis.AllowUserToAddRows = false;
            MostrarEquipsDisponiveis.AllowUserToDeleteRows = false;
            MostrarEquipsDisponiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsDisponiveis.Columns.AddRange(new DataGridViewColumn[] { ID_equipamento, Nome, Ativo_inativo, Valor, Descricao, Etiqueta_identificacao, id_colaborador, id_marca, id_setor, ValorNumerico });
            MostrarEquipsDisponiveis.Location = new Point(17, 234);
            MostrarEquipsDisponiveis.Name = "MostrarEquipsDisponiveis";
            MostrarEquipsDisponiveis.ReadOnly = true;
            MostrarEquipsDisponiveis.RowHeadersWidth = 62;
            MostrarEquipsDisponiveis.RowTemplate.Height = 33;
            MostrarEquipsDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsDisponiveis.Size = new Size(664, 225);
            MostrarEquipsDisponiveis.TabIndex = 0;
            MostrarEquipsDisponiveis.CellMouseDoubleClick += MostrarEquipsDisponiveis_CellMouseDoubleClick;
            // 
            // EquipsSelecionados
            // 
            EquipsSelecionados.AllowUserToAddRows = false;
            EquipsSelecionados.AllowUserToDeleteRows = false;
            EquipsSelecionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EquipsSelecionados.Columns.AddRange(new DataGridViewColumn[] { ID_select, NomeEquip, Ativo_inativoEquip, ValorEquips, DecricaoEquip, EtiquetaEquips, id_colab, id_marcaEquip });
            EquipsSelecionados.Location = new Point(16, 531);
            EquipsSelecionados.Name = "EquipsSelecionados";
            EquipsSelecionados.ReadOnly = true;
            EquipsSelecionados.RowHeadersWidth = 62;
            EquipsSelecionados.RowTemplate.Height = 33;
            EquipsSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EquipsSelecionados.Size = new Size(665, 332);
            EquipsSelecionados.TabIndex = 1;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.DarkGreen;
            btn_limpar.Dock = DockStyle.Left;
            btn_limpar.ForeColor = Color.White;
            btn_limpar.Location = new Point(9, 10);
            btn_limpar.Margin = new Padding(4, 5, 4, 5);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(197, 73);
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
            btnCadColab.Location = new Point(638, 10);
            btnCadColab.Margin = new Padding(4, 5, 4, 5);
            btnCadColab.Name = "btnCadColab";
            btnCadColab.Size = new Size(197, 73);
            btnCadColab.TabIndex = 3;
            btnCadColab.Text = "Associar";
            btnCadColab.UseVisualStyleBackColor = false;
            btnCadColab.Click += btnCadColab_Click;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btnCadColab);
            FotterCadColab.Controls.Add(btn_limpar);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 887);
            FotterCadColab.Margin = new Padding(4, 5, 4, 5);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(9, 10, 9, 10);
            FotterCadColab.Size = new Size(844, 93);
            FotterCadColab.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 65);
            panel1.TabIndex = 17;
            // 
            // btn_voltar
            // 
            btn_voltar.AutoSize = true;
            btn_voltar.BackColor = Color.White;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.ForeColor = Color.DimGray;
            btn_voltar.Image = Properties.Resources.seta_esquerda;
            btn_voltar.Location = new Point(16, 11);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(46, 44);
            btn_voltar.TabIndex = 1;
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 32);
            label1.TabIndex = 0;
            label1.Text = "Equipamentos disponiveis";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(396, 201);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(176, 31);
            txtPesquisar.TabIndex = 18;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(582, 197);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(183, 34);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "Pesquisar por nome";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 191);
            label2.Name = "label2";
            label2.Size = new Size(329, 38);
            label2.TabIndex = 20;
            label2.Text = "Selecionar equipamentos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 490);
            label3.Name = "label3";
            label3.Size = new Size(359, 38);
            label3.TabIndex = 21;
            label3.Text = "Equipamentos selecionados";
            // 
            // ID_equipamento
            // 
            ID_equipamento.DataPropertyName = "ID_equipamento";
            ID_equipamento.HeaderText = "ID";
            ID_equipamento.MinimumWidth = 8;
            ID_equipamento.Name = "ID_equipamento";
            ID_equipamento.ReadOnly = true;
            ID_equipamento.Width = 150;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // Ativo_inativo
            // 
            Ativo_inativo.DataPropertyName = "Ativo_inativo";
            Ativo_inativo.HeaderText = "Ativo";
            Ativo_inativo.MinimumWidth = 8;
            Ativo_inativo.Name = "Ativo_inativo";
            Ativo_inativo.ReadOnly = true;
            Ativo_inativo.Visible = false;
            Ativo_inativo.Width = 150;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 8;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Visible = false;
            Valor.Width = 150;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 8;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 150;
            // 
            // Etiqueta_identificacao
            // 
            Etiqueta_identificacao.DataPropertyName = "Etiqueta";
            Etiqueta_identificacao.HeaderText = "Etiqueta";
            Etiqueta_identificacao.MinimumWidth = 8;
            Etiqueta_identificacao.Name = "Etiqueta_identificacao";
            Etiqueta_identificacao.ReadOnly = true;
            Etiqueta_identificacao.Width = 150;
            // 
            // id_colaborador
            // 
            id_colaborador.DataPropertyName = "id_colaborador";
            id_colaborador.HeaderText = "id_colaborador";
            id_colaborador.MinimumWidth = 8;
            id_colaborador.Name = "id_colaborador";
            id_colaborador.ReadOnly = true;
            id_colaborador.Visible = false;
            id_colaborador.Width = 150;
            // 
            // id_marca
            // 
            id_marca.DataPropertyName = "id_marca";
            id_marca.HeaderText = "id_marca";
            id_marca.MinimumWidth = 8;
            id_marca.Name = "id_marca";
            id_marca.ReadOnly = true;
            id_marca.Visible = false;
            id_marca.Width = 150;
            // 
            // id_setor
            // 
            id_setor.DataPropertyName = "id_status";
            id_setor.HeaderText = "id_setor";
            id_setor.MinimumWidth = 8;
            id_setor.Name = "id_setor";
            id_setor.ReadOnly = true;
            id_setor.Visible = false;
            id_setor.Width = 150;
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
            // ID_select
            // 
            ID_select.DataPropertyName = "ID_equipamento";
            ID_select.HeaderText = "ID";
            ID_select.MinimumWidth = 8;
            ID_select.Name = "ID_select";
            ID_select.ReadOnly = true;
            ID_select.Width = 150;
            // 
            // NomeEquip
            // 
            NomeEquip.DataPropertyName = "Nome";
            NomeEquip.HeaderText = "Nome";
            NomeEquip.MinimumWidth = 8;
            NomeEquip.Name = "NomeEquip";
            NomeEquip.ReadOnly = true;
            NomeEquip.Width = 150;
            // 
            // Ativo_inativoEquip
            // 
            Ativo_inativoEquip.HeaderText = "Ativo";
            Ativo_inativoEquip.MinimumWidth = 8;
            Ativo_inativoEquip.Name = "Ativo_inativoEquip";
            Ativo_inativoEquip.ReadOnly = true;
            Ativo_inativoEquip.Visible = false;
            Ativo_inativoEquip.Width = 150;
            // 
            // ValorEquips
            // 
            ValorEquips.DataPropertyName = "Valor";
            ValorEquips.HeaderText = "Valor";
            ValorEquips.MinimumWidth = 8;
            ValorEquips.Name = "ValorEquips";
            ValorEquips.ReadOnly = true;
            ValorEquips.Visible = false;
            ValorEquips.Width = 150;
            // 
            // DecricaoEquip
            // 
            DecricaoEquip.DataPropertyName = "Descricao";
            DecricaoEquip.HeaderText = "Descrição";
            DecricaoEquip.MinimumWidth = 8;
            DecricaoEquip.Name = "DecricaoEquip";
            DecricaoEquip.ReadOnly = true;
            DecricaoEquip.Width = 150;
            // 
            // EtiquetaEquips
            // 
            EtiquetaEquips.DataPropertyName = "Etiqueta";
            EtiquetaEquips.HeaderText = "Etiqueta";
            EtiquetaEquips.MinimumWidth = 8;
            EtiquetaEquips.Name = "EtiquetaEquips";
            EtiquetaEquips.ReadOnly = true;
            EtiquetaEquips.Width = 150;
            // 
            // id_colab
            // 
            id_colab.DataPropertyName = "id_colaborador";
            id_colab.HeaderText = "id_colaborador";
            id_colab.MinimumWidth = 8;
            id_colab.Name = "id_colab";
            id_colab.ReadOnly = true;
            id_colab.Visible = false;
            id_colab.Width = 150;
            // 
            // id_marcaEquip
            // 
            id_marcaEquip.DataPropertyName = "id_marca";
            id_marcaEquip.HeaderText = "id_marca";
            id_marcaEquip.MinimumWidth = 8;
            id_marcaEquip.Name = "id_marcaEquip";
            id_marcaEquip.ReadOnly = true;
            id_marcaEquip.Visible = false;
            id_marcaEquip.Width = 150;
            // 
            // SelectEquips
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 980);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(panel1);
            Controls.Add(FotterCadColab);
            Controls.Add(EquipsSelecionados);
            Controls.Add(MostrarEquipsDisponiveis);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            PerformLayout();
        }

        #endregion

        private DataGridView MostrarEquipsDisponiveis;
        private DataGridView EquipsSelecionados;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome_equip;
        private DataGridViewTextBoxColumn ValorEquip;
        private DataGridViewTextBoxColumn DescricaoEquip;
        private DataGridViewTextBoxColumn EtiquetaEquip;
        private Button btn_limpar;
        private Button btnCadColab;
        private Panel FotterCadColab;
        private Panel panel1;
        private Label label1;
        private Button btn_voltar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn ID_equipamento;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Etiqueta_identificacao;
        private DataGridViewTextBoxColumn id_colaborador;
        private DataGridViewTextBoxColumn id_marca;
        private DataGridViewTextBoxColumn id_setor;
        private DataGridViewTextBoxColumn ValorNumerico;
        private DataGridViewTextBoxColumn ID_select;
        private DataGridViewTextBoxColumn NomeEquip;
        private DataGridViewTextBoxColumn Ativo_inativoEquip;
        private DataGridViewTextBoxColumn ValorEquips;
        private DataGridViewTextBoxColumn DecricaoEquip;
        private DataGridViewTextBoxColumn EtiquetaEquips;
        private DataGridViewTextBoxColumn id_colab;
        private DataGridViewTextBoxColumn id_marcaEquip;
    }
}