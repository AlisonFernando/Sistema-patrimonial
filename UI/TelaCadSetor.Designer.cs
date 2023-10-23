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
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            btnLimpar = new Button();
            btnDeletar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarSetores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(309, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
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
            btn_voltar.Location = new Point(16, 11);
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
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnCadastrar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 529);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(800, 83);
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
            btnCadastrar.Location = new Point(584, 10);
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
            MostrarSetores.Columns.AddRange(new DataGridViewColumn[] { ID_setor, Nome_setor });
            MostrarSetores.Location = new Point(171, 207);
            MostrarSetores.Name = "MostrarSetores";
            MostrarSetores.ReadOnly = true;
            MostrarSetores.RowHeadersWidth = 62;
            MostrarSetores.RowTemplate.Height = 33;
            MostrarSetores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarSetores.Size = new Size(360, 225);
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
            ID_setor.Width = 150;
            // 
            // Nome_setor
            // 
            Nome_setor.DataPropertyName = "Nome";
            Nome_setor.HeaderText = "Setor";
            Nome_setor.MinimumWidth = 8;
            Nome_setor.Name = "Nome_setor";
            Nome_setor.ReadOnly = true;
            Nome_setor.Width = 150;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGreen;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(419, 169);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(112, 32);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(171, 169);
            txtPesquisar.MaxLength = 100;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(242, 31);
            txtPesquisar.TabIndex = 22;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGreen;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(265, 438);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(88, 32);
            btnLimpar.TabIndex = 23;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.DarkGreen;
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Location = new Point(171, 438);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(88, 32);
            btnDeletar.TabIndex = 24;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // TelaCadSetor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(btnDeletar);
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
        private DataGridViewTextBoxColumn ID_setor;
        private DataGridViewTextBoxColumn Nome_setor;
        private TextBox txtID;
        private Button btnDeletar;
    }
}