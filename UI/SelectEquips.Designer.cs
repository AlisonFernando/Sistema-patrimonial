namespace UI
{
    partial class SelectEquips
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
            MostrarEquipsDisponiveis = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsDisponiveis).BeginInit();
            SuspendLayout();
            // 
            // MostrarEquipsDisponiveis
            // 
            MostrarEquipsDisponiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipsDisponiveis.Location = new Point(113, 12);
            MostrarEquipsDisponiveis.Name = "MostrarEquipsDisponiveis";
            MostrarEquipsDisponiveis.RowHeadersWidth = 62;
            MostrarEquipsDisponiveis.RowTemplate.Height = 33;
            MostrarEquipsDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarEquipsDisponiveis.Size = new Size(559, 225);
            MostrarEquipsDisponiveis.TabIndex = 0;
            MostrarEquipsDisponiveis.CellMouseDoubleClick += MostrarEquipsDisponiveis_CellMouseDoubleClick;
            // 
            // SelectEquips
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(MostrarEquipsDisponiveis);
            MaximizeBox = false;
            Name = "SelectEquips";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectEquips";
            ((System.ComponentModel.ISupportInitialize)MostrarEquipsDisponiveis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MostrarEquipsDisponiveis;
    }
}