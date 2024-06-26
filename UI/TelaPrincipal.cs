namespace UI
{
    public partial class TelaPrincipal : Form
    {
        private int UserChamado;
        private string UserEmail;
        public TelaPrincipal(int userChamado, string userEmail)
        {
            InitializeComponent();

            UserChamado = userChamado;

            if (UserChamado == 1)
            {
                // Código para administradores (ADM)
                MenuCadColaborador.Enabled = true;
                MenuCadEquip.Enabled = true;
                MenuCadChamado.Enabled = true;
                marcaDeEquipamentoToolStripMenuItem.Enabled = true;
                CadUserMenu.Enabled = true;
                //MenuInfoColaborador.Enabled = true;
                MenuInfoEquip.Enabled = true;
                MenuUserCad.Enabled = true;
                equipamentosEmManutençãoToolStripMenuItem.Enabled = true;
                MenuRelatorioColabAtivo.Enabled = true;
                MenuRelatorioEquip.Enabled = true;
                MenuRelatorioPrecoEquip.Enabled = true;
                MenuSair.Enabled = true;
                infoColaboradoresToolStripMenuItem.Enabled = true;
            }
            else if (UserChamado == 2)
            {
                // Código para Técnicos de Informatica (TI)
                MenuCadColaborador.Enabled = false;
                MenuCadEquip.Enabled = true;
                MenuCadChamado.Enabled = true;
                marcaDeEquipamentoToolStripMenuItem.Enabled = true;
                CadUserMenu.Enabled = false;
                //MenuInfoColaborador.Enabled = false;
                MenuInfoEquip.Enabled = true;
                MenuUserCad.Enabled = false;
                equipamentosEmManutençãoToolStripMenuItem.Enabled = true;
                MenuRelatorioColabAtivo.Enabled = false;
                MenuRelatorioEquip.Enabled = true;
                MenuRelatorioPrecoEquip.Enabled = true;
                MenuSair.Enabled = true;
                MenuRedefinirSenha.Enabled = false;
                infoColaboradoresToolStripMenuItem.Enabled = false;
            }
            UserEmail = userEmail;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Horario.Text = "Horário: " + DateTime.Now.ToLongTimeString();
            Data.Text = "Dia: " + DateTime.Now.ToLongDateString();
        }

        private void MenuCadColaborador_Click(object sender, EventArgs e)
        {
            UI.TelaVerColaboradores cadColaborador = new UI.TelaVerColaboradores();
            cadColaborador.ShowDialog();
        }

        private void MenuCadEquip_Click(object sender, EventArgs e)
        {
            UI.TelaVerEquips telaVerEquips = new UI.TelaVerEquips();
            telaVerEquips.ShowDialog();

        }

        private void MenuUserCad_Click(object sender, EventArgs e)
        {
            UI.VerUser verUser = new UI.VerUser();
            verUser.ShowDialog();
        }

        private void MenuCadChamado_Click(object sender, EventArgs e)
        {
            UI.TelaAbrirChamado abrirChamado = new UI.TelaAbrirChamado();
            abrirChamado.ShowDialog();
        }

        private void marcaDeEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.TelaCadastrarMarca telaCadastrarMarca = new UI.TelaCadastrarMarca();
            telaCadastrarMarca.ShowDialog();
        }

        private void CadUserMenu_Click(object sender, EventArgs e)
        {
            UI.VerUser verUser = new UI.VerUser();
            verUser.ShowDialog();
        }

        private void MenuInfoEquip_Click(object sender, EventArgs e)
        {
            UI.TelaVerEquips telaVerEquips = new UI.TelaVerEquips();
            telaVerEquips.ShowDialog();
        }

        private void equipamentosEmManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.TelaManutencao telaManutencao = new UI.TelaManutencao();
            telaManutencao.ShowDialog();
        }

        private void MenuRelatorioEquip_Click(object sender, EventArgs e)
        {
            UI.TelaRelatorioEquipsQTD telaRelatorioEquipsQTD = new TelaRelatorioEquipsQTD();
            telaRelatorioEquipsQTD.ShowDialog();
        }

        private void MenuRelatorioColabAtivo_Click(object sender, EventArgs e)
        {
            UI.RelatorioColaboradoresAtivos relatorioColaboradoresAtivos = new UI.RelatorioColaboradoresAtivos();
            relatorioColaboradoresAtivos.ShowDialog();
        }

        private void MenuRelatorioPrecoEquip_Click(object sender, EventArgs e)
        {
            UI.RelatorioEquipamentoPreco relatorioEquipamentoPreco = new RelatorioEquipamentoPreco();
            relatorioEquipamentoPreco.ShowDialog();
        }

        private void MenuRedefinirSenha_Click(object sender, EventArgs e)
        {
            UI.TelaEsqueciSenha telaEsqueciSenha = new TelaEsqueciSenha();
            telaEsqueciSenha.ShowDialog();
        }

        private void MenuEquips_e_Manutencao_Click(object sender, EventArgs e)
        {
            UI.RelatorioMasterDetail relatorioMasterDetail = new UI.RelatorioMasterDetail();
            relatorioMasterDetail.ShowDialog();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.TelaCadSetor telaCadSetor = new UI.TelaCadSetor();
            telaCadSetor.ShowDialog();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lblBoasVindas.Text = "Bem vindo, " + UserEmail;
        }

        private void infoColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.TelaVerColaboradores telaVerColaboradores = new UI.TelaVerColaboradores();
            telaVerColaboradores.ShowDialog();
        }
    }
}