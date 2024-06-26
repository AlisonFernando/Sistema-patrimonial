﻿namespace UI
{
    partial class RelatorioEquipamentoPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioEquipamentoPreco));
            lblTitulo = new Label();
            txtDestino = new TextBox();
            btnGerarPDF = new Button();
            btnCaminho = new Button();
            btnVoltar = new Button();
            HeaderCadColab = new Panel();
            label1 = new Label();
            button1 = new Button();
            HeaderCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(lblTitulo, "lblTitulo");
            lblTitulo.Name = "lblTitulo";
            // 
            // txtDestino
            // 
            resources.ApplyResources(txtDestino, "txtDestino");
            txtDestino.Name = "txtDestino";
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.BackColor = Color.DarkGreen;
            btnGerarPDF.ForeColor = Color.White;
            resources.ApplyResources(btnGerarPDF, "btnGerarPDF");
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.UseVisualStyleBackColor = false;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // btnCaminho
            // 
            btnCaminho.BackColor = Color.DarkGreen;
            btnCaminho.ForeColor = Color.White;
            resources.ApplyResources(btnCaminho, "btnCaminho");
            btnCaminho.Name = "btnCaminho";
            btnCaminho.UseVisualStyleBackColor = false;
            btnCaminho.Click += btnCaminho_Click;
            // 
            // btnVoltar
            // 
            resources.ApplyResources(btnVoltar, "btnVoltar");
            btnVoltar.Image = Properties.Resources.seta_esquerda;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Controls.Add(button1);
            resources.ApplyResources(HeaderCadColab, "HeaderCadColab");
            HeaderCadColab.Name = "HeaderCadColab";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Window;
            label1.Name = "label1";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.seta_esquerda;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RelatorioEquipamentoPreco
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HeaderCadColab);
            Controls.Add(btnVoltar);
            Controls.Add(btnCaminho);
            Controls.Add(btnGerarPDF);
            Controls.Add(txtDestino);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "RelatorioEquipamentoPreco";
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtDestino;
        private Button btnGerarPDF;
        private Button btnCaminho;
        private Button btnVoltar;
        private Panel HeaderCadColab;
        private Label label1;
        private Button button1;
    }
}