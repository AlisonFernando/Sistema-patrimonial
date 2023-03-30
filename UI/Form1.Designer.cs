namespace UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoEquipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qtdEquipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.investEquipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresAtivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Colaboradores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Equipamentos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Relatorios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Sair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradoresToolStripMenuItem,
            this.equipamentosToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            // 
            // equipamentosToolStripMenuItem
            // 
            this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.equipamentosToolStripMenuItem.Text = "Equipamentos";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoColaboradoresToolStripMenuItem,
            this.infoEquipamentosToolStripMenuItem});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // infoColaboradoresToolStripMenuItem
            // 
            this.infoColaboradoresToolStripMenuItem.Name = "infoColaboradoresToolStripMenuItem";
            this.infoColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.infoColaboradoresToolStripMenuItem.Text = "Info Colaboradores";
            // 
            // infoEquipamentosToolStripMenuItem
            // 
            this.infoEquipamentosToolStripMenuItem.Name = "infoEquipamentosToolStripMenuItem";
            this.infoEquipamentosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.infoEquipamentosToolStripMenuItem.Text = "Info Equipamentos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qtdEquipamentosToolStripMenuItem,
            this.investEquipamentosToolStripMenuItem,
            this.colaboradoresAtivosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // qtdEquipamentosToolStripMenuItem
            // 
            this.qtdEquipamentosToolStripMenuItem.Name = "qtdEquipamentosToolStripMenuItem";
            this.qtdEquipamentosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.qtdEquipamentosToolStripMenuItem.Text = "Qtd equipamentos";
            // 
            // investEquipamentosToolStripMenuItem
            // 
            this.investEquipamentosToolStripMenuItem.Name = "investEquipamentosToolStripMenuItem";
            this.investEquipamentosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.investEquipamentosToolStripMenuItem.Text = "Preço equipamentos";
            this.investEquipamentosToolStripMenuItem.Click += new System.EventHandler(this.investEquipamentosToolStripMenuItem_Click);
            // 
            // colaboradoresAtivosToolStripMenuItem
            // 
            this.colaboradoresAtivosToolStripMenuItem.Name = "colaboradoresAtivosToolStripMenuItem";
            this.colaboradoresAtivosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.colaboradoresAtivosToolStripMenuItem.Text = "Colaboradores ativos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.sairToolStripMenuItem1.Text = "&Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Colaboradores,
            this.toolStripSeparator1,
            this.Equipamentos,
            this.toolStripSeparator2,
            this.Relatorios,
            this.toolStripSeparator3,
            this.Sair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 86);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Colaboradores
            // 
            this.Colaboradores.Image = ((System.Drawing.Image)(resources.GetObject("Colaboradores.Image")));
            this.Colaboradores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Colaboradores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Colaboradores.Name = "Colaboradores";
            this.Colaboradores.Size = new System.Drawing.Size(88, 83);
            this.Colaboradores.Text = "Colaboradores";
            this.Colaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Colaboradores.Click += new System.EventHandler(this.Colaboradores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // Equipamentos
            // 
            this.Equipamentos.Image = ((System.Drawing.Image)(resources.GetObject("Equipamentos.Image")));
            this.Equipamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Equipamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Equipamentos.Name = "Equipamentos";
            this.Equipamentos.Size = new System.Drawing.Size(87, 83);
            this.Equipamentos.Text = "Equipamentos";
            this.Equipamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Equipamentos.Click += new System.EventHandler(this.Equipamentos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
            // 
            // Relatorios
            // 
            this.Relatorios.Image = ((System.Drawing.Image)(resources.GetObject("Relatorios.Image")));
            this.Relatorios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Relatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(68, 83);
            this.Relatorios.Text = "Relatórios";
            this.Relatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 86);
            // 
            // Sair
            // 
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(68, 83);
            this.Sair.Text = "Deslogar";
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sair.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private ToolStripMenuItem colaboradoresToolStripMenuItem;
        private ToolStripMenuItem equipamentosToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem infoColaboradoresToolStripMenuItem;
        private ToolStripMenuItem infoEquipamentosToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem qtdEquipamentosToolStripMenuItem;
        private ToolStripMenuItem investEquipamentosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripButton Equipamentos;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem colaboradoresAtivosToolStripMenuItem;
        private ToolStripButton Colaboradores;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Relatorios;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Sair;
    }
}