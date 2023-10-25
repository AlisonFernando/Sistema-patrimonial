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

                // Verifique se manutencao.id_equipamento é um número inteiro válido
                if (int.TryParse(manutencao.id_equipamento, out int equipamentoId))
                {
                    txtID.Text = equipamentoId.ToString();
                }
                else
                {
                    // Lida com o cenário em que id_equipamento não é um número válido
                    txtID.Text = string.Empty; // Ou outra ação apropriada
                }

                txtData.Text = manutencao.DataChamado.ToString();
                txtUsuario.Text = manutencao.NomeUsuario;
                txtDesc.Text = manutencao.Descricao;
            }
        }

        private void CarregarStatusComboBox()
        {
            StatusBLL statusBLL = new StatusBLL();
            DataTable dt = statusBLL.CarregarStatus();

            ComboBoxStatus.DataSource = dt;
            ComboBoxStatus.DisplayMember = "andamento_do_chamado";
            ComboBoxStatus.ValueMember = "id_status";
            
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

                // Use int.TryParse para converter a string em um int
                if (int.TryParse(txtID.Text, out int id_equipamento))
                {
                    StatusBLL statusBLL = new StatusBLL();

                    if (statusBLL.AtualizarStatusEquipamento(id_equipamento, idStatus, Program.UserEmail))
                    {
                        MessageBox.Show("Status atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha na atualização do status.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O ID do equipamento não é um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um status válido antes de aplicar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
