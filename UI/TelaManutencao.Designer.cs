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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaManutencao));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            btnLimpar = new Button();
            btnVoltar = new Button();
            label3 = new Label();
            MostrarEquipsFinalizados = new DataGridView();
            id_chamado = new DataGridViewTextBoxColumn();
            id_equipamento = new DataGridViewTextBoxColumn();
            Equipamento = new DataGridViewTextBoxColumn();
            id_Statusss = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            DataChamado = new DataGridViewTextBoxColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            DataErradass = new DataGridViewTextBoxColumn();
            class1BindingSource = new BindingSource(components);
            label4 = new Label();
            txtPesquisarFinalizado = new TextBox();
            btnPesquisarFinalizado = new Button();
            btnPesquisarEmAndamento = new Button();
            txtPesquisarEmAndamento = new TextBox();
            btnPesquisarNaoFinalizado = new Button();
            txtPesquisarNaoFinalizados = new TextBox();
            MostrarEquipsAndamento = new DataGridView();
            MostrarEquipsNaoFinalizados = new DataGridView();
            id_chamadou = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            id_usuarios = new DataGridViewTextBoxColumn();
            DataErrada = new DataGridViewTextBoxColumn();
            id_equipamentos = new DataGridViewTextBoxColumn();
            id_statuss = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            id_chamadow = new DataGridViewTextBoxColumn();
            DataHora = new DataGridViewTextBoxColumn();
            id_usuarioAndamento = new DataGridViewTextBoxColumn();
            id_equipamentoAndamento = new DataGridViewTextBoxColumn();
            id_status = new DataGridViewTextBoxColumn();
            DataErradas = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsFinalizados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsAndamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsNaoFinalizados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 408);
            label1.Name = "label1";
            label1.Size = new Size(529, 32);
            label1.TabIndex = 1;
            label1.Text = "Equipamentos com manutenção em andamento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 83);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(412, 24);
            label2.Name = "label2";
            label2.Size = new Size(445, 41);
            label2.TabIndex = 0;
            label2.Text = "Manutenção de equipamentos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLimpar);
            panel2.Controls.Add(btnVoltar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 967);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(1236, 83);
            panel2.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.Dock = DockStyle.Right;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(1020, 10);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(207, 63);
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
            btnVoltar.Location = new Point(9, 10);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(207, 63);
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
            label3.Location = new Point(36, 120);
            label3.Name = "label3";
            label3.Size = new Size(488, 32);
            label3.TabIndex = 5;
            label3.Text = "Equipamentos com manutenções finalizadas\r\n";
            // 
            // MostrarEquipsFinalizados
            // 
            MostrarEquipsFinalizados.AllowUserToAddRows = false;
            MostrarEquipsFinalizados.AllowUserToDeleteRows = false;
            MostrarEquipsFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsFinalizados.Columns.AddRange(new DataGridViewColumn[] { id_chamado, id_equipamento, Equipamento, id_Statusss, descricao, Usuario, DataChamado, id_usuario, DataErradass });
            MostrarEquipsFinalizados.Location = new Point(36, 167);
            MostrarEquipsFinalizados.Name = "MostrarEquipsFinalizados";
            MostrarEquipsFinalizados.ReadOnly = true;
            MostrarEquipsFinalizados.RowHeadersWidth = 62;
            MostrarEquipsFinalizados.RowTemplate.Height = 33;
            MostrarEquipsFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsFinalizados.ShowRowErrors = false;
            MostrarEquipsFinalizados.Size = new Size(664, 225);
            MostrarEquipsFinalizados.TabIndex = 4;
            MostrarEquipsFinalizados.CellMouseDoubleClick += MostrarEquipsFinalizados_CellMouseDoubleClick;
            // 
            // id_chamado
            // 
            id_chamado.DataPropertyName = "id_chamado";
            id_chamado.HeaderText = "id_chamado";
            id_chamado.MinimumWidth = 8;
            id_chamado.Name = "id_chamado";
            id_chamado.ReadOnly = true;
            id_chamado.Width = 150;
            // 
            // id_equipamento
            // 
            id_equipamento.DataPropertyName = "id_equipamento";
            id_equipamento.HeaderText = "id_equipamento";
            id_equipamento.MinimumWidth = 8;
            id_equipamento.Name = "id_equipamento";
            id_equipamento.ReadOnly = true;
            id_equipamento.Visible = false;
            id_equipamento.Width = 150;
            // 
            // Equipamento
            // 
            Equipamento.DataPropertyName = "NomeEquipamento";
            Equipamento.HeaderText = "Equipamento";
            Equipamento.MinimumWidth = 8;
            Equipamento.Name = "Equipamento";
            Equipamento.ReadOnly = true;
            Equipamento.Width = 150;
            // 
            // id_Statusss
            // 
            id_Statusss.DataPropertyName = "id_status";
            id_Statusss.HeaderText = "id_status";
            id_Statusss.MinimumWidth = 8;
            id_Statusss.Name = "id_Statusss";
            id_Statusss.ReadOnly = true;
            id_Statusss.Visible = false;
            id_Statusss.Width = 150;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "descricao";
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 8;
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            descricao.Width = 150;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "NomeUsuario";
            Usuario.HeaderText = "Técnico";
            Usuario.MinimumWidth = 8;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 150;
            // 
            // DataChamado
            // 
            DataChamado.DataPropertyName = "DataChamado";
            DataChamado.HeaderText = "Data";
            DataChamado.MinimumWidth = 8;
            DataChamado.Name = "DataChamado";
            DataChamado.ReadOnly = true;
            DataChamado.Visible = false;
            DataChamado.Width = 150;
            // 
            // id_usuario
            // 
            id_usuario.DataPropertyName = "id_usuario";
            id_usuario.HeaderText = "id_usuario";
            id_usuario.MinimumWidth = 8;
            id_usuario.Name = "id_usuario";
            id_usuario.ReadOnly = true;
            id_usuario.Visible = false;
            id_usuario.Width = 150;
            // 
            // DataErradass
            // 
            DataErradass.DataPropertyName = "DataChamado";
            DataErradass.HeaderText = "Data";
            DataErradass.MinimumWidth = 8;
            DataErradass.Name = "DataErradass";
            DataErradass.ReadOnly = true;
            DataErradass.Width = 150;
            // 
            // class1BindingSource
            // 
            class1BindingSource.DataSource = typeof(sis_patrimonial.Class1);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 693);
            label4.Name = "label4";
            label4.Size = new Size(333, 32);
            label4.TabIndex = 7;
            label4.Text = "Equipamentos não finalizados";
            // 
            // txtPesquisarFinalizado
            // 
            txtPesquisarFinalizado.Location = new Point(720, 167);
            txtPesquisarFinalizado.Name = "txtPesquisarFinalizado";
            txtPesquisarFinalizado.Size = new Size(265, 31);
            txtPesquisarFinalizado.TabIndex = 8;
            // 
            // btnPesquisarFinalizado
            // 
            btnPesquisarFinalizado.BackColor = Color.DarkGreen;
            btnPesquisarFinalizado.ForeColor = Color.White;
            btnPesquisarFinalizado.Location = new Point(990, 167);
            btnPesquisarFinalizado.Name = "btnPesquisarFinalizado";
            btnPesquisarFinalizado.Size = new Size(111, 33);
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
            btnPesquisarEmAndamento.Location = new Point(990, 455);
            btnPesquisarEmAndamento.Name = "btnPesquisarEmAndamento";
            btnPesquisarEmAndamento.Size = new Size(111, 33);
            btnPesquisarEmAndamento.TabIndex = 11;
            btnPesquisarEmAndamento.Text = "Pesquisar";
            btnPesquisarEmAndamento.UseVisualStyleBackColor = false;
            btnPesquisarEmAndamento.Click += btnPesquisarEmAndamento_Click;
            // 
            // txtPesquisarEmAndamento
            // 
            txtPesquisarEmAndamento.Location = new Point(720, 455);
            txtPesquisarEmAndamento.Name = "txtPesquisarEmAndamento";
            txtPesquisarEmAndamento.Size = new Size(265, 31);
            txtPesquisarEmAndamento.TabIndex = 10;
            // 
            // btnPesquisarNaoFinalizado
            // 
            btnPesquisarNaoFinalizado.BackColor = Color.Red;
            btnPesquisarNaoFinalizado.ForeColor = Color.Black;
            btnPesquisarNaoFinalizado.Location = new Point(990, 746);
            btnPesquisarNaoFinalizado.Name = "btnPesquisarNaoFinalizado";
            btnPesquisarNaoFinalizado.Size = new Size(111, 33);
            btnPesquisarNaoFinalizado.TabIndex = 13;
            btnPesquisarNaoFinalizado.Text = "Pesquisar";
            btnPesquisarNaoFinalizado.UseVisualStyleBackColor = false;
            btnPesquisarNaoFinalizado.Click += btnPesquisarNaoFinalizado_Click;
            // 
            // txtPesquisarNaoFinalizados
            // 
            txtPesquisarNaoFinalizados.Location = new Point(720, 746);
            txtPesquisarNaoFinalizados.Name = "txtPesquisarNaoFinalizados";
            txtPesquisarNaoFinalizados.Size = new Size(265, 31);
            txtPesquisarNaoFinalizados.TabIndex = 12;
            // 
            // MostrarEquipsAndamento
            // 
            MostrarEquipsAndamento.AllowUserToAddRows = false;
            MostrarEquipsAndamento.AllowUserToDeleteRows = false;
            MostrarEquipsAndamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsAndamento.Columns.AddRange(new DataGridViewColumn[] { Column1, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, id_chamadow, DataHora, id_usuarioAndamento, id_equipamentoAndamento, id_status, DataErradas });
            MostrarEquipsAndamento.Location = new Point(36, 455);
            MostrarEquipsAndamento.Name = "MostrarEquipsAndamento";
            MostrarEquipsAndamento.ReadOnly = true;
            MostrarEquipsAndamento.RowHeadersWidth = 62;
            MostrarEquipsAndamento.RowTemplate.Height = 33;
            MostrarEquipsAndamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsAndamento.ShowRowErrors = false;
            MostrarEquipsAndamento.Size = new Size(664, 225);
            MostrarEquipsAndamento.TabIndex = 14;
            MostrarEquipsAndamento.CellMouseDoubleClick += MostrarEquipsAndamento_CellMouseDoubleClick;
            // 
            // MostrarEquipsNaoFinalizados
            // 
            MostrarEquipsNaoFinalizados.AllowUserToAddRows = false;
            MostrarEquipsNaoFinalizados.AllowUserToDeleteRows = false;
            MostrarEquipsNaoFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsNaoFinalizados.Columns.AddRange(new DataGridViewColumn[] { id_chamadou, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, Data, id_usuarios, DataErrada, id_equipamentos, id_statuss });
            MostrarEquipsNaoFinalizados.Location = new Point(36, 746);
            MostrarEquipsNaoFinalizados.Name = "MostrarEquipsNaoFinalizados";
            MostrarEquipsNaoFinalizados.ReadOnly = true;
            MostrarEquipsNaoFinalizados.RowHeadersWidth = 62;
            MostrarEquipsNaoFinalizados.RowTemplate.Height = 33;
            MostrarEquipsNaoFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsNaoFinalizados.ShowRowErrors = false;
            MostrarEquipsNaoFinalizados.Size = new Size(664, 225);
            MostrarEquipsNaoFinalizados.TabIndex = 15;
            MostrarEquipsNaoFinalizados.CellMouseDoubleClick += MostrarEquipsNaoFinalizados_CellMouseDoubleClick;
            // 
            // id_chamadou
            // 
            id_chamadou.DataPropertyName = "id_chamado";
            id_chamadou.HeaderText = "id_chamado";
            id_chamadou.MinimumWidth = 8;
            id_chamadou.Name = "id_chamadou";
            id_chamadou.ReadOnly = true;
            id_chamadou.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "NomeEquipamento";
            dataGridViewTextBoxColumn10.HeaderText = "Equipamento";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
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
            dataGridViewTextBoxColumn8.DataPropertyName = "NomeUsuario";
            dataGridViewTextBoxColumn8.HeaderText = "Técnico";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // Data
            // 
            Data.DataPropertyName = "DataChamado";
            Data.HeaderText = "DataHora";
            Data.MinimumWidth = 8;
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Visible = false;
            Data.Width = 150;
            // 
            // id_usuarios
            // 
            id_usuarios.DataPropertyName = "id_usuario";
            id_usuarios.HeaderText = "id-usuario";
            id_usuarios.MinimumWidth = 8;
            id_usuarios.Name = "id_usuarios";
            id_usuarios.ReadOnly = true;
            id_usuarios.Visible = false;
            id_usuarios.Width = 150;
            // 
            // DataErrada
            // 
            DataErrada.DataPropertyName = "DataChamado";
            DataErrada.HeaderText = "Data";
            DataErrada.MinimumWidth = 8;
            DataErrada.Name = "DataErrada";
            DataErrada.ReadOnly = true;
            DataErrada.Width = 150;
            // 
            // id_equipamentos
            // 
            id_equipamentos.DataPropertyName = "id_equipamento";
            id_equipamentos.HeaderText = "id_equipamentos";
            id_equipamentos.MinimumWidth = 8;
            id_equipamentos.Name = "id_equipamentos";
            id_equipamentos.ReadOnly = true;
            id_equipamentos.Visible = false;
            id_equipamentos.Width = 150;
            // 
            // id_statuss
            // 
            id_statuss.DataPropertyName = "id_status";
            id_statuss.HeaderText = "id_status";
            id_statuss.MinimumWidth = 8;
            id_statuss.Name = "id_statuss";
            id_statuss.ReadOnly = true;
            id_statuss.Visible = false;
            id_statuss.Width = 150;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id_chamado";
            Column1.HeaderText = "id_chamado";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "NomeEquipamento";
            dataGridViewTextBoxColumn5.HeaderText = "Equipamento";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
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
            dataGridViewTextBoxColumn3.DataPropertyName = "NomeUsuario";
            dataGridViewTextBoxColumn3.HeaderText = "Técnico";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // id_chamadow
            // 
            id_chamadow.DataPropertyName = "m.id_chamado";
            id_chamadow.HeaderText = "id_chamado";
            id_chamadow.MinimumWidth = 8;
            id_chamadow.Name = "id_chamadow";
            id_chamadow.ReadOnly = true;
            id_chamadow.Visible = false;
            id_chamadow.Width = 150;
            // 
            // DataHora
            // 
            DataHora.DataPropertyName = "Data_hora_do_chamado";
            DataHora.HeaderText = "DataHora";
            DataHora.MinimumWidth = 8;
            DataHora.Name = "DataHora";
            DataHora.ReadOnly = true;
            DataHora.Visible = false;
            DataHora.Width = 150;
            // 
            // id_usuarioAndamento
            // 
            id_usuarioAndamento.DataPropertyName = "id_usuario";
            id_usuarioAndamento.HeaderText = "id_usuario";
            id_usuarioAndamento.MinimumWidth = 8;
            id_usuarioAndamento.Name = "id_usuarioAndamento";
            id_usuarioAndamento.ReadOnly = true;
            id_usuarioAndamento.Visible = false;
            id_usuarioAndamento.Width = 150;
            // 
            // id_equipamentoAndamento
            // 
            id_equipamentoAndamento.DataPropertyName = "id_equipamento";
            id_equipamentoAndamento.HeaderText = "id_equipamento";
            id_equipamentoAndamento.MinimumWidth = 8;
            id_equipamentoAndamento.Name = "id_equipamentoAndamento";
            id_equipamentoAndamento.ReadOnly = true;
            id_equipamentoAndamento.Visible = false;
            id_equipamentoAndamento.Width = 150;
            // 
            // id_status
            // 
            id_status.DataPropertyName = "id_status";
            id_status.HeaderText = "id_satatus";
            id_status.MinimumWidth = 8;
            id_status.Name = "id_status";
            id_status.ReadOnly = true;
            id_status.Visible = false;
            id_status.Width = 150;
            // 
            // DataErradas
            // 
            DataErradas.DataPropertyName = "DataChamado";
            DataErradas.HeaderText = "Data";
            DataErradas.MinimumWidth = 8;
            DataErradas.Name = "DataErradas";
            DataErradas.ReadOnly = true;
            DataErradas.Width = 150;
            // 
            // TelaManutencao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 1050);
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
            MaximizeBox = false;
            Name = "TelaManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaManutencao";
            Activated += TelaManutencao_Activated;
            Load += TelaManutencao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsFinalizados).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).EndInit();
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
        private DataGridView MostrarEquipsNaoFinalizados;
        private BindingSource class1BindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn id_chamadow;
        private DataGridViewTextBoxColumn DataHora;
        private DataGridViewTextBoxColumn id_chama;
        private DataGridViewTextBoxColumn id_usuarioAndamento;
        private DataGridViewTextBoxColumn id_equipamentoAndamento;
        private DataGridViewTextBoxColumn id_status;
        private DataGridViewTextBoxColumn DataErradas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn id_usuarios;
        private DataGridViewTextBoxColumn DataErrada;
        private DataGridViewTextBoxColumn id_chamadou;
        private DataGridViewTextBoxColumn id_equipamentos;
        private DataGridViewTextBoxColumn id_statuss;
        private DataGridViewTextBoxColumn id_chamado;
        private DataGridViewTextBoxColumn id_equipamento;
        private DataGridViewTextBoxColumn Equipamento;
        private DataGridViewTextBoxColumn id_Statusss;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn DataChamado;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn DataErradass;
        private DataGridViewTextBoxColumn Column1;
    }
}