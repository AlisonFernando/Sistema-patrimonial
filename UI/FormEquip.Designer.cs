namespace UI
{
    partial class CadEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEquip));
            NomeEquip = new Label();
            MarcaEquip = new Label();
            DescricaoEquip = new Label();
            PrecoEquip = new Label();
            EtiquetaEquip = new Label();
            inputEquipNome = new TextBox();
            inputDesEquip = new TextBox();
            inputEtiquetaEquip = new TextBox();
            inputPrecoEquip = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            escolherMarca = new ComboBox();
            label1 = new Label();
            check_ativo = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NomeEquip
            // 
            NomeEquip.AutoSize = true;
            NomeEquip.Location = new Point(12, 70);
            NomeEquip.Name = "NomeEquip";
            NomeEquip.Size = new Size(131, 15);
            NomeEquip.TabIndex = 0;
            NomeEquip.Text = "Nome do Equipamento";
            // 
            // MarcaEquip
            // 
            MarcaEquip.AutoSize = true;
            MarcaEquip.Location = new Point(246, 70);
            MarcaEquip.Name = "MarcaEquip";
            MarcaEquip.Size = new Size(40, 15);
            MarcaEquip.TabIndex = 1;
            MarcaEquip.Text = "Marca";
            // 
            // DescricaoEquip
            // 
            DescricaoEquip.AutoSize = true;
            DescricaoEquip.Location = new Point(12, 114);
            DescricaoEquip.Name = "DescricaoEquip";
            DescricaoEquip.Size = new Size(58, 15);
            DescricaoEquip.TabIndex = 2;
            DescricaoEquip.Text = "Descrição";
            // 
            // PrecoEquip
            // 
            PrecoEquip.AutoSize = true;
            PrecoEquip.Location = new Point(246, 114);
            PrecoEquip.Name = "PrecoEquip";
            PrecoEquip.Size = new Size(37, 15);
            PrecoEquip.TabIndex = 3;
            PrecoEquip.Text = "Preço";
            // 
            // EtiquetaEquip
            // 
            EtiquetaEquip.AutoSize = true;
            EtiquetaEquip.Location = new Point(12, 158);
            EtiquetaEquip.Name = "EtiquetaEquip";
            EtiquetaEquip.Size = new Size(50, 15);
            EtiquetaEquip.TabIndex = 4;
            EtiquetaEquip.Text = "Etiqueta";
            // 
            // inputEquipNome
            // 
            inputEquipNome.Location = new Point(12, 88);
            inputEquipNome.MaxLength = 100;
            inputEquipNome.Name = "inputEquipNome";
            inputEquipNome.Size = new Size(223, 23);
            inputEquipNome.TabIndex = 1;
            // 
            // inputDesEquip
            // 
            inputDesEquip.Location = new Point(12, 132);
            inputDesEquip.MaxLength = 100;
            inputDesEquip.Name = "inputDesEquip";
            inputDesEquip.Size = new Size(223, 23);
            inputDesEquip.TabIndex = 2;
            // 
            // inputEtiquetaEquip
            // 
            inputEtiquetaEquip.Location = new Point(12, 176);
            inputEtiquetaEquip.MaxLength = 10;
            inputEtiquetaEquip.Name = "inputEtiquetaEquip";
            inputEtiquetaEquip.Size = new Size(223, 23);
            inputEtiquetaEquip.TabIndex = 3;
            // 
            // inputPrecoEquip
            // 
            inputPrecoEquip.Location = new Point(246, 132);
            inputPrecoEquip.MaxLength = 10;
            inputPrecoEquip.Name = "inputPrecoEquip";
            inputPrecoEquip.Size = new Size(116, 23);
            inputPrecoEquip.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 221);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(427, 50);
            panel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Dock = DockStyle.Left;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(6, 6);
            button2.Name = "button2";
            button2.Size = new Size(150, 38);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(271, 6);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(6);
            panel2.Size = new Size(427, 50);
            panel2.TabIndex = 13;
            // 
            // escolherMarca
            // 
            escolherMarca.FormattingEnabled = true;
            escolherMarca.Location = new Point(246, 88);
            escolherMarca.Name = "escolherMarca";
            escolherMarca.Size = new Size(116, 23);
            escolherMarca.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 160);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 20;
            label1.Text = "Ativo/Inativo";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(246, 178);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(54, 19);
            check_ativo.TabIndex = 6;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // CadEquip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 271);
            Controls.Add(check_ativo);
            Controls.Add(label1);
            Controls.Add(escolherMarca);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(inputPrecoEquip);
            Controls.Add(inputEtiquetaEquip);
            Controls.Add(inputDesEquip);
            Controls.Add(inputEquipNome);
            Controls.Add(EtiquetaEquip);
            Controls.Add(PrecoEquip);
            Controls.Add(DescricaoEquip);
            Controls.Add(MarcaEquip);
            Controls.Add(NomeEquip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadEquip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar equipamento";
            Load += CadEquip_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeEquip;
        private Label MarcaEquip;
        private Label DescricaoEquip;
        private Label PrecoEquip;
        private Label EtiquetaEquip;
        private TextBox inputEquipNome;
        private TextBox inputDesEquip;
        private TextBox inputEtiquetaEquip;
        private TextBox inputPrecoEquip;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private ComboBox escolherMarca;
        private Label label1;
        private CheckBox check_ativo;
    }
}