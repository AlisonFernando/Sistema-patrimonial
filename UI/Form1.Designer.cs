namespace UI
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadEquip = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInfoColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInfoEquip = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioEquip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioPrecoEquip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioColabAtivo = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.Horario = new System.Windows.Forms.ToolStripStatusLabel();
            this.alison = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadColaborador,
            this.MenuCadEquip});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // MenuCadColaborador
            // 
            this.MenuCadColaborador.Name = "MenuCadColaborador";
            this.MenuCadColaborador.Size = new System.Drawing.Size(151, 22);
            this.MenuCadColaborador.Text = "Colaboradores";
            this.MenuCadColaborador.Click += new System.EventHandler(this.MenuCadColaborador_Click);
            // 
            // MenuCadEquip
            // 
            this.MenuCadEquip.Name = "MenuCadEquip";
            this.MenuCadEquip.Size = new System.Drawing.Size(151, 22);
            this.MenuCadEquip.Text = "Equipamentos";
            this.MenuCadEquip.Click += new System.EventHandler(this.MenuCadEquip_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInfoColaborador,
            this.MenuInfoEquip});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // MenuInfoColaborador
            // 
            this.MenuInfoColaborador.Name = "MenuInfoColaborador";
            this.MenuInfoColaborador.Size = new System.Drawing.Size(175, 22);
            this.MenuInfoColaborador.Text = "Info Colaboradores";
            // 
            // MenuInfoEquip
            // 
            this.MenuInfoEquip.Name = "MenuInfoEquip";
            this.MenuInfoEquip.Size = new System.Drawing.Size(175, 22);
            this.MenuInfoEquip.Text = "Info Equipamentos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRelatorioEquip,
            this.MenuRelatorioPrecoEquip,
            this.MenuRelatorioColabAtivo});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // MenuRelatorioEquip
            // 
            this.MenuRelatorioEquip.Name = "MenuRelatorioEquip";
            this.MenuRelatorioEquip.Size = new System.Drawing.Size(185, 22);
            this.MenuRelatorioEquip.Text = "Qtd equipamentos";
            // 
            // MenuRelatorioPrecoEquip
            // 
            this.MenuRelatorioPrecoEquip.Name = "MenuRelatorioPrecoEquip";
            this.MenuRelatorioPrecoEquip.Size = new System.Drawing.Size(185, 22);
            this.MenuRelatorioPrecoEquip.Text = "Preço equipamentos";
            // 
            // MenuRelatorioColabAtivo
            // 
            this.MenuRelatorioColabAtivo.Name = "MenuRelatorioColabAtivo";
            this.MenuRelatorioColabAtivo.Size = new System.Drawing.Size(185, 22);
            this.MenuRelatorioColabAtivo.Text = "Colaboradores ativos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSair});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.MenuSair.Size = new System.Drawing.Size(118, 22);
            this.MenuSair.Text = "&Sair";
            this.MenuSair.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Green;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(459, 22);
            this.label.Text = "Sistema de controle patrimonial e de colaboradores da Scot Consultoria";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Data,
            this.Horario,
            this.alison});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(73, 17);
            this.Data.Text = "Data atual";
            // 
            // Horario
            // 
            this.Horario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(52, 17);
            this.Horario.Text = "horario";
            // 
            // alison
            // 
            this.alison.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alison.Name = "alison";
            this.alison.Size = new System.Drawing.Size(226, 17);
            this.alison.Text = "Desenvolvido por: Alison Fernando";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem MenuCadColaborador;
        private ToolStripMenuItem MenuCadEquip;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem MenuInfoColaborador;
        private ToolStripMenuItem MenuInfoEquip;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem MenuRelatorioEquip;
        private ToolStripMenuItem MenuRelatorioPrecoEquip;
        private ToolStripMenuItem MenuSair;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel alison;
        private ToolStripStatusLabel Horario;
        private ToolStripStatusLabel Data;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem MenuRelatorioColabAtivo;
        private ToolStripLabel label;
    }
}