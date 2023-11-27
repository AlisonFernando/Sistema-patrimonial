namespace UI
{
    partial class TelaStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaStatus));
            txtNomeEquipamento = new TextBox();
            label1 = new Label();
            ComboBoxStatus = new ComboBox();
            panel2 = new Panel();
            txtID = new TextBox();
            btnVoltar = new Button();
            btnAtualizar = new Button();
            txtDesc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuario = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtData = new DateTimePicker();
            txtColaboradorResponsavel = new TextBox();
            label6 = new Label();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeEquipamento
            // 
            txtNomeEquipamento.Enabled = false;
            txtNomeEquipamento.Location = new Point(88, 55);
            txtNomeEquipamento.MaxLength = 100;
            txtNomeEquipamento.Name = "txtNomeEquipamento";
            txtNomeEquipamento.Size = new Size(288, 31);
            txtNomeEquipamento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 27);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do equipamento";
            // 
            // ComboBoxStatus
            // 
            ComboBoxStatus.FormattingEnabled = true;
            ComboBoxStatus.Location = new Point(395, 127);
            ComboBoxStatus.Name = "ComboBoxStatus";
            ComboBoxStatus.Size = new Size(209, 33);
            ComboBoxStatus.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(btnAtualizar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 611);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(677, 83);
            panel2.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(222, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(123, 31);
            txtID.TabIndex = 2;
            txtID.Visible = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Dock = DockStyle.Left;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(9, 10);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(207, 63);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DarkGreen;
            btnAtualizar.Dock = DockStyle.Right;
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(461, 10);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(207, 63);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(74, 308);
            txtDesc.MaxLength = 10000;
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(515, 266);
            txtDesc.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 27);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 6;
            label2.Text = "Data e hora do chamado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 99);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 7;
            label3.Text = "Selecionar novo status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 280);
            label4.Name = "label4";
            label4.Size = new Size(216, 25);
            label4.TabIndex = 8;
            label4.Text = "Descricao da manutenção";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 99);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 10;
            label5.Text = "Técnico responsável";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(89, 129);
            txtUsuario.MaxLength = 100;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(286, 31);
            txtUsuario.TabIndex = 9;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(617, 124);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(8, 8);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(0, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(0, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            txtData.CustomFormat = "dd/MM/yyyy HH:mm";
            txtData.Enabled = false;
            txtData.Format = DateTimePickerFormat.Custom;
            txtData.Location = new Point(395, 55);
            txtData.Name = "txtData";
            txtData.Size = new Size(209, 31);
            txtData.TabIndex = 12;
            // 
            // txtColaboradorResponsavel
            // 
            txtColaboradorResponsavel.Enabled = false;
            txtColaboradorResponsavel.Location = new Point(88, 201);
            txtColaboradorResponsavel.Name = "txtColaboradorResponsavel";
            txtColaboradorResponsavel.Size = new Size(288, 31);
            txtColaboradorResponsavel.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 173);
            label6.Name = "label6";
            label6.Size = new Size(211, 25);
            label6.TabIndex = 14;
            label6.Text = "Colaborador responsável";
            // 
            // TelaStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 694);
            Controls.Add(label6);
            Controls.Add(txtColaboradorResponsavel);
            Controls.Add(txtData);
            Controls.Add(tabControl1);
            Controls.Add(label5);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDesc);
            Controls.Add(panel2);
            Controls.Add(ComboBoxStatus);
            Controls.Add(label1);
            Controls.Add(txtNomeEquipamento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Status";
            Load += TelaStatus_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeEquipamento;
        private Label label1;
        private ComboBox ComboBoxStatus;
        private Panel panel2;
        private Button btnVoltar;
        private Button btnAtualizar;
        private TextBox txtID;
        private TextBox txtDesc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuario;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker txtData;
        private TextBox txtColaboradorResponsavel;
        private Label label6;
    }
}