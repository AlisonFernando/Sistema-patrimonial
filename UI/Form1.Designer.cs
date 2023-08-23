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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            MenuPrincipal = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            MenuCadColaborador = new ToolStripMenuItem();
            MenuCadEquip = new ToolStripMenuItem();
            MenuCadChamado = new ToolStripMenuItem();
            marcaDeEquipamentoToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            MenuInfoColaborador = new ToolStripMenuItem();
            MenuInfoEquip = new ToolStripMenuItem();
            MenuUserCad = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            MenuRelatorioEquip = new ToolStripMenuItem();
            MenuRelatorioPrecoEquip = new ToolStripMenuItem();
            MenuRelatorioColabAtivo = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            MenuSair = new ToolStripMenuItem();
            HeaderDescricao = new ToolStrip();
            label = new ToolStripLabel();
            FooterPrincipal = new StatusStrip();
            Data = new ToolStripStatusLabel();
            Horario = new ToolStripStatusLabel();
            alison = new ToolStripStatusLabel();
            relogio = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            CadUserMenu = new ToolStripMenuItem();
            MenuPrincipal.SuspendLayout();
            HeaderDescricao.SuspendLayout();
            FooterPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.ImageScalingSize = new Size(24, 24);
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, visualizarToolStripMenuItem, relatóriosToolStripMenuItem, sairToolStripMenuItem });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Padding = new Padding(9, 3, 0, 3);
            MenuPrincipal.Size = new Size(1143, 35);
            MenuPrincipal.TabIndex = 0;
            MenuPrincipal.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuCadColaborador, MenuCadEquip, MenuCadChamado, marcaDeEquipamentoToolStripMenuItem, CadUserMenu });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(103, 29);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // MenuCadColaborador
            // 
            MenuCadColaborador.Name = "MenuCadColaborador";
            MenuCadColaborador.Size = new Size(298, 34);
            MenuCadColaborador.Text = "Colaboradores";
            MenuCadColaborador.Click += MenuCadColaborador_Click;
            // 
            // MenuCadEquip
            // 
            MenuCadEquip.Name = "MenuCadEquip";
            MenuCadEquip.Size = new Size(298, 34);
            MenuCadEquip.Text = "Equipamentos";
            MenuCadEquip.Click += MenuCadEquip_Click;
            // 
            // MenuCadChamado
            // 
            MenuCadChamado.Name = "MenuCadChamado";
            MenuCadChamado.Size = new Size(298, 34);
            MenuCadChamado.Text = "Chamado";
            MenuCadChamado.Click += MenuCadChamado_Click;
            // 
            // marcaDeEquipamentoToolStripMenuItem
            // 
            marcaDeEquipamentoToolStripMenuItem.Name = "marcaDeEquipamentoToolStripMenuItem";
            marcaDeEquipamentoToolStripMenuItem.Size = new Size(298, 34);
            marcaDeEquipamentoToolStripMenuItem.Text = "Marca de equipamento";
            marcaDeEquipamentoToolStripMenuItem.Click += marcaDeEquipamentoToolStripMenuItem_Click;
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuInfoColaborador, MenuInfoEquip, MenuUserCad });
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(101, 29);
            visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // MenuInfoColaborador
            // 
            MenuInfoColaborador.Name = "MenuInfoColaborador";
            MenuInfoColaborador.Size = new Size(283, 34);
            MenuInfoColaborador.Text = "Info Colaboradores";
            // 
            // MenuInfoEquip
            // 
            MenuInfoEquip.Name = "MenuInfoEquip";
            MenuInfoEquip.Size = new Size(283, 34);
            MenuInfoEquip.Text = "Info Equipamentos";
            // 
            // MenuUserCad
            // 
            MenuUserCad.Name = "MenuUserCad";
            MenuUserCad.Size = new Size(283, 34);
            MenuUserCad.Text = "Usuarios cadastrados";
            MenuUserCad.Click += MenuUserCad_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuRelatorioEquip, MenuRelatorioPrecoEquip, MenuRelatorioColabAtivo });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(106, 29);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // MenuRelatorioEquip
            // 
            MenuRelatorioEquip.Name = "MenuRelatorioEquip";
            MenuRelatorioEquip.Size = new Size(283, 34);
            MenuRelatorioEquip.Text = "Qtd equipamentos";
            // 
            // MenuRelatorioPrecoEquip
            // 
            MenuRelatorioPrecoEquip.Name = "MenuRelatorioPrecoEquip";
            MenuRelatorioPrecoEquip.Size = new Size(283, 34);
            MenuRelatorioPrecoEquip.Text = "Preço equipamentos";
            // 
            // MenuRelatorioColabAtivo
            // 
            MenuRelatorioColabAtivo.Name = "MenuRelatorioColabAtivo";
            MenuRelatorioColabAtivo.Size = new Size(283, 34);
            MenuRelatorioColabAtivo.Text = "Colaboradores ativos";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuSair });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(57, 29);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // MenuSair
            // 
            MenuSair.Name = "MenuSair";
            MenuSair.ShortcutKeys = Keys.F12;
            MenuSair.Size = new Size(184, 34);
            MenuSair.Text = "&Sair";
            MenuSair.Click += sairToolStripMenuItem1_Click;
            // 
            // HeaderDescricao
            // 
            HeaderDescricao.BackColor = Color.Green;
            HeaderDescricao.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderDescricao.ImageScalingSize = new Size(24, 24);
            HeaderDescricao.Items.AddRange(new ToolStripItem[] { label });
            HeaderDescricao.Location = new Point(0, 35);
            HeaderDescricao.Name = "HeaderDescricao";
            HeaderDescricao.Padding = new Padding(0, 0, 3, 0);
            HeaderDescricao.RightToLeft = RightToLeft.No;
            HeaderDescricao.Size = new Size(1143, 27);
            HeaderDescricao.TabIndex = 1;
            HeaderDescricao.Text = "toolStrip1";
            // 
            // label
            // 
            label.BackColor = Color.FromArgb(128, 255, 128);
            label.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Name = "label";
            label.Size = new Size(658, 22);
            label.Text = "Sistema de controle patrimonial e de colaboradores da Scot Consultoria";
            // 
            // FooterPrincipal
            // 
            FooterPrincipal.ImageScalingSize = new Size(24, 24);
            FooterPrincipal.Items.AddRange(new ToolStripItem[] { Data, Horario, alison });
            FooterPrincipal.Location = new Point(0, 721);
            FooterPrincipal.Name = "FooterPrincipal";
            FooterPrincipal.Padding = new Padding(1, 0, 20, 0);
            FooterPrincipal.Size = new Size(1143, 29);
            FooterPrincipal.TabIndex = 2;
            FooterPrincipal.Text = "statusStrip1";
            // 
            // Data
            // 
            Data.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Data.Name = "Data";
            Data.Size = new Size(104, 22);
            Data.Text = "Data atual";
            // 
            // Horario
            // 
            Horario.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Horario.Name = "Horario";
            Horario.Size = new Size(75, 22);
            Horario.Text = "horario";
            // 
            // alison
            // 
            alison.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            alison.Name = "alison";
            alison.Size = new Size(324, 22);
            alison.Text = "Desenvolvido por: Alison Fernando";
            // 
            // relogio
            // 
            relogio.Enabled = true;
            relogio.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 108);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(389, 85);
            dataGridView1.TabIndex = 3;
            // 
            // CadUserMenu
            // 
            CadUserMenu.Name = "CadUserMenu";
            CadUserMenu.RightToLeft = RightToLeft.No;
            CadUserMenu.Size = new Size(298, 34);
            CadUserMenu.Text = "Usuário";
            CadUserMenu.Click += CadUserMenu_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dataGridView1);
            Controls.Add(FooterPrincipal);
            Controls.Add(HeaderDescricao);
            Controls.Add(MenuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuPrincipal;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            HeaderDescricao.ResumeLayout(false);
            HeaderDescricao.PerformLayout();
            FooterPrincipal.ResumeLayout(false);
            FooterPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipal;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem MenuCadColaborador;
        private ToolStripMenuItem MenuCadEquip;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem MenuInfoColaborador;
        private ToolStripMenuItem MenuInfoEquip;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStrip HeaderDescricao;
        private ToolStripMenuItem MenuRelatorioEquip;
        private ToolStripMenuItem MenuRelatorioPrecoEquip;
        private ToolStripMenuItem MenuSair;
        private StatusStrip FooterPrincipal;
        private ToolStripStatusLabel alison;
        private ToolStripStatusLabel Horario;
        private ToolStripStatusLabel Data;
        private System.Windows.Forms.Timer relogio;
        private ToolStripMenuItem MenuRelatorioColabAtivo;
        private ToolStripLabel label;
        private DataGridView dataGridView1;
        private ToolStripMenuItem MenuUserCad;
        private ToolStripMenuItem MenuCadChamado;
        private ToolStripMenuItem marcaDeEquipamentoToolStripMenuItem;
        private ToolStripMenuItem CadUserMenu;
    }
}