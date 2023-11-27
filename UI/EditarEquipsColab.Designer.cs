namespace UI
{
    partial class EditarEquipsColab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEquipsColab));
            HeaderCadColab = new Panel();
            label1 = new Label();
            MostrarEquipsColaborador = new DataGridView();
            FotterCadColab = new Panel();
            txtID = new TextBox();
            btn_selectEquips = new Button();
            btnVoltar = new Button();
            btnDesvincular = new Button();
            HeaderCadColab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsColaborador).BeginInit();
            FotterCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Margin = new Padding(4, 5, 4, 5);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(800, 83);
            HeaderCadColab.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(170, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(435, 32);
            label1.TabIndex = 91;
            label1.Text = "Editar equipamentos do colaborador";
            // 
            // MostrarEquipsColaborador
            // 
            MostrarEquipsColaborador.AllowUserToAddRows = false;
            MostrarEquipsColaborador.AllowUserToDeleteRows = false;
            MostrarEquipsColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsColaborador.Location = new Point(73, 130);
            MostrarEquipsColaborador.Name = "MostrarEquipsColaborador";
            MostrarEquipsColaborador.ReadOnly = true;
            MostrarEquipsColaborador.RowHeadersWidth = 62;
            MostrarEquipsColaborador.RowTemplate.Height = 33;
            MostrarEquipsColaborador.Size = new Size(643, 291);
            MostrarEquipsColaborador.TabIndex = 18;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(txtID);
            FotterCadColab.Controls.Add(btn_selectEquips);
            FotterCadColab.Controls.Add(btnVoltar);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 615);
            FotterCadColab.Margin = new Padding(4, 5, 4, 5);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(9, 10, 9, 10);
            FotterCadColab.Size = new Size(800, 93);
            FotterCadColab.TabIndex = 19;
            // 
            // txtID
            // 
            txtID.Location = new Point(230, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(135, 31);
            txtID.TabIndex = 24;
            txtID.Visible = false;
            // 
            // btn_selectEquips
            // 
            btn_selectEquips.BackColor = Color.DarkGreen;
            btn_selectEquips.Dock = DockStyle.Right;
            btn_selectEquips.ForeColor = Color.White;
            btn_selectEquips.Location = new Point(571, 10);
            btn_selectEquips.Margin = new Padding(4, 5, 4, 5);
            btn_selectEquips.Name = "btn_selectEquips";
            btn_selectEquips.Size = new Size(220, 73);
            btn_selectEquips.TabIndex = 7;
            btn_selectEquips.Text = "Selecionar equipamentos";
            btn_selectEquips.UseVisualStyleBackColor = false;
            btn_selectEquips.Click += btn_selectEquips_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Dock = DockStyle.Left;
            btnVoltar.ForeColor = SystemColors.Control;
            btnVoltar.Location = new Point(9, 10);
            btnVoltar.Margin = new Padding(4, 5, 4, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(214, 73);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnDesvincular
            // 
            btnDesvincular.BackColor = Color.DarkGreen;
            btnDesvincular.ForeColor = Color.White;
            btnDesvincular.Location = new Point(73, 427);
            btnDesvincular.Name = "btnDesvincular";
            btnDesvincular.Size = new Size(226, 41);
            btnDesvincular.TabIndex = 101;
            btnDesvincular.Text = "Desvincular equipamento";
            btnDesvincular.UseVisualStyleBackColor = false;
            btnDesvincular.Click += btnDesvincular_Click;
            // 
            // EditarEquipsColab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 708);
            Controls.Add(btnDesvincular);
            Controls.Add(FotterCadColab);
            Controls.Add(MostrarEquipsColaborador);
            Controls.Add(HeaderCadColab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditarEquipsColab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar equipamento do colaborador";
            Load += EditarEquipsColab_Load;
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsColaborador).EndInit();
            FotterCadColab.ResumeLayout(false);
            FotterCadColab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderCadColab;
        private Label label1;
        private DataGridView MostrarEquipsColaborador;
        private Panel FotterCadColab;
        private TextBox txtID;
        private Button btn_selectEquips;
        private Button btnVoltar;
        private Button btnDesvincular;
    }
}