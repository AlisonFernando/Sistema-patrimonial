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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectMarcaEquip = new System.Windows.Forms.ComboBox();
            this.btnNovoEquip = new System.Windows.Forms.Button();
            this.btnSalvarEquip = new System.Windows.Forms.Button();
            this.btnEditarEquip = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeEquip
            // 
            this.NomeEquip.AutoSize = true;
            this.NomeEquip.Location = new System.Drawing.Point(12, 31);
            this.NomeEquip.Name = "NomeEquip";
            this.NomeEquip.Size = new System.Drawing.Size(131, 15);
            this.NomeEquip.TabIndex = 0;
            this.NomeEquip.Text = "Nome do Equipamento";
            // 
            // MarcaEquip
            // 
            this.MarcaEquip.AutoSize = true;
            this.MarcaEquip.Location = new System.Drawing.Point(241, 31);
            this.MarcaEquip.Name = "MarcaEquip";
            this.MarcaEquip.Size = new System.Drawing.Size(40, 15);
            this.MarcaEquip.TabIndex = 1;
            this.MarcaEquip.Text = "Marca";
            // 
            // DescricaoEquip
            // 
            this.DescricaoEquip.AutoSize = true;
            this.DescricaoEquip.Location = new System.Drawing.Point(12, 85);
            this.DescricaoEquip.Name = "DescricaoEquip";
            this.DescricaoEquip.Size = new System.Drawing.Size(58, 15);
            this.DescricaoEquip.TabIndex = 2;
            this.DescricaoEquip.Text = "Descrição";
            // 
            // PrecoEquip
            // 
            this.PrecoEquip.AutoSize = true;
            this.PrecoEquip.Location = new System.Drawing.Point(246, 85);
            this.PrecoEquip.Name = "PrecoEquip";
            this.PrecoEquip.Size = new System.Drawing.Size(37, 15);
            this.PrecoEquip.TabIndex = 3;
            this.PrecoEquip.Text = "Preço";
            // 
            // EtiquetaEquip
            // 
            this.EtiquetaEquip.AutoSize = true;
            this.EtiquetaEquip.Location = new System.Drawing.Point(12, 141);
            this.EtiquetaEquip.Name = "EtiquetaEquip";
            this.EtiquetaEquip.Size = new System.Drawing.Size(50, 15);
            this.EtiquetaEquip.TabIndex = 4;
            this.EtiquetaEquip.Text = "Etiqueta";
            // 
            // inputEquipNome
            // 
            this.inputEquipNome.Location = new System.Drawing.Point(12, 49);
            this.inputEquipNome.MaxLength = 100;
            this.inputEquipNome.Name = "inputEquipNome";
            this.inputEquipNome.PlaceholderText = "Digite o nome do equipamento";
            this.inputEquipNome.Size = new System.Drawing.Size(223, 23);
            this.inputEquipNome.TabIndex = 5;
            // 
            // inputDesEquip
            // 
            this.inputDesEquip.Location = new System.Drawing.Point(12, 103);
            this.inputDesEquip.MaxLength = 100;
            this.inputDesEquip.Name = "inputDesEquip";
            this.inputDesEquip.PlaceholderText = "Digite a descrição do equipamento";
            this.inputDesEquip.Size = new System.Drawing.Size(223, 23);
            this.inputDesEquip.TabIndex = 7;
            // 
            // inputEtiquetaEquip
            // 
            this.inputEtiquetaEquip.Location = new System.Drawing.Point(12, 159);
            this.inputEtiquetaEquip.MaxLength = 10;
            this.inputEtiquetaEquip.Name = "inputEtiquetaEquip";
            this.inputEtiquetaEquip.PlaceholderText = "Digite uma etiqueta para identificação";
            this.inputEtiquetaEquip.Size = new System.Drawing.Size(223, 23);
            this.inputEtiquetaEquip.TabIndex = 8;
            // 
            // inputPrecoEquip
            // 
            this.inputPrecoEquip.Location = new System.Drawing.Point(246, 103);
            this.inputPrecoEquip.MaxLength = 10;
            this.inputPrecoEquip.Name = "inputPrecoEquip";
            this.inputPrecoEquip.PlaceholderText = "Valor pago";
            this.inputPrecoEquip.Size = new System.Drawing.Size(116, 23);
            this.inputPrecoEquip.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 10;
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
            this.selectMarcaEquip.Location = new System.Drawing.Point(241, 49);
            this.selectMarcaEquip.Name = "selectMarcaEquip";
            this.selectMarcaEquip.Size = new System.Drawing.Size(121, 23);
            this.selectMarcaEquip.TabIndex = 11;
            // 
            // btnNovoEquip
            // 
            this.btnNovoEquip.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovoEquip.ForeColor = System.Drawing.Color.Transparent;
            this.btnNovoEquip.Location = new System.Drawing.Point(40, 379);
            this.btnNovoEquip.Name = "btnNovoEquip";
            this.btnNovoEquip.Size = new System.Drawing.Size(118, 33);
            this.btnNovoEquip.TabIndex = 12;
            this.btnNovoEquip.Text = "Novo equipamento";
            this.btnNovoEquip.UseVisualStyleBackColor = false;
            // 
            // btnSalvarEquip
            // 
            this.btnSalvarEquip.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvarEquip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarEquip.Location = new System.Drawing.Point(164, 379);
            this.btnSalvarEquip.Name = "btnSalvarEquip";
            this.btnSalvarEquip.Size = new System.Drawing.Size(88, 33);
            this.btnSalvarEquip.TabIndex = 13;
            this.btnSalvarEquip.Text = "Salvar";
            this.btnSalvarEquip.UseVisualStyleBackColor = false;
            // 
            // btnEditarEquip
            // 
            this.btnEditarEquip.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditarEquip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarEquip.Location = new System.Drawing.Point(258, 379);
            this.btnEditarEquip.Name = "btnEditarEquip";
            this.btnEditarEquip.Size = new System.Drawing.Size(88, 33);
            this.btnEditarEquip.TabIndex = 14;
            this.btnEditarEquip.Text = "Editar";
            this.btnEditarEquip.UseVisualStyleBackColor = false;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.BackColor = System.Drawing.Color.Red;
            this.btnLimparCampos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparCampos.Location = new System.Drawing.Point(352, 379);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(104, 33);
            this.btnLimparCampos.TabIndex = 15;
            this.btnLimparCampos.Text = "Limpar campos";
            this.btnLimparCampos.UseVisualStyleBackColor = false;
            // 
            // CadEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 451);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnEditarEquip);
            this.Controls.Add(this.btnSalvarEquip);
            this.Controls.Add(this.btnNovoEquip);
            this.Controls.Add(this.selectMarcaEquip);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DataGridView dataGridView1;
        private ComboBox selectMarcaEquip;
        private Button btnNovoEquip;
        private Button btnSalvarEquip;
        private Button btnEditarEquip;
        private Button btnLimparCampos;
    }
}