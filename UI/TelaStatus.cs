using BLL;
using model;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class TelaStatus : Form
    {
        StatusBLL statusBLL = new StatusBLL();
        Manutencao manutencao = new Manutencao();
        // TelaStatus
        public TelaStatus(Manutencao manutencao, int idStatusEquipamento)
        {
            InitializeComponent();
            CarregarStatusComboBox(idStatusEquipamento);
            if (manutencao != null)
            {
                txtNomeEquipamento.Text = manutencao.NomeEquipamento;
                txtColaboradorResponsavel.Text = manutencao.NomeColaborador;

                if (int.TryParse(manutencao.id_equipamento, out int equipamentoId))
                {
                    txtID.Text = equipamentoId.ToString();
                }
                else
                {
                    txtID.Text = string.Empty;
                }

                txtData.Text = manutencao.DataChamado.ToString();
                txtUsuario.Text = manutencao.NomeUsuario;
                txtDesc.Text = manutencao.Descricao;
                txtColaboradorResponsavel.Text = manutencao.NomeColaborador.ToString();

                // Obtém o nome do status correspondente ao id_status da tb_manutencao
                string nomeStatusAtual = ObterNomeStatus(manutencao.id_status);

                // Carrega o ComboBoxStatus com os status disponíveis
                CarregarStatusComboBox(manutencao.id_status);
            }
        }

        private void CarregarStatusComboBox(int idStatusEquipamento)
        {
            StatusBLL statusBLL = new StatusBLL();
            DataTable dt = statusBLL.CarregarStatus();

            ComboBoxStatus.DataSource = dt;
            ComboBoxStatus.DisplayMember = "andamento_do_chamado";
            ComboBoxStatus.ValueMember = "id_status";

            // Define o status atual do equipamento no ComboBox
            ComboBoxStatus.SelectedValue = idStatusEquipamento;
        }

        private string ObterNomeStatus(int idStatus)
        {
            StatusBLL statusBLL = new StatusBLL();
            return statusBLL.ObterNomeStatusPorId(idStatus);
        }

        private void TelaStatus_Load(object sender, EventArgs e)
        {
            CarregarStatusComboBox(0); // Carrega o ComboBox com os status disponíveis
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
                string novaDescricao = txtDesc.Text;

                // Use int.TryParse para converter a string em um int
                if (int.TryParse(txtID.Text, out int id_equipamento))
                {
                    StatusBLL statusBLL = new StatusBLL();

                    if (statusBLL.AtualizarStatusEquipamento(id_equipamento, idStatus, Program.UserEmail, novaDescricao))
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
