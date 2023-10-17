using BLL;
using model;
using System.Data;

namespace UI
{
    public partial class TelaStatus : Form
    {
        public TelaStatus(Manutencao manutencao)
        {
            InitializeComponent();
            if (manutencao != null)
            {

                txtNomeEquipamento.Text = manutencao.NomeEquipamento;
                txtID.Text = manutencao.id_equipamento;

            }
        }
        private void CarregarStatusComboBox()
        {
            StatusBLL statusBLL = new StatusBLL();
            DataTable dt = statusBLL.CarregarStatus();

            ComboBoxStatus.DisplayMember = "andamento_do_chamado";
            ComboBoxStatus.ValueMember = "id_status";
            ComboBoxStatus.DataSource = dt;
        }

        private void TelaStatus_Load(object sender, EventArgs e)
        {
            CarregarStatusComboBox();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ComboBoxStatus.SelectedItem != null)
            {
                int idStatus = (int)ComboBoxStatus.SelectedValue;
                string nomeEquipamento = txtNomeEquipamento.Text;
                var id_equipamentoText = txtID.Text;
                var id_equipamento = Convert.ToInt32(id_equipamentoText);


                StatusBLL statusBLL = new StatusBLL();

                if (statusBLL.AtualizarStatusEquipamento(id_equipamento, idStatus))
                {
                    MessageBox.Show("Status atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha na atualização do status.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um status válido antes de aplicar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
