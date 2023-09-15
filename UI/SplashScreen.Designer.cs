namespace UI
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            SysPatrimonial = new Label();
            versao = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.AccessibleRole = AccessibleRole.MenuBar;
            progressBar1.Cursor = Cursors.WaitCursor;
            progressBar1.Location = new Point(91, 438);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(416, 34);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            progressBar1.UseWaitCursor = true;
            // 
            // SysPatrimonial
            // 
            SysPatrimonial.AutoSize = true;
            SysPatrimonial.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SysPatrimonial.ForeColor = Color.DarkGreen;
            SysPatrimonial.Location = new Point(184, 390);
            SysPatrimonial.Name = "SysPatrimonial";
            SysPatrimonial.Size = new Size(225, 45);
            SysPatrimonial.TabIndex = 1;
            SysPatrimonial.Text = "SysPatrimonial";
            // 
            // versao
            // 
            versao.AutoSize = true;
            versao.ForeColor = Color.DarkGreen;
            versao.Location = new Point(274, 490);
            versao.Name = "versao";
            versao.Size = new Size(47, 25);
            versao.TabIndex = 2;
            versao.Text = "V1.0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_r_sys;
            pictureBox1.Location = new Point(190, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.ForeColor = Color.DarkGreen;
            panel1.Location = new Point(-14, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 97);
            panel1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(596, 543);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(versao);
            Controls.Add(SysPatrimonial);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label SysPatrimonial;
        private Label versao;
        private PictureBox pictureBox1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}