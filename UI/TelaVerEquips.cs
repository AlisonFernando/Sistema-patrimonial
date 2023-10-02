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
    public partial class TelaVerEquips : Form
    {
        private EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
        private List<Equipamento> equipamentos = new List<Equipamento>();
        public TelaVerEquips()
        {

            InitializeComponent();
        }

        public void TelaVerEquips_Load(object sender, EventArgs e)
        {
            LoadEquipamentos();
            btnPesquisar.Click += new EventHandler(btnPesquisar_Click);
            MostrarEquipamentos.CellMouseDoubleClick += MostrarEquipamentos_CellMouseDoubleClick;
        }

        public void LoadEquipamentos()
        {
            equipamentos = equipamentoBLL.GetEquipamentos();
            MostrarEquipamentos.DataSource = equipamentos;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtNomePesquisar.Text.Trim();

            List<Equipamento> equipamentosFiltrados = equipamentos
                .Where(equipamento => equipamento.Nome.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (equipamentosFiltrados.Count == 0)
            {
                MessageBox.Show("Equipamento não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite um equipamento e tente novamente");
                txtNomePesquisar.Focus();
            }
            else
            {
                MostrarEquipamentos.DataSource = equipamentosFiltrados;
            }
        }

        private void btnEquips_Click(object sender, EventArgs e)
        {
            this.Close();
            /*UI.CadEquipamento cadEquipamento = new UI.CadEquipamento(null);
            cadEquipamento.ShowDialog();*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LoadEquipamentos();
            txtNomePesquisar.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPrincipal principal = new TelaPrincipal();
            principal.ShowDialog();
        }

        public void MostrarEquipamentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipamentos.Rows[e.RowIndex];

                int ID_equipamento = (int)selectedRow.Cells["ID_equipamento"].Value;
                Equipamento equipamento = equipamentos.Find(f => f.ID_equipamento == ID_equipamento);

                CadEquipamento cadEquip = new CadEquipamento(equipamento);

                cadEquip.ShowDialog();
            }
        }
    }
}
