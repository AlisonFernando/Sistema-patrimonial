using BLL;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TelaStatus : Form
    {
        public TelaStatus(manutencao manutencao)
        {
            InitializeComponent();
            if (manutencao != null)
            {

                txtNomeEquipamento.Text = manutencao.Nome_equipamento;
            }
        }
        private void CarregarStatusComboBox()
        {
            StatusBLL statusBLL = new StatusBLL();
            DataTable dt = statusBLL.CarregarStatus();

            ComboBoxStatus.DisplayMember = "andamento_do_chamado"; // Define a coluna a ser exibida
            ComboBoxStatus.ValueMember = "id_status";    // Define a coluna a ser usada como valor selecionado
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
    }
}
