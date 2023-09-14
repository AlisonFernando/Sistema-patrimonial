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
            inputMarcaNome = new TextBox();
            NomeEquip = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            CadastrarMarca.Text = "Cadastrar";
            CadastrarMarca.UseVisualStyleBackColor = false;
            CadastrarMarca.Click += CadastrarMarca_Click;
            // 
            // inputMarcaNome
            // 
            inputMarcaNome.Location = new Point(133, 215);
            inputMarcaNome.Margin = new Padding(4, 5, 4, 5);
            inputMarcaNome.MaxLength = 100;
            inputMarcaNome.Name = "inputMarcaNome";
            inputMarcaNome.Size = new Size(317, 31);
            inputMarcaNome.TabIndex = 17;
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(133, 185);
            NomeEquip.Margin = new Padding(4, 0, 4, 0);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(139, 25);
            NomeEquip.TabIndex = 16;
            NomeEquip.Text = "Nome da marca";
            // 
            // TelaCadastrarMarca
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 520);
            Controls.Add(inputMarcaNome);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button CadastrarMarca;
        private Button button2;
        private TextBox inputMarcaNome;
        private Label NomeEquip;
    }
}