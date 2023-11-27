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
            CadUserMenu = new ToolStripMenuItem();
            setorToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            MenuInfoEquip = new ToolStripMenuItem();
            MenuUserCad = new ToolStripMenuItem();
            equipamentosEmManutençãoToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            MenuRelatorioEquip = new ToolStripMenuItem();
            MenuRelatorioPrecoEquip = new ToolStripMenuItem();
            MenuRelatorioColabAtivo = new ToolStripMenuItem();
            MenuEquips_e_Manutencao = new ToolStripMenuItem();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            MenuRedefinirSenha = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            MenuSair = new ToolStripMenuItem();
            HeaderDescricao = new ToolStrip();
            label = new ToolStripLabel();
            FooterPrincipal = new StatusStrip();
            Data = new ToolStripStatusLabel();
            Horario = new ToolStripStatusLabel();
            alison = new ToolStripStatusLabel();
            lblBoasVindas = new ToolStripStatusLabel();
            relogio = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            infoColaboradoresToolStripMenuItem = new ToolStripMenuItem();
            MenuPrincipal.SuspendLayout();
            HeaderDescricao.SuspendLayout();
            FooterPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.ImageScalingSize = new Size(24, 24);
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, visualizarToolStripMenuItem, relatóriosToolStripMenuItem, opçõesToolStripMenuItem, sairToolStripMenuItem });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(800, 24);
            MenuPrincipal.TabIndex = 0;
            MenuPrincipal.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuCadColaborador, MenuCadEquip, MenuCadChamado, marcaDeEquipamentoToolStripMenuItem, CadUserMenu, setorToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(69, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // MenuCadColaborador
            // 
            MenuCadColaborador.Name = "MenuCadColaborador";
            MenuCadColaborador.Size = new Size(197, 22);
            MenuCadColaborador.Text = "Colaboradores";
            MenuCadColaborador.Click += MenuCadColaborador_Click;
            // 
            // MenuCadEquip
            // 
            MenuCadEquip.Name = "MenuCadEquip";
            MenuCadEquip.Size = new Size(197, 22);
            MenuCadEquip.Text = "Equipamentos";
            MenuCadEquip.Click += MenuCadEquip_Click;
            // 
            // MenuCadChamado
            // 
            MenuCadChamado.Name = "MenuCadChamado";
            MenuCadChamado.Size = new Size(197, 22);
            MenuCadChamado.Text = "Chamado";
            MenuCadChamado.Click += MenuCadChamado_Click;
            // 
            // marcaDeEquipamentoToolStripMenuItem
            // 
            marcaDeEquipamentoToolStripMenuItem.Name = "marcaDeEquipamentoToolStripMenuItem";
            marcaDeEquipamentoToolStripMenuItem.Size = new Size(197, 22);
            marcaDeEquipamentoToolStripMenuItem.Text = "Marca de equipamento";
            marcaDeEquipamentoToolStripMenuItem.Click += marcaDeEquipamentoToolStripMenuItem_Click;
            // 
            // CadUserMenu
            // 
            CadUserMenu.Name = "CadUserMenu";
            CadUserMenu.RightToLeft = RightToLeft.No;
            CadUserMenu.Size = new Size(197, 22);
            CadUserMenu.Text = "Usuário";
            CadUserMenu.Click += CadUserMenu_Click;
            // 
            // setorToolStripMenuItem
            // 
            setorToolStripMenuItem.Name = "setorToolStripMenuItem";
            setorToolStripMenuItem.Size = new Size(197, 22);
            setorToolStripMenuItem.Text = "Setor";
            setorToolStripMenuItem.Click += setorToolStripMenuItem_Click;
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuInfoEquip, MenuUserCad, equipamentosEmManutençãoToolStripMenuItem, infoColaboradoresToolStripMenuItem });
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(68, 20);
            visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // MenuInfoEquip
            // 
            MenuInfoEquip.Name = "MenuInfoEquip";
            MenuInfoEquip.Size = new Size(240, 22);
            MenuInfoEquip.Text = "Info Equipamentos";
            MenuInfoEquip.Click += MenuInfoEquip_Click;
            // 
            // MenuUserCad
            // 
            MenuUserCad.Name = "MenuUserCad";
            MenuUserCad.Size = new Size(240, 22);
            MenuUserCad.Text = "Usuarios cadastrados";
            MenuUserCad.Click += MenuUserCad_Click;
            // 
            // equipamentosEmManutençãoToolStripMenuItem
            // 
            equipamentosEmManutençãoToolStripMenuItem.Name = "equipamentosEmManutençãoToolStripMenuItem";
            equipamentosEmManutençãoToolStripMenuItem.Size = new Size(240, 22);
            equipamentosEmManutençãoToolStripMenuItem.Text = "Equipamentos em manutenção";
            equipamentosEmManutençãoToolStripMenuItem.Click += equipamentosEmManutençãoToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuRelatorioEquip, MenuRelatorioPrecoEquip, MenuRelatorioColabAtivo, MenuEquips_e_Manutencao });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // MenuRelatorioEquip
            // 
            MenuRelatorioEquip.Name = "MenuRelatorioEquip";
            MenuRelatorioEquip.Size = new Size(293, 22);
            MenuRelatorioEquip.Text = "Qtd equipamentos";
            MenuRelatorioEquip.Click += MenuRelatorioEquip_Click;
            // 
            // MenuRelatorioPrecoEquip
            // 
            MenuRelatorioPrecoEquip.Name = "MenuRelatorioPrecoEquip";
            MenuRelatorioPrecoEquip.Size = new Size(293, 22);
            MenuRelatorioPrecoEquip.Text = "Preço equipamentos";
            MenuRelatorioPrecoEquip.Click += MenuRelatorioPrecoEquip_Click;
            // 
            // MenuRelatorioColabAtivo
            // 
            MenuRelatorioColabAtivo.Name = "MenuRelatorioColabAtivo";
            MenuRelatorioColabAtivo.Size = new Size(293, 22);
            MenuRelatorioColabAtivo.Text = "Colaboradores ativos";
            MenuRelatorioColabAtivo.Click += MenuRelatorioColabAtivo_Click;
            // 
            // MenuEquips_e_Manutencao
            // 
            MenuEquips_e_Manutencao.Name = "MenuEquips_e_Manutencao";
            MenuEquips_e_Manutencao.Size = new Size(293, 22);
            MenuEquips_e_Manutencao.Text = "Equipamentos associados ao colaborador";
            MenuEquips_e_Manutencao.Click += MenuEquips_e_Manutencao_Click;
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuRedefinirSenha });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // MenuRedefinirSenha
            // 
            MenuRedefinirSenha.Name = "MenuRedefinirSenha";
            MenuRedefinirSenha.Size = new Size(155, 22);
            MenuRedefinirSenha.Text = "Redefinir senha";
            MenuRedefinirSenha.Click += MenuRedefinirSenha_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuSair });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // MenuSair
            // 
            MenuSair.Name = "MenuSair";
            MenuSair.ShortcutKeys = Keys.F12;
            MenuSair.Size = new Size(118, 22);
            MenuSair.Text = "&Sair";
            MenuSair.Click += sairToolStripMenuItem1_Click;
            // 
            // HeaderDescricao
            // 
            HeaderDescricao.BackColor = Color.Green;
            HeaderDescricao.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderDescricao.ImageScalingSize = new Size(24, 24);
            HeaderDescricao.Items.AddRange(new ToolStripItem[] { label });
            HeaderDescricao.Location = new Point(0, 24);
            HeaderDescricao.Name = "HeaderDescricao";
            HeaderDescricao.Padding = new Padding(0, 0, 2, 0);
            HeaderDescricao.RightToLeft = RightToLeft.No;
            HeaderDescricao.Size = new Size(800, 25);
            HeaderDescricao.TabIndex = 1;
            HeaderDescricao.Text = "toolStrip1";
            // 
            // label
            // 
            label.BackColor = Color.FromArgb(128, 255, 128);
            label.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Name = "label";
            label.Size = new Size(459, 22);
            label.Text = "Sistema de controle patrimonial e de colaboradores da Scot Consultoria";
            // 
            // FooterPrincipal
            // 
            FooterPrincipal.ImageScalingSize = new Size(24, 24);
            FooterPrincipal.Items.AddRange(new ToolStripItem[] { Data, Horario, alison, lblBoasVindas });
            FooterPrincipal.Location = new Point(0, 428);
            FooterPrincipal.Name = "FooterPrincipal";
            FooterPrincipal.Size = new Size(800, 22);
            FooterPrincipal.TabIndex = 2;
            FooterPrincipal.Text = "statusStrip1";
            // 
            // Data
            // 
            Data.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Data.Name = "Data";
            Data.Size = new Size(73, 17);
            Data.Text = "Data atual";
            // 
            // Horario
            // 
            Horario.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Horario.Name = "Horario";
            Horario.Size = new Size(52, 17);
            Horario.Text = "horario";
            // 
            // alison
            // 
            alison.DisplayStyle = ToolStripItemDisplayStyle.Text;
            alison.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            alison.Name = "alison";
            alison.Size = new Size(226, 17);
            alison.Text = "Desenvolvido por: Alison Fernando";
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblBoasVindas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(72, 17);
            lblBoasVindas.Text = "Bem vindo";
            // 
            // relogio
            // 
            relogio.Enabled = true;
            relogio.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.Logotipo_Scotconsultoria__;
            pictureBox1.Location = new Point(0, 279);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // infoColaboradoresToolStripMenuItem
            // 
            infoColaboradoresToolStripMenuItem.Name = "infoColaboradoresToolStripMenuItem";
            infoColaboradoresToolStripMenuItem.Size = new Size(240, 22);
            infoColaboradoresToolStripMenuItem.Text = "Info Colaboradores";
            infoColaboradoresToolStripMenuItem.Click += infoColaboradoresToolStripMenuItem_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(FooterPrincipal);
            Controls.Add(HeaderDescricao);
            Controls.Add(MenuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuPrincipal;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += TelaPrincipal_Load;
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            HeaderDescricao.ResumeLayout(false);
            HeaderDescricao.PerformLayout();
            FooterPrincipal.ResumeLayout(false);
            FooterPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipal;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem MenuCadColaborador;
        private ToolStripMenuItem MenuCadEquip;
        private ToolStripMenuItem visualizarToolStripMenuItem;
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
        private ToolStripMenuItem MenuUserCad;
        private ToolStripMenuItem MenuCadChamado;
        private ToolStripMenuItem marcaDeEquipamentoToolStripMenuItem;
        private ToolStripMenuItem CadUserMenu;
        private PictureBox pictureBox1;
        private ToolStripMenuItem equipamentosEmManutençãoToolStripMenuItem;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem MenuRedefinirSenha;
        private ToolStripMenuItem MenuEquips_e_Manutencao;
        private ToolStripMenuItem setorToolStripMenuItem;
        private ToolStripStatusLabel lblBoasVindas;
        private ToolStripMenuItem infoColaboradoresToolStripMenuItem;
    }
}