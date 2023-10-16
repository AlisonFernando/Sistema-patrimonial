namespace UI
{
    partial class TelaManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaManutencao));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            btnLimpar = new Button();
            btnVoltar = new Button();
            label3 = new Label();
            MostrarEquipsFinalizados = new DataGridView();
            label4 = new Label();
            txtPesquisarFinalizado = new TextBox();
            btnPesquisarFinalizado = new Button();
            btnPesquisarEmAndamento = new Button();
            txtPesquisarEmAndamento = new TextBox();
            btnPesquisarNaoFinalizado = new Button();
            txtPesquisarNaoFinalizados = new TextBox();
            MostrarEquipsAndamento = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            MostrarEquipsNaoFinalizados = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsFinalizados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsAndamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsNaoFinalizados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 245);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 21);
            label1.TabIndex = 1;
            label1.Text = "Equipamentos com manutenção em andamento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 50);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(193, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(299, 28);
            label2.TabIndex = 0;
            label2.Text = "Manutenção de equipamentos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLimpar);
            panel2.Controls.Add(btnVoltar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 580);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6);
            panel2.Size = new Size(718, 50);
            panel2.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.Dock = DockStyle.Right;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(567, 6);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 38);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Dock = DockStyle.Left;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(6, 6);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 38);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(342, 21);
            label3.TabIndex = 5;
            label3.Text = "Equipamentos com manutenção em andamento";
            // 
            // MostrarEquipsFinalizados
            // 
            MostrarEquipsFinalizados.AllowUserToAddRows = false;
            MostrarEquipsFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsFinalizados.Columns.AddRange(new DataGridViewColumn[] { Nome });
            MostrarEquipsFinalizados.Location = new Point(25, 100);
            MostrarEquipsFinalizados.Margin = new Padding(2);
            MostrarEquipsFinalizados.Name = "MostrarEquipsFinalizados";
            MostrarEquipsFinalizados.RowHeadersWidth = 62;
            MostrarEquipsFinalizados.RowTemplate.Height = 33;
            MostrarEquipsFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsFinalizados.ShowRowErrors = false;
            MostrarEquipsFinalizados.Size = new Size(402, 135);
            MostrarEquipsFinalizados.TabIndex = 4;
            MostrarEquipsFinalizados.CellMouseDoubleClick += MostrarEquipsFinalizados_CellMouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 416);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(217, 21);
            label4.TabIndex = 7;
            label4.Text = "Equipamentos não finalizados";
            // 
            // txtPesquisarFinalizado
            // 
            txtPesquisarFinalizado.Location = new Point(435, 100);
            txtPesquisarFinalizado.Margin = new Padding(2);
            txtPesquisarFinalizado.Name = "txtPesquisarFinalizado";
            txtPesquisarFinalizado.Size = new Size(187, 23);
            txtPesquisarFinalizado.TabIndex = 8;
            // 
            // btnPesquisarFinalizado
            // 
            btnPesquisarFinalizado.BackColor = Color.DarkGreen;
            btnPesquisarFinalizado.ForeColor = Color.White;
            btnPesquisarFinalizado.Location = new Point(624, 100);
            btnPesquisarFinalizado.Margin = new Padding(2);
            btnPesquisarFinalizado.Name = "btnPesquisarFinalizado";
            btnPesquisarFinalizado.Size = new Size(78, 20);
            btnPesquisarFinalizado.TabIndex = 9;
            btnPesquisarFinalizado.Text = "Pesquisar";
            btnPesquisarFinalizado.TextAlign = ContentAlignment.BottomCenter;
            btnPesquisarFinalizado.UseVisualStyleBackColor = false;
            btnPesquisarFinalizado.Click += btnPesquisarFinalizado_Click;
            // 
            // btnPesquisarEmAndamento
            // 
            btnPesquisarEmAndamento.BackColor = Color.Yellow;
            btnPesquisarEmAndamento.ForeColor = Color.Black;
            btnPesquisarEmAndamento.Location = new Point(624, 273);
            btnPesquisarEmAndamento.Margin = new Padding(2);
            btnPesquisarEmAndamento.Name = "btnPesquisarEmAndamento";
            btnPesquisarEmAndamento.Size = new Size(78, 20);
            btnPesquisarEmAndamento.TabIndex = 11;
            btnPesquisarEmAndamento.Text = "Pesquisar";
            btnPesquisarEmAndamento.UseVisualStyleBackColor = false;
            btnPesquisarEmAndamento.Click += btnPesquisarEmAndamento_Click;
            // 
            // txtPesquisarEmAndamento
            // 
            txtPesquisarEmAndamento.Location = new Point(435, 273);
            txtPesquisarEmAndamento.Margin = new Padding(2);
            txtPesquisarEmAndamento.Name = "txtPesquisarEmAndamento";
            txtPesquisarEmAndamento.Size = new Size(187, 23);
            txtPesquisarEmAndamento.TabIndex = 10;
            // 
            // btnPesquisarNaoFinalizado
            // 
            btnPesquisarNaoFinalizado.BackColor = Color.DarkGreen;
            btnPesquisarNaoFinalizado.ForeColor = Color.Black;
            btnPesquisarNaoFinalizado.Location = new Point(624, 443);
            btnPesquisarNaoFinalizado.Margin = new Padding(2);
            btnPesquisarNaoFinalizado.Name = "btnPesquisarNaoFinalizado";
            btnPesquisarNaoFinalizado.Size = new Size(78, 20);
            btnPesquisarNaoFinalizado.TabIndex = 13;
            btnPesquisarNaoFinalizado.Text = "Pesquisar";
            btnPesquisarNaoFinalizado.UseVisualStyleBackColor = false;
            btnPesquisarNaoFinalizado.Click += btnPesquisarNaoFinalizado_Click;
            // 
            // txtPesquisarNaoFinalizados
            // 
            txtPesquisarNaoFinalizados.Location = new Point(435, 443);
            txtPesquisarNaoFinalizados.Margin = new Padding(2);
            txtPesquisarNaoFinalizados.Name = "txtPesquisarNaoFinalizados";
            txtPesquisarNaoFinalizados.Size = new Size(187, 23);
            txtPesquisarNaoFinalizados.TabIndex = 12;
            // 
            // MostrarEquipsAndamento
            // 
            MostrarEquipsAndamento.AllowUserToAddRows = false;
            MostrarEquipsAndamento.AllowUserToDeleteRows = false;
            MostrarEquipsAndamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsAndamento.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            MostrarEquipsAndamento.Location = new Point(25, 273);
            MostrarEquipsAndamento.Margin = new Padding(2);
            MostrarEquipsAndamento.Name = "MostrarEquipsAndamento";
            MostrarEquipsAndamento.ReadOnly = true;
            MostrarEquipsAndamento.RowHeadersWidth = 62;
            MostrarEquipsAndamento.RowTemplate.Height = 33;
            MostrarEquipsAndamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsAndamento.ShowRowErrors = false;
            MostrarEquipsAndamento.Size = new Size(402, 135);
            MostrarEquipsAndamento.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id_chamado";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "id_usuario";
            dataGridViewTextBoxColumn3.HeaderText = "Técnico responsável";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "id_status";
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "id_equipamento";
            dataGridViewTextBoxColumn5.HeaderText = "Equipamento";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // MostrarEquipsNaoFinalizados
            // 
            MostrarEquipsNaoFinalizados.AllowUserToAddRows = false;
            MostrarEquipsNaoFinalizados.AllowUserToDeleteRows = false;
            MostrarEquipsNaoFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsNaoFinalizados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            MostrarEquipsNaoFinalizados.Location = new Point(25, 443);
            MostrarEquipsNaoFinalizados.Margin = new Padding(2);
            MostrarEquipsNaoFinalizados.Name = "MostrarEquipsNaoFinalizados";
            MostrarEquipsNaoFinalizados.ReadOnly = true;
            MostrarEquipsNaoFinalizados.RowHeadersWidth = 62;
            MostrarEquipsNaoFinalizados.RowTemplate.Height = 33;
            MostrarEquipsNaoFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsNaoFinalizados.ShowRowErrors = false;
            MostrarEquipsNaoFinalizados.Size = new Size(402, 135);
            MostrarEquipsNaoFinalizados.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "id_chamado";
            dataGridViewTextBoxColumn6.HeaderText = "ID";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "descricao";
            dataGridViewTextBoxColumn7.HeaderText = "Descrição";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "id_usuario";
            dataGridViewTextBoxColumn8.HeaderText = "Técnico responsável";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "id_status";
            dataGridViewTextBoxColumn9.HeaderText = "Status";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "id_equipamento";
            dataGridViewTextBoxColumn10.HeaderText = "Equipamento";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome_equipamento";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // TelaManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 630);
            Controls.Add(MostrarEquipsNaoFinalizados);
            Controls.Add(MostrarEquipsAndamento);
            Controls.Add(btnPesquisarNaoFinalizado);
            Controls.Add(txtPesquisarNaoFinalizados);
            Controls.Add(btnPesquisarEmAndamento);
            Controls.Add(txtPesquisarEmAndamento);
            Controls.Add(btnPesquisarFinalizado);
            Controls.Add(txtPesquisarFinalizado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MostrarEquipsFinalizados);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "TelaManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaManutencao";
            Load += TelaManutencao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsFinalizados).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsAndamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsNaoFinalizados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btnVoltar;
        private Label label3;
        private DataGridView MostrarEquipsFinalizados;
        private Label label4;
        private TextBox txtPesquisarFinalizado;
        private Button btnPesquisarFinalizado;
        private Button btnPesquisarEmAndamento;
        private TextBox txtPesquisarEmAndamento;
        private Button btnPesquisarNaoFinalizado;
        private TextBox txtPesquisarNaoFinalizados;
        private Button btnLimpar;
        private DataGridView MostrarEquipsAndamento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView MostrarEquipsNaoFinalizados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Nome;
    }
}