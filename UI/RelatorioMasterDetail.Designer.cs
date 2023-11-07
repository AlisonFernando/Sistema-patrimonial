namespace UI
{
    partial class RelatorioMasterDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioMasterDetail));
            btnVoltar = new Button();
            btnCaminho = new Button();
            btnGerarPDF = new Button();
            txtDestino = new TextBox();
            lblTitulo = new Label();
            comboBoxColaborador = new ComboBox();
            HeaderCadColab = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            HeaderCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackgroundImage = Properties.Resources.seta_esquerda;
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.ImeMode = ImeMode.NoControl;
            btnVoltar.Location = new Point(11, 12);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(27, 25);
            btnVoltar.TabIndex = 15;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCaminho
            // 
            btnCaminho.BackColor = Color.DarkGreen;
            btnCaminho.ForeColor = Color.White;
            btnCaminho.ImeMode = ImeMode.NoControl;
            btnCaminho.Location = new Point(328, 188);
            btnCaminho.Margin = new Padding(2);
            btnCaminho.Name = "btnCaminho";
            btnCaminho.Size = new Size(115, 29);
            btnCaminho.TabIndex = 14;
            btnCaminho.Text = "Escolher caminho";
            btnCaminho.UseVisualStyleBackColor = false;
            btnCaminho.Click += btnCaminho_Click;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.BackColor = Color.DarkGreen;
            btnGerarPDF.ForeColor = Color.White;
            btnGerarPDF.ImeMode = ImeMode.NoControl;
            btnGerarPDF.Location = new Point(43, 219);
            btnGerarPDF.Margin = new Padding(2);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(120, 32);
            btnGerarPDF.TabIndex = 13;
            btnGerarPDF.Text = "Gerar relatório PDF";
            btnGerarPDF.UseVisualStyleBackColor = false;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // txtDestino
            // 
            txtDestino.Enabled = false;
            txtDestino.Location = new Point(43, 192);
            txtDestino.Margin = new Padding(2);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(281, 23);
            txtDestino.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ImeMode = ImeMode.NoControl;
            lblTitulo.Location = new Point(43, 165);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 25);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Salvar PDF em";
            // 
            // comboBoxColaborador
            // 
            comboBoxColaborador.FormattingEnabled = true;
            comboBoxColaborador.Location = new Point(43, 131);
            comboBoxColaborador.Margin = new Padding(2);
            comboBoxColaborador.Name = "comboBoxColaborador";
            comboBoxColaborador.Size = new Size(183, 23);
            comboBoxColaborador.TabIndex = 16;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Controls.Add(btnVoltar);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(472, 50);
            HeaderCadColab.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 91;
            label1.Text = "Relatório";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 112);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 18;
            label2.Text = "Escolha o colaborador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(43, 114);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 19;
            label3.Text = "*";
            // 
            // RelatorioMasterDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 306);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(HeaderCadColab);
            Controls.Add(comboBoxColaborador);
            Controls.Add(btnCaminho);
            Controls.Add(btnGerarPDF);
            Controls.Add(txtDestino);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "RelatorioMasterDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório principal";
            Load += RelatorioMasterDetail_Load;
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnCaminho;
        private Button btnGerarPDF;
        private TextBox txtDestino;
        private Label lblTitulo;
        private ComboBox comboBoxColaborador;
        private Panel HeaderCadColab;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}