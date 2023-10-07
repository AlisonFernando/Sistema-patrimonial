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
    public partial class TelaManutencao : Form
    {
        private ManutencaoBLL manutencaoBLL = new ManutencaoBLL();
        private List<Chamado> equipamentos = new List<Chamado>();
        public TelaManutencao()
        {
            InitializeComponent();
            LoadEquipamentos();
        }
        public void LoadEquipamentos()
        {

            equipamentos = manutencaoBLL.GetEquipsChamado();

            var equipamentosComId1 = equipamentos.Where(equipamento => equipamento.id_status == 1).ToList();
            MostrarEquipsFinalizados.DataSource = equipamentosComId1;

            var equipamentosComId2 = equipamentos.Where(equipamento => equipamento.id_status == 2).ToList();
            MostrarEquipsAndamento.DataSource = equipamentosComId2;
            var equipamentosComId3 = equipamentos.Where(equipamento => equipamento.id_status == 3).ToList();
            MostrarEquipsNaoFinalizados.DataSource = equipamentosComId3;

        }

        private void btnPesquisarFinalizado_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarFinalizado.Text.Trim();

            List<Chamado> equipamentosFiltrados = equipamentos
                .Where(equipamento => equipamento.id_equipamento.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (equipamentosFiltrados.Count == 0)
            {
                MessageBox.Show("Equipamento não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite um equipamento e tente novamente");
                txtPesquisarFinalizado.Focus();
            }
            else
            {
                MostrarEquipsFinalizados.DataSource = equipamentosFiltrados;
            }
        }

        private void TelaManutencao_Load(object sender, EventArgs e)
        {
            btnPesquisarFinalizado.Click += new EventHandler(btnPesquisarFinalizado_Click);
            btnPesquisarEmAndamento.Click += new EventHandler(btnPesquisarEmAndamento_Click);
            btnPesquisarNaoFinalizado.Click += new EventHandler(btnPesquisarNaoFinalizado_Click);

        }

        private void btnPesquisarEmAndamento_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarEmAndamento.Text.Trim();

            List<Chamado> equipamentosFiltrados = equipamentos
                .Where(equipamento => equipamento.id_equipamento.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (equipamentosFiltrados.Count == 0)
            {
                MessageBox.Show("Equipamento não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite um equipamento e tente novamente");
                txtPesquisarFinalizado.Focus();
            }
            else
            {
                MostrarEquipsAndamento.DataSource = equipamentosFiltrados;
            }
        }

        private void btnPesquisarNaoFinalizado_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarNaoFinalizados.Text.Trim();

            List<Chamado> equipamentosFiltrados = equipamentos
                .Where(equipamento => equipamento.id_equipamento.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (equipamentosFiltrados.Count == 0)
            {
                MessageBox.Show("Equipamento não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite um equipamento e tente novamente");
                txtPesquisarFinalizado.Focus();
            }
            else
            {
                MostrarEquipsNaoFinalizados.DataSource = equipamentosFiltrados;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LoadEquipamentos();
            txtPesquisarEmAndamento.Text = string.Empty;
            txtPesquisarFinalizado.Text = string.Empty;
            txtPesquisarNaoFinalizados.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarEquipsFinalizados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipsFinalizados.Rows[e.RowIndex];

                string Nome_equipamento = (string)selectedRow.Cells["Nome_equipamento"].Value;
                manutencao manutencao = equipamentos.Find(f => f.id_equipamento == id_equipamento);

                TelaStatus telaStatus = new TelaStatus(manutencao);

                telaStatus.ShowDialog();
            }*/
        }
    }
}
