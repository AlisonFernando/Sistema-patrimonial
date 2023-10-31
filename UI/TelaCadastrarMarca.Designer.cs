namespace UI
{
    partial class TelaCadastrarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarMarca));
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            txtID = new TextBox();
            button2 = new Button();
            CadastrarMarca = new Button();
            txtMarca = new TextBox();
            NomeEquip = new Label();
            label2 = new Label();
            MostrarMarcasCadastradas = new DataGridView();
            IDMarca = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            AtivoInativo = new DataGridViewTextBoxColumn();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            ID = new DataGridViewTextBoxColumn();
            checkAtivo = new CheckBox();
            btnDesativar = new Button();
            label3 = new Label();
            MostrarMarcasDesativadas = new DataGridView();
            IDMarcaDesativada = new DataGridViewTextBoxColumn();
            MarcaDesativada = new DataGridViewTextBoxColumn();
            ativo_inativo = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnAtivarMarca = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarMarcasCadastradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarMarcasDesativadas).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(781, 83);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(254, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar marca";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(CadastrarMarca);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 626);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(781, 83);
            panel1.TabIndex = 15;
            // 
            // txtID
            // 
            txtID.Location = new Point(230, 26);
            txtID.MaxLength = 100;
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 80;
            txtID.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Dock = DockStyle.Left;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(9, 10);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(214, 63);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CadastrarMarca
            // 
            CadastrarMarca.BackColor = Color.DarkGreen;
            CadastrarMarca.Dock = DockStyle.Right;
            CadastrarMarca.ForeColor = SystemColors.Control;
            CadastrarMarca.Location = new Point(558, 10);
            CadastrarMarca.Margin = new Padding(4, 5, 4, 5);
            CadastrarMarca.Name = "CadastrarMarca";
            CadastrarMarca.Size = new Size(214, 63);
            CadastrarMarca.TabIndex = 1;
            CadastrarMarca.Text = "Aplicar";
            CadastrarMarca.UseVisualStyleBackColor = false;
            CadastrarMarca.Click += CadastrarMarca_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(173, 150);
            txtMarca.Margin = new Padding(4, 5, 4, 5);
            txtMarca.MaxLength = 100;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(317, 31);
            txtMarca.TabIndex = 17;
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(186, 120);
            NomeEquip.Margin = new Padding(4, 0, 4, 0);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(139, 25);
            NomeEquip.TabIndex = 16;
            NomeEquip.Text = "Nome da marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(173, 120);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 18;
            label2.Text = "*";
            // 
            // MostrarMarcasCadastradas
            // 
            MostrarMarcasCadastradas.AllowUserToAddRows = false;
            MostrarMarcasCadastradas.AllowUserToDeleteRows = false;
            MostrarMarcasCadastradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarMarcasCadastradas.Columns.AddRange(new DataGridViewColumn[] { IDMarca, Nome, AtivoInativo });
            MostrarMarcasCadastradas.Location = new Point(46, 342);
            MostrarMarcasCadastradas.Name = "MostrarMarcasCadastradas";
            MostrarMarcasCadastradas.ReadOnly = true;
            MostrarMarcasCadastradas.RowHeadersWidth = 62;
            MostrarMarcasCadastradas.RowTemplate.Height = 33;
            MostrarMarcasCadastradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarMarcasCadastradas.Size = new Size(294, 168);
            MostrarMarcasCadastradas.TabIndex = 19;
            MostrarMarcasCadastradas.CellContentClick += MostrarMarcasCadastradas_CellContentClick;
            MostrarMarcasCadastradas.CellMouseDoubleClick += MostrarMarcasCadastradas_CellMouseDoubleClick;
            // 
            // IDMarca
            // 
            IDMarca.DataPropertyName = "id_marca";
            IDMarca.HeaderText = "ID";
            IDMarca.MinimumWidth = 8;
            IDMarca.Name = "IDMarca";
            IDMarca.ReadOnly = true;
            IDMarca.Width = 80;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Marcas";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // AtivoInativo
            // 
            AtivoInativo.DataPropertyName = "Ativo_inativo";
            AtivoInativo.HeaderText = "Ativo_inativo";
            AtivoInativo.MinimumWidth = 8;
            AtivoInativo.Name = "AtivoInativo";
            AtivoInativo.ReadOnly = true;
            AtivoInativo.Visible = false;
            AtivoInativo.Width = 150;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(497, 150);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(159, 34);
            btnPesquisar.TabIndex = 20;
            btnPesquisar.Text = "Pesquisar marca";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(46, 516);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(102, 44);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "id_marca";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 40;
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Location = new Point(173, 189);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(140, 29);
            checkAtivo.TabIndex = 22;
            checkAtivo.Text = "Ativo/inativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnDesativar
            // 
            btnDesativar.BackColor = Color.DarkGreen;
            btnDesativar.ForeColor = Color.White;
            btnDesativar.Location = new Point(154, 516);
            btnDesativar.Name = "btnDesativar";
            btnDesativar.Size = new Size(186, 44);
            btnDesativar.TabIndex = 23;
            btnDesativar.Text = "Desativar marca";
            btnDesativar.UseVisualStyleBackColor = false;
            btnDesativar.Click += btnDesativar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 307);
            label3.Name = "label3";
            label3.Size = new Size(215, 32);
            label3.TabIndex = 24;
            label3.Text = "Marcas disponíveis";
            // 
            // MostrarMarcasDesativadas
            // 
            MostrarMarcasDesativadas.AllowUserToAddRows = false;
            MostrarMarcasDesativadas.AllowUserToDeleteRows = false;
            MostrarMarcasDesativadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarMarcasDesativadas.Columns.AddRange(new DataGridViewColumn[] { IDMarcaDesativada, MarcaDesativada, ativo_inativo });
            MostrarMarcasDesativadas.Location = new Point(437, 342);
            MostrarMarcasDesativadas.Name = "MostrarMarcasDesativadas";
            MostrarMarcasDesativadas.ReadOnly = true;
            MostrarMarcasDesativadas.RowHeadersWidth = 62;
            MostrarMarcasDesativadas.RowTemplate.Height = 33;
            MostrarMarcasDesativadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarMarcasDesativadas.Size = new Size(294, 168);
            MostrarMarcasDesativadas.TabIndex = 25;
            MostrarMarcasDesativadas.CellMouseDoubleClick += MostrarMarcasDesativadas_CellMouseDoubleClick;
            // 
            // IDMarcaDesativada
            // 
            IDMarcaDesativada.DataPropertyName = "id_marca";
            IDMarcaDesativada.HeaderText = "ID";
            IDMarcaDesativada.MinimumWidth = 8;
            IDMarcaDesativada.Name = "IDMarcaDesativada";
            IDMarcaDesativada.ReadOnly = true;
            IDMarcaDesativada.Width = 80;
            // 
            // MarcaDesativada
            // 
            MarcaDesativada.DataPropertyName = "Nome";
            MarcaDesativada.HeaderText = "Marcas";
            MarcaDesativada.MinimumWidth = 8;
            MarcaDesativada.Name = "MarcaDesativada";
            MarcaDesativada.ReadOnly = true;
            MarcaDesativada.Width = 150;
            // 
            // ativo_inativo
            // 
            ativo_inativo.DataPropertyName = "Ativo_inativo";
            ativo_inativo.HeaderText = "Ativo_inativo";
            ativo_inativo.MinimumWidth = 8;
            ativo_inativo.Name = "ativo_inativo";
            ativo_inativo.ReadOnly = true;
            ativo_inativo.Visible = false;
            ativo_inativo.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(437, 307);
            label4.Name = "label4";
            label4.Size = new Size(219, 32);
            label4.TabIndex = 26;
            label4.Text = "Marcas desativadas";
            // 
            // btnAtivarMarca
            // 
            btnAtivarMarca.BackColor = Color.DarkGreen;
            btnAtivarMarca.ForeColor = Color.White;
            btnAtivarMarca.Location = new Point(437, 516);
            btnAtivarMarca.Name = "btnAtivarMarca";
            btnAtivarMarca.Size = new Size(186, 44);
            btnAtivarMarca.TabIndex = 27;
            btnAtivarMarca.Text = "Ativar marca";
            btnAtivarMarca.UseVisualStyleBackColor = false;
            btnAtivarMarca.Click += btnAtivarMarca_Click;
            // 
            // TelaCadastrarMarca
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 709);
            Controls.Add(btnAtivarMarca);
            Controls.Add(label4);
            Controls.Add(MostrarMarcasDesativadas);
            Controls.Add(label3);
            Controls.Add(btnDesativar);
            Controls.Add(checkAtivo);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(MostrarMarcasCadastradas);
            Controls.Add(label2);
            Controls.Add(txtMarca);
            Controls.Add(NomeEquip);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaCadastrarMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastrarMarca";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarMarcasCadastradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarMarcasDesativadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button CadastrarMarca;
        private Button button2;
        private TextBox txtMarca;
        private Label NomeEquip;
        private Label label2;
        private DataGridView MostrarMarcasCadastradas;
        private Button btnPesquisar;
        private Button btnLimpar;
        private TextBox txtID;
        private DataGridViewTextBoxColumn ID;
        private CheckBox checkAtivo;
        private Button btnDesativar;
        private Label label3;
        private DataGridViewTextBoxColumn IDMarca;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn AtivoInativo;
        private DataGridView MostrarMarcasDesativadas;
        private DataGridViewTextBoxColumn IDMarcaDesativada;
        private DataGridViewTextBoxColumn MarcaDesativada;
        private DataGridViewTextBoxColumn ativo_inativo;
        private Label label4;
        private Button btnAtivarMarca;
    }
}