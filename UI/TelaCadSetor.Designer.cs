namespace UI
{
    partial class TelaCadSetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadSetor));
            label1 = new Label();
            btn_voltar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtID = new TextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            MostrarSetores = new DataGridView();
            ID_setor = new DataGridViewTextBoxColumn();
            Nome_setor = new DataGridViewTextBoxColumn();
            Ativo_inativo = new DataGridViewTextBoxColumn();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            btnLimpar = new Button();
            btnDesativar = new Button();
            MostrarSetoresDesativados = new DataGridView();
            btnAtivarSetor = new Button();
            btnLimparDesativado = new Button();
            label2 = new Label();
            NomeEquip = new Label();
            checkAtivo = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            ID_SetorDesativado = new DataGridViewTextBoxColumn();
            SetorNome = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarSetores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSetoresDesativados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(402, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar setor";
            // 
            // btn_voltar
            // 
            btn_voltar.AutoSize = true;
            btn_voltar.BackColor = Color.White;
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.ForeColor = Color.DimGray;
            btn_voltar.Image = Properties.Resources.seta_esquerda;
            btn_voltar.Location = new Point(14, 22);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(46, 44);
            btn_voltar.TabIndex = 1;
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
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
            panel1.Size = new Size(1014, 83);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnCadastrar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 646);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(1014, 83);
            panel2.TabIndex = 19;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(345, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(117, 31);
            txtID.TabIndex = 10;
            txtID.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGreen;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Dock = DockStyle.Left;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(9, 10);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(6);
            btnCancelar.Size = new Size(207, 63);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Dock = DockStyle.Right;
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(798, 10);
            btnCadastrar.Margin = new Padding(4, 5, 4, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Padding = new Padding(6);
            btnCadastrar.Size = new Size(207, 63);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Aplicar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // MostrarSetores
            // 
            MostrarSetores.AllowUserToAddRows = false;
            MostrarSetores.AllowUserToDeleteRows = false;
            MostrarSetores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarSetores.Columns.AddRange(new DataGridViewColumn[] { ID_setor, Nome_setor, Ativo_inativo });
            MostrarSetores.Location = new Point(64, 320);
            MostrarSetores.Name = "MostrarSetores";
            MostrarSetores.ReadOnly = true;
            MostrarSetores.RowHeadersWidth = 62;
            MostrarSetores.RowTemplate.Height = 33;
            MostrarSetores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarSetores.Size = new Size(396, 225);
            MostrarSetores.TabIndex = 20;
            MostrarSetores.CellMouseDoubleClick += MostrarSetores_CellMouseDoubleClick;
            // 
            // ID_setor
            // 
            ID_setor.DataPropertyName = "ID_setor";
            ID_setor.HeaderText = "ID";
            ID_setor.MinimumWidth = 8;
            ID_setor.Name = "ID_setor";
            ID_setor.ReadOnly = true;
            ID_setor.Width = 80;
            // 
            // Nome_setor
            // 
            Nome_setor.DataPropertyName = "Nome";
            Nome_setor.HeaderText = "Setor";
            Nome_setor.MinimumWidth = 8;
            Nome_setor.Name = "Nome_setor";
            Nome_setor.ReadOnly = true;
            Nome_setor.Width = 250;
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
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(603, 167);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(112, 38);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(355, 171);
            txtPesquisar.MaxLength = 100;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(242, 31);
            txtPesquisar.TabIndex = 22;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(64, 551);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(102, 44);
            btnLimpar.TabIndex = 23;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnDesativar
            // 
            btnDesativar.BackColor = Color.DarkGreen;
            btnDesativar.ForeColor = Color.White;
            btnDesativar.Location = new Point(172, 551);
            btnDesativar.Name = "btnDesativar";
            btnDesativar.Size = new Size(144, 44);
            btnDesativar.TabIndex = 24;
            btnDesativar.Text = "Desativar setor";
            btnDesativar.UseVisualStyleBackColor = false;
            btnDesativar.Click += btnDesativar_Click;
            // 
            // MostrarSetoresDesativados
            // 
            MostrarSetoresDesativados.AllowUserToAddRows = false;
            MostrarSetoresDesativados.AllowUserToDeleteRows = false;
            MostrarSetoresDesativados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarSetoresDesativados.Columns.AddRange(new DataGridViewColumn[] { ID_SetorDesativado, SetorNome, Nome, dataGridViewTextBoxColumn3 });
            MostrarSetoresDesativados.Location = new Point(551, 320);
            MostrarSetoresDesativados.Name = "MostrarSetoresDesativados";
            MostrarSetoresDesativados.ReadOnly = true;
            MostrarSetoresDesativados.RowHeadersWidth = 62;
            MostrarSetoresDesativados.RowTemplate.Height = 33;
            MostrarSetoresDesativados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarSetoresDesativados.Size = new Size(396, 225);
            MostrarSetoresDesativados.TabIndex = 25;
            MostrarSetoresDesativados.CellMouseDoubleClick += MostrarSetoresDesativados_CellMouseDoubleClick;
            // 
            // btnAtivarSetor
            // 
            btnAtivarSetor.BackColor = Color.DarkGreen;
            btnAtivarSetor.ForeColor = Color.White;
            btnAtivarSetor.Location = new Point(669, 551);
            btnAtivarSetor.Name = "btnAtivarSetor";
            btnAtivarSetor.Size = new Size(118, 44);
            btnAtivarSetor.TabIndex = 26;
            btnAtivarSetor.Text = "Ativar setor";
            btnAtivarSetor.UseVisualStyleBackColor = false;
            btnAtivarSetor.Click += btnAtivarSetor_Click;
            // 
            // btnLimparDesativado
            // 
            btnLimparDesativado.BackColor = Color.DarkGreen;
            btnLimparDesativado.ForeColor = Color.White;
            btnLimparDesativado.Location = new Point(551, 551);
            btnLimparDesativado.Name = "btnLimparDesativado";
            btnLimparDesativado.Size = new Size(102, 44);
            btnLimparDesativado.TabIndex = 27;
            btnLimparDesativado.Text = "Limpar";
            btnLimparDesativado.UseVisualStyleBackColor = false;
            btnLimparDesativado.Click += btnLimparDesativado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(355, 143);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 28;
            label2.Text = "*";
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(369, 143);
            NomeEquip.Margin = new Padding(4, 0, 4, 0);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(133, 25);
            NomeEquip.TabIndex = 29;
            NomeEquip.Text = "Nome do setor";
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Location = new Point(355, 208);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(140, 29);
            checkAtivo.TabIndex = 30;
            checkAtivo.Text = "Ativo/inativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 285);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 31;
            label3.Text = "Setores ativos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(551, 285);
            label4.Name = "label4";
            label4.Size = new Size(225, 32);
            label4.TabIndex = 32;
            label4.Text = "Setores desativados";
            // 
            // ID_SetorDesativado
            // 
            ID_SetorDesativado.DataPropertyName = "ID_setor";
            ID_SetorDesativado.HeaderText = "ID";
            ID_SetorDesativado.MinimumWidth = 8;
            ID_SetorDesativado.Name = "ID_SetorDesativado";
            ID_SetorDesativado.ReadOnly = true;
            ID_SetorDesativado.Width = 80;
            // 
            // SetorNome
            // 
            SetorNome.DataPropertyName = "Nome";
            SetorNome.HeaderText = "Setor";
            SetorNome.MinimumWidth = 8;
            SetorNome.Name = "SetorNome";
            SetorNome.ReadOnly = true;
            SetorNome.Width = 250;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Visible = false;
            Nome.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Ativo_inativo";
            dataGridViewTextBoxColumn3.HeaderText = "Ativo_inativo";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Visible = false;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // TelaCadSetor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 729);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkAtivo);
            Controls.Add(NomeEquip);
            Controls.Add(label2);
            Controls.Add(btnLimparDesativado);
            Controls.Add(btnAtivarSetor);
            Controls.Add(MostrarSetoresDesativados);
            Controls.Add(btnDesativar);
            Controls.Add(btnLimpar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(MostrarSetores);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadSetor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar setor";
            Load += TelaCadSetor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarSetores).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSetoresDesativados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_voltar;
        private Panel panel1;
        private Panel panel2;
        private Button btnCadastrar;
        private Button btnCancelar;
        private DataGridView MostrarSetores;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Button btnLimpar;
        private TextBox txtID;
        private Button btnDesativar;
        private DataGridViewTextBoxColumn ID_setor;
        private DataGridViewTextBoxColumn Nome_setor;
        private DataGridViewTextBoxColumn Ativo_inativo;
        private DataGridView MostrarSetoresDesativados;
        private Button btnAtivarSetor;
        private Button btnLimparDesativado;
        private Label label2;
        private Label NomeEquip;
        private CheckBox checkAtivo;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn ID_SetorDesativado;
        private DataGridViewTextBoxColumn SetorNome;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}