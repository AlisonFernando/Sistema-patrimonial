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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeEquipamento
            // 
            txtNomeEquipamento.Enabled = false;
            txtNomeEquipamento.Location = new Point(13, 84);
            txtNomeEquipamento.MaxLength = 100;
            txtNomeEquipamento.Name = "txtNomeEquipamento";
            txtNomeEquipamento.Size = new Size(288, 31);
            txtNomeEquipamento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 56);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do equipamento";
            // 
            // ComboBoxStatus
            // 
            ComboBoxStatus.FormattingEnabled = true;
            ComboBoxStatus.Location = new Point(317, 82);
            ComboBoxStatus.Name = "ComboBoxStatus";
            ComboBoxStatus.Size = new Size(182, 33);
            ComboBoxStatus.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(btnAtualizar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 509);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 10, 9, 10);
            panel2.Size = new Size(637, 83);
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
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DarkGreen;
            btnAtualizar.Dock = DockStyle.Right;
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(421, 10);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(207, 63);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // TelaStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 592);
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
    }
}