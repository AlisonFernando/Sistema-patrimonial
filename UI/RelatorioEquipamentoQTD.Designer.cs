namespace UI
{
    partial class TelaRelatorioEquipsQTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorioEquipsQTD));
            btnVoltar = new Button();
            btnCaminho = new Button();
            btnGerarPDF = new Button();
            txtDestino = new TextBox();
            lblTitulo = new Label();
            HeaderCadColab = new Panel();
            label1 = new Label();
            button1 = new Button();
            HeaderCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackgroundImage = Properties.Resources.seta_esquerda;
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.ImeMode = ImeMode.NoControl;
            btnVoltar.Location = new Point(8, 7);
            btnVoltar.Margin = new Padding(2, 2, 2, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(27, 25);
            btnVoltar.TabIndex = 10;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCaminho
            // 
            btnCaminho.BackColor = Color.DarkGreen;
            btnCaminho.ForeColor = Color.White;
            btnCaminho.ImeMode = ImeMode.NoControl;
            btnCaminho.Location = new Point(327, 133);
            btnCaminho.Margin = new Padding(2, 2, 2, 2);
            btnCaminho.Name = "btnCaminho";
            btnCaminho.Size = new Size(115, 29);
            btnCaminho.TabIndex = 9;
            btnCaminho.Text = "Escolher caminho";
            btnCaminho.UseVisualStyleBackColor = false;
            btnCaminho.Click += btnCaminho_Click;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.BackColor = Color.DarkGreen;
            btnGerarPDF.ForeColor = Color.White;
            btnGerarPDF.ImeMode = ImeMode.NoControl;
            btnGerarPDF.Location = new Point(42, 163);
            btnGerarPDF.Margin = new Padding(2, 2, 2, 2);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(120, 32);
            btnGerarPDF.TabIndex = 8;
            btnGerarPDF.Text = "Gerar relatório PDF";
            btnGerarPDF.UseVisualStyleBackColor = false;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // txtDestino
            // 
            txtDestino.Enabled = false;
            txtDestino.Location = new Point(42, 136);
            txtDestino.Margin = new Padding(2, 2, 2, 2);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(281, 23);
            txtDestino.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ImeMode = ImeMode.NoControl;
            lblTitulo.Location = new Point(42, 109);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 25);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Salvar PDF em";
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Controls.Add(button1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(472, 50);
            HeaderCadColab.TabIndex = 18;
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
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.seta_esquerda;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(11, 12);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(27, 25);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaRelatorioEquipsQTD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(472, 315);
            Controls.Add(HeaderCadColab);
            Controls.Add(btnVoltar);
            Controls.Add(btnCaminho);
            Controls.Add(btnGerarPDF);
            Controls.Add(txtDestino);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "TelaRelatorioEquipsQTD";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de equipamentos";
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
        private Panel HeaderCadColab;
        private Label label1;
        private Button button1;
    }
}