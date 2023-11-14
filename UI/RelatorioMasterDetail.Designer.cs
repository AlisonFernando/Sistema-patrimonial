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
            btnVoltar.Location = new Point(16, 20);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(39, 42);
            btnVoltar.TabIndex = 15;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCaminho
            // 
            btnCaminho.BackColor = Color.DarkGreen;
            btnCaminho.ForeColor = Color.White;
            btnCaminho.ImeMode = ImeMode.NoControl;
            btnCaminho.Location = new Point(469, 313);
            btnCaminho.Name = "btnCaminho";
            btnCaminho.Size = new Size(164, 48);
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
            btnGerarPDF.Location = new Point(61, 365);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(171, 53);
            btnGerarPDF.TabIndex = 13;
            btnGerarPDF.Text = "Gerar relatório PDF";
            btnGerarPDF.UseVisualStyleBackColor = false;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // txtDestino
            // 
            txtDestino.Enabled = false;
            txtDestino.Location = new Point(61, 320);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(400, 31);
            txtDestino.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ImeMode = ImeMode.NoControl;
            lblTitulo.Location = new Point(61, 275);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 38);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Salvar PDF em";
            // 
            // comboBoxColaborador
            // 
            comboBoxColaborador.FormattingEnabled = true;
            comboBoxColaborador.Location = new Point(61, 218);
            comboBoxColaborador.Name = "comboBoxColaborador";
            comboBoxColaborador.Size = new Size(260, 33);
            comboBoxColaborador.TabIndex = 16;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Controls.Add(btnVoltar);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Margin = new Padding(4, 5, 4, 5);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(674, 83);
            HeaderCadColab.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(255, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 41);
            label1.TabIndex = 91;
            label1.Text = "Relatório";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 18;
            label2.Text = "Escolha o colaborador";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(61, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 19;
            label3.Text = "*";
            // 
            // RelatorioMasterDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 510);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(HeaderCadColab);
            Controls.Add(comboBoxColaborador);
            Controls.Add(btnCaminho);
            Controls.Add(btnGerarPDF);
            Controls.Add(txtDestino);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
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