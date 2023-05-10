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
            this.NomeEquip = new System.Windows.Forms.Label();
            this.MarcaEquip = new System.Windows.Forms.Label();
            this.DescricaoEquip = new System.Windows.Forms.Label();
            this.PrecoEquip = new System.Windows.Forms.Label();
            this.EtiquetaEquip = new System.Windows.Forms.Label();
            this.inputEquipNome = new System.Windows.Forms.TextBox();
            this.inputDesEquip = new System.Windows.Forms.TextBox();
            this.inputEtiquetaEquip = new System.Windows.Forms.TextBox();
            this.inputPrecoEquip = new System.Windows.Forms.TextBox();
            this.selectMarcaEquip = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputCodEquip = new System.Windows.Forms.TextBox();
            this.codigoEquip = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomeEquip
            // 
            this.NomeEquip.AutoSize = true;
            this.NomeEquip.Location = new System.Drawing.Point(12, 70);
            this.NomeEquip.Name = "NomeEquip";
            this.NomeEquip.Size = new System.Drawing.Size(131, 15);
            this.NomeEquip.TabIndex = 0;
            this.NomeEquip.Text = "Nome do Equipamento";
            // 
            // MarcaEquip
            // 
            this.MarcaEquip.AutoSize = true;
            this.MarcaEquip.Location = new System.Drawing.Point(246, 70);
            this.MarcaEquip.Name = "MarcaEquip";
            this.MarcaEquip.Size = new System.Drawing.Size(40, 15);
            this.MarcaEquip.TabIndex = 1;
            this.MarcaEquip.Text = "Marca";
            // 
            // DescricaoEquip
            // 
            this.DescricaoEquip.AutoSize = true;
            this.DescricaoEquip.Location = new System.Drawing.Point(12, 114);
            this.DescricaoEquip.Name = "DescricaoEquip";
            this.DescricaoEquip.Size = new System.Drawing.Size(58, 15);
            this.DescricaoEquip.TabIndex = 2;
            this.DescricaoEquip.Text = "Descrição";
            // 
            // PrecoEquip
            // 
            this.PrecoEquip.AutoSize = true;
            this.PrecoEquip.Location = new System.Drawing.Point(246, 114);
            this.PrecoEquip.Name = "PrecoEquip";
            this.PrecoEquip.Size = new System.Drawing.Size(37, 15);
            this.PrecoEquip.TabIndex = 3;
            this.PrecoEquip.Text = "Preço";
            // 
            // EtiquetaEquip
            // 
            this.EtiquetaEquip.AutoSize = true;
            this.EtiquetaEquip.Location = new System.Drawing.Point(12, 158);
            this.EtiquetaEquip.Name = "EtiquetaEquip";
            this.EtiquetaEquip.Size = new System.Drawing.Size(50, 15);
            this.EtiquetaEquip.TabIndex = 4;
            this.EtiquetaEquip.Text = "Etiqueta";
            // 
            // inputEquipNome
            // 
            this.inputEquipNome.Location = new System.Drawing.Point(12, 88);
            this.inputEquipNome.MaxLength = 100;
            this.inputEquipNome.Name = "inputEquipNome";
            this.inputEquipNome.Size = new System.Drawing.Size(223, 23);
            this.inputEquipNome.TabIndex = 5;
            // 
            // inputDesEquip
            // 
            this.inputDesEquip.Location = new System.Drawing.Point(12, 132);
            this.inputDesEquip.MaxLength = 100;
            this.inputDesEquip.Name = "inputDesEquip";
            this.inputDesEquip.Size = new System.Drawing.Size(223, 23);
            this.inputDesEquip.TabIndex = 7;
            // 
            // inputEtiquetaEquip
            // 
            this.inputEtiquetaEquip.Location = new System.Drawing.Point(12, 176);
            this.inputEtiquetaEquip.MaxLength = 10;
            this.inputEtiquetaEquip.Name = "inputEtiquetaEquip";
            this.inputEtiquetaEquip.Size = new System.Drawing.Size(223, 23);
            this.inputEtiquetaEquip.TabIndex = 8;
            // 
            // inputPrecoEquip
            // 
            this.inputPrecoEquip.Location = new System.Drawing.Point(246, 132);
            this.inputPrecoEquip.MaxLength = 10;
            this.inputPrecoEquip.Name = "inputPrecoEquip";
            this.inputPrecoEquip.Size = new System.Drawing.Size(116, 23);
            this.inputPrecoEquip.TabIndex = 9;
            // 
            // selectMarcaEquip
            // 
            this.selectMarcaEquip.FormattingEnabled = true;
            this.selectMarcaEquip.Items.AddRange(new object[] {
            "Dell",
            "Xiaomi",
            "Motorola",
            "Samsung",
            "Iphone",
            "Kaidi"});
            this.selectMarcaEquip.Location = new System.Drawing.Point(246, 88);
            this.selectMarcaEquip.Name = "selectMarcaEquip";
            this.selectMarcaEquip.Size = new System.Drawing.Size(121, 23);
            this.selectMarcaEquip.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(427, 50);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(271, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.inputCodEquip);
            this.panel2.Controls.Add(this.codigoEquip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(427, 50);
            this.panel2.TabIndex = 13;
            // 
            // inputCodEquip
            // 
            this.inputCodEquip.Location = new System.Drawing.Point(56, 17);
            this.inputCodEquip.Name = "inputCodEquip";
            this.inputCodEquip.Size = new System.Drawing.Size(100, 23);
            this.inputCodEquip.TabIndex = 11;
            // 
            // codigoEquip
            // 
            this.codigoEquip.AutoSize = true;
            this.codigoEquip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoEquip.ForeColor = System.Drawing.SystemColors.Control;
            this.codigoEquip.Location = new System.Drawing.Point(12, 20);
            this.codigoEquip.Name = "codigoEquip";
            this.codigoEquip.Size = new System.Drawing.Size(45, 15);
            this.codigoEquip.TabIndex = 10;
            this.codigoEquip.Text = "Código";
            // 
            // CadEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 283);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectMarcaEquip);
            this.Controls.Add(this.inputPrecoEquip);
            this.Controls.Add(this.inputEtiquetaEquip);
            this.Controls.Add(this.inputDesEquip);
            this.Controls.Add(this.inputEquipNome);
            this.Controls.Add(this.EtiquetaEquip);
            this.Controls.Add(this.PrecoEquip);
            this.Controls.Add(this.DescricaoEquip);
            this.Controls.Add(this.MarcaEquip);
            this.Controls.Add(this.NomeEquip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadEquip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar equipamentos";
            this.Load += new System.EventHandler(this.CadEquip_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox selectMarcaEquip;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private TextBox inputCodEquip;
        private Label codigoEquip;
    }
}