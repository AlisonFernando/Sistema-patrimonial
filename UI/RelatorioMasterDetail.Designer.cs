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
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackgroundImage = Properties.Resources.seta_esquerda;
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.ImeMode = ImeMode.NoControl;
            btnVoltar.Location = new Point(10, 14);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(39, 41);
            btnVoltar.TabIndex = 15;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCaminho
            // 
            btnCaminho.BackColor = Color.DarkGreen;
            btnCaminho.ForeColor = Color.White;
            btnCaminho.ImeMode = ImeMode.NoControl;
            btnCaminho.Location = new Point(466, 191);
            btnCaminho.Name = "btnCaminho";
            btnCaminho.Size = new Size(164, 34);
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
            btnGerarPDF.Location = new Point(60, 231);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(400, 53);
            btnGerarPDF.TabIndex = 13;
            btnGerarPDF.Text = "Gerar relatório PDF";
            btnGerarPDF.UseVisualStyleBackColor = false;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(60, 191);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(400, 31);
            txtDestino.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ImeMode = ImeMode.NoControl;
            lblTitulo.Location = new Point(60, 128);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 38);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Salvar PDF em";
            // 
            // RelatorioMasterDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 339);
            Controls.Add(btnVoltar);
            Controls.Add(btnCaminho);
            Controls.Add(btnGerarPDF);
            Controls.Add(txtDestino);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RelatorioMasterDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnCaminho;
        private Button btnGerarPDF;
        private TextBox txtDestino;
        private Label lblTitulo;
    }
}