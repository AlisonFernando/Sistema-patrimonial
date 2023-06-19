namespace UI
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
            panel1 = new Panel();
            label1 = new Label();
            SelectEquip = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            btnCadUserSucesso = new Button();
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
            // SelectEquip
            // 
            SelectEquip.FormattingEnabled = true;
            SelectEquip.Location = new Point(12, 82);
            SelectEquip.Name = "SelectEquip";
            SelectEquip.Size = new Size(179, 23);
            SelectEquip.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 14;
            label2.Text = "Selecione o equipamento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 23);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 16;
            label3.Text = "Descreva o motivo do chamado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 64);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 17;
            label4.Text = "Selecione o colaborador ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 18;
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
            // TelaAbrirChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 333);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(SelectEquip);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaAbrirChamado";
            Text = "AbrirChamado";
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
        private ComboBox SelectEquip;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnCadUserSucesso;
    }
}