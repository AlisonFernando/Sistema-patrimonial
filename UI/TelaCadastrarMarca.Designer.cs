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
            CadastrarMarca = new Button();
            button2 = new Button();
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
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6);
            panel2.Size = new Size(427, 50);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(122, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar marca";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(CadastrarMarca);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 262);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(427, 50);
            panel1.TabIndex = 15;
            // 
            // CadastrarMarca
            // 
            CadastrarMarca.BackColor = Color.DarkGreen;
            CadastrarMarca.Dock = DockStyle.Right;
            CadastrarMarca.ForeColor = SystemColors.Control;
            CadastrarMarca.Location = new Point(271, 6);
            CadastrarMarca.Name = "CadastrarMarca";
            CadastrarMarca.Size = new Size(150, 38);
            CadastrarMarca.TabIndex = 1;
            CadastrarMarca.Text = "Cadastrar";
            CadastrarMarca.UseVisualStyleBackColor = false;
            CadastrarMarca.Click += CadastrarMarca_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Dock = DockStyle.Left;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(6, 6);
            button2.Name = "button2";
            button2.Size = new Size(150, 38);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // inputMarcaNome
            // 
            inputMarcaNome.Location = new Point(93, 129);
            inputMarcaNome.MaxLength = 100;
            inputMarcaNome.Name = "inputMarcaNome";
            inputMarcaNome.Size = new Size(223, 23);
            inputMarcaNome.TabIndex = 17;
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(93, 111);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(92, 15);
            NomeEquip.TabIndex = 16;
            NomeEquip.Text = "Nome da marca";
            // 
            // TelaCadastrarMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 312);
            Controls.Add(inputMarcaNome);
            Controls.Add(NomeEquip);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
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