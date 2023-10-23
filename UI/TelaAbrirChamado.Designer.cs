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
            btnVoltar = new Button();
            btnCadUserSucesso = new Button();
            btn_limpar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            selectEtiqueta = new ComboBox();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEquip = new TextBox();
            label5 = new Label();
            btn_pesquisar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            selectUser = new ComboBox();
            label7 = new Label();
            selectChamado = new ComboBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(btnCadUserSucesso);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 646);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(627, 83);
            panel2.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Dock = DockStyle.Left;
            btnVoltar.ForeColor = SystemColors.Control;
            btnVoltar.Location = new Point(9, 10);
            btnVoltar.Margin = new Padding(4, 5, 4, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(214, 63);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadUserSucesso
            // 
            btnCadUserSucesso.BackColor = Color.DarkGreen;
            btnCadUserSucesso.Dock = DockStyle.Right;
            btnCadUserSucesso.ForeColor = SystemColors.Control;
            btnCadUserSucesso.Location = new Point(404, 10);
            btnCadUserSucesso.Margin = new Padding(4, 5, 4, 5);
            btnCadUserSucesso.Name = "btnCadUserSucesso";
            btnCadUserSucesso.Size = new Size(214, 63);
            btnCadUserSucesso.TabIndex = 1;
            btnCadUserSucesso.Text = "Abrir chamado";
            btnCadUserSucesso.UseVisualStyleBackColor = false;
            btnCadUserSucesso.Click += btnCadUserSucesso_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.DarkGreen;
            btn_limpar.ForeColor = SystemColors.Control;
            btn_limpar.Location = new Point(20, 319);
            btn_limpar.Margin = new Padding(4, 5, 4, 5);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(100, 34);
            btn_limpar.TabIndex = 23;
            btn_limpar.Text = "Limpar ";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 83);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(196, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 41);
            label1.TabIndex = 0;
            label1.Text = "Abrir chamado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectEtiqueta
            // 
            selectEtiqueta.FormattingEnabled = true;
            selectEtiqueta.Location = new Point(17, 137);
            selectEtiqueta.Margin = new Padding(4, 5, 4, 5);
            selectEtiqueta.Name = "selectEtiqueta";
            selectEtiqueta.Size = new Size(148, 33);
            selectEtiqueta.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(307, 25);
            label2.TabIndex = 14;
            label2.Text = "Selecione a etiqueta do equipamento";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(13, 393);
            txtDesc.Margin = new Padding(4, 5, 4, 5);
            txtDesc.MaxLength = 10000;
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(601, 243);
            txtDesc.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 363);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(267, 25);
            label3.TabIndex = 16;
            label3.Text = "Descreva o motivo do chamado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 173);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 17;
            label4.Text = "Técnico responsável";
            // 
            // txtEquip
            // 
            txtEquip.Location = new Point(20, 205);
            txtEquip.Margin = new Padding(4, 5, 4, 5);
            txtEquip.Name = "txtEquip";
            txtEquip.ReadOnly = true;
            txtEquip.Size = new Size(305, 31);
            txtEquip.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(199, 25);
            label5.TabIndex = 21;
            label5.Text = "Nome do equipamento";
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.BackColor = Color.Transparent;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.ForeColor = SystemColors.Control;
            btn_pesquisar.Image = Properties.Resources.lupaaa;
            btn_pesquisar.Location = new Point(173, 137);
            btn_pesquisar.Margin = new Padding(4, 5, 4, 5);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(30, 35);
            btn_pesquisar.TabIndex = 22;
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(331, 135);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 31);
            dateTimePicker1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 107);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(238, 25);
            label6.TabIndex = 25;
            label6.Text = "Selecionar data do chamado";
            // 
            // selectUser
            // 
            selectUser.FormattingEnabled = true;
            selectUser.Location = new Point(331, 203);
            selectUser.Name = "selectUser";
            selectUser.Size = new Size(285, 33);
            selectUser.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 252);
            label7.Name = "label7";
            label7.Size = new Size(172, 25);
            label7.TabIndex = 27;
            label7.Text = "Estado do chamado";
            // 
            // selectChamado
            // 
            selectChamado.FormattingEnabled = true;
            selectChamado.Location = new Point(20, 278);
            selectChamado.Name = "selectChamado";
            selectChamado.Size = new Size(183, 33);
            selectChamado.TabIndex = 28;
            // 
            // TelaAbrirChamado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 729);
            Controls.Add(selectChamado);
            Controls.Add(btn_limpar);
            Controls.Add(label7);
            Controls.Add(selectUser);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_pesquisar);
            Controls.Add(label5);
            Controls.Add(txtEquip);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(label2);
            Controls.Add(selectEtiqueta);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "TelaAbrirChamado";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtDesc;
        private Label label3;
        private Label label4;
        private ComboBox selectChamado;
        private Button btnCadUserSucesso;
        private TextBox txtEquip;
        private Label label5;
        private Button btn_pesquisar;
        public Button btn_limpar;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox selectUser;
        private Label label7;
        private Button btnVoltar;
    }
}