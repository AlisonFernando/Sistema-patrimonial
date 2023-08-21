﻿namespace UI
{
    partial class TelaAbrirChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAbrirChamado));
            panel2 = new Panel();
            btnCadUserSucesso = new Button();
            panel1 = new Panel();
            label1 = new Label();
            selectEtiqueta = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtColab = new TextBox();
            txtEquip = new TextBox();
            label5 = new Label();
            btn_pesquisar = new Button();
            btn_limpar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnCadUserSucesso);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 283);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6);
            panel2.Size = new Size(440, 50);
            panel2.TabIndex = 11;
            // 
            // btnCadUserSucesso
            // 
            btnCadUserSucesso.BackColor = Color.DarkGreen;
            btnCadUserSucesso.Dock = DockStyle.Right;
            btnCadUserSucesso.ForeColor = SystemColors.Control;
            btnCadUserSucesso.Location = new Point(284, 6);
            btnCadUserSucesso.Name = "btnCadUserSucesso";
            btnCadUserSucesso.Size = new Size(150, 38);
            btnCadUserSucesso.TabIndex = 1;
            btnCadUserSucesso.Text = "Abrir chamado";
            btnCadUserSucesso.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 50);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Abrir chamado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectEtiqueta
            // 
            selectEtiqueta.FormattingEnabled = true;
            selectEtiqueta.Location = new Point(12, 82);
            selectEtiqueta.Name = "selectEtiqueta";
            selectEtiqueta.Size = new Size(105, 23);
            selectEtiqueta.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 14;
            label2.Text = "Selecione a etiqueta do equipamento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 23);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 16;
            label3.Text = "Descreva o motivo do chamado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 17;
            label4.Text = "Colaborador responsável";
            // 
            // txtColab
            // 
            txtColab.Location = new Point(12, 126);
            txtColab.Name = "txtColab";
            txtColab.ReadOnly = true;
            txtColab.ShortcutsEnabled = false;
            txtColab.Size = new Size(203, 23);
            txtColab.TabIndex = 19;
            // 
            // txtEquip
            // 
            txtEquip.Location = new Point(219, 126);
            txtEquip.Name = "txtEquip";
            txtEquip.ReadOnly = true;
            txtEquip.Size = new Size(215, 23);
            txtEquip.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 108);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 21;
            label5.Text = "Nome do equipamento";
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.BackColor = Color.DarkGreen;
            btn_pesquisar.ForeColor = SystemColors.Control;
            btn_pesquisar.Location = new Point(284, 224);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(150, 38);
            btn_pesquisar.TabIndex = 22;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.DarkGreen;
            btn_limpar.ForeColor = SystemColors.Control;
            btn_limpar.Location = new Point(12, 224);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(150, 38);
            btn_limpar.TabIndex = 23;
            btn_limpar.Text = "Limpar ";
            btn_limpar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(219, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 61);
            label6.Name = "label6";
            label6.Size = new Size(157, 15);
            label6.TabIndex = 25;
            label6.Text = "Selecionar data do chamado";
            // 
            // TelaAbrirChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 333);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_limpar);
            Controls.Add(btn_pesquisar);
            Controls.Add(label5);
            Controls.Add(txtEquip);
            Controls.Add(txtColab);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(selectEtiqueta);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaAbrirChamado";
            Text = "AbrirChamado";
            Load += TelaAbrirChamado_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private ComboBox selectEtiqueta;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnCadUserSucesso;
        private TextBox txtColab;
        private TextBox txtEquip;
        private Label label5;
        private Button btn_pesquisar;
        public Button btn_limpar;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}