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
            button2 = new Button();
            CadastrarMarca = new Button();
            txtMarca = new TextBox();
            NomeEquip = new Label();
            label2 = new Label();
            MostrarMarcasCadastradas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NomeMarca = new DataGridViewTextBoxColumn();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarMarcasCadastradas).BeginInit();
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
            panel2.Size = new Size(610, 83);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(174, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar marca";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(CadastrarMarca);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 437);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 10, 9, 10);
            panel1.Size = new Size(610, 83);
            panel1.TabIndex = 15;
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
            CadastrarMarca.Location = new Point(387, 10);
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
            txtMarca.Location = new Point(46, 156);
            txtMarca.Margin = new Padding(4, 5, 4, 5);
            txtMarca.MaxLength = 100;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(317, 31);
            txtMarca.TabIndex = 17;
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(59, 126);
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
            label2.Location = new Point(46, 126);
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
            MostrarMarcasCadastradas.Columns.AddRange(new DataGridViewColumn[] { ID, NomeMarca });
            MostrarMarcasCadastradas.Location = new Point(46, 207);
            MostrarMarcasCadastradas.Name = "MostrarMarcasCadastradas";
            MostrarMarcasCadastradas.ReadOnly = true;
            MostrarMarcasCadastradas.RowHeadersWidth = 62;
            MostrarMarcasCadastradas.RowTemplate.Height = 33;
            MostrarMarcasCadastradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarMarcasCadastradas.Size = new Size(291, 168);
            MostrarMarcasCadastradas.TabIndex = 19;
            // 
            // ID
            // 
            ID.DataPropertyName = "id_marca";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 40;
            // 
            // NomeMarca
            // 
            NomeMarca.DataPropertyName = "Nome";
            NomeMarca.HeaderText = "Nome da marca";
            NomeMarca.MinimumWidth = 8;
            NomeMarca.Name = "NomeMarca";
            NomeMarca.ReadOnly = true;
            NomeMarca.Width = 190;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(370, 156);
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
            btnLimpar.Location = new Point(46, 381);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(81, 34);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // TelaCadastrarMarca
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 520);
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
            ((System.ComponentModel.ISupportInitialize)MostrarMarcasCadastradas).EndInit();
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NomeMarca;
        private Button btnPesquisar;
        private Button btnLimpar;
    }
}