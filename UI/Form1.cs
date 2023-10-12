namespace UI
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
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
            UI.CadColaborador cadColaborador = new UI.CadColaborador();
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

        private void MenuRelatorioPrecoEquip_Click(object sender, EventArgs e)
        {
            UI.TelaRelatorioEquip telaRelatorioEquip = new UI.TelaRelatorioEquip();
            telaRelatorioEquip.ShowDialog();

        }

        private void MenuRelatorioColabAtivo_Click(object sender, EventArgs e)
        {
            UI.RelatorioColaboradoresAtivos relatorioColaboradoresAtivos = new UI.RelatorioColaboradoresAtivos();
            relatorioColaboradoresAtivos.ShowDialog();
        }
    }
}