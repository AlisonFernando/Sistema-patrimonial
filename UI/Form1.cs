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
            UI.CadEquip cadEquip = new UI.CadEquip();
            cadEquip.ShowDialog();

        }

        private void MenuUserCad_Click(object sender, EventArgs e)
        {
            UI.VerUser verUser = new UI.VerUser();
            verUser.ShowDialog();
        }
    }
}