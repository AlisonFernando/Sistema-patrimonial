using BLL;
using DAL;
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

        public TelaManutencao()
        {
            InitializeComponent();
            LoadEquipamentos();
        }
        public void LoadEquipamentos()
        {
            List<Manutencao> manutencaoData = manutencaoBLL.GetManutencoes();

            List<Manutencao> finalizados = manutencaoData.Where(item => item.id_status == 1).ToList();
            List<Manutencao> emAndamento = manutencaoData.Where(item => item.id_status == 2).ToList();
            List<Manutencao> naoFinalizados = manutencaoData.Where(item => item.id_status == 3).ToList();

            MostrarEquipsFinalizados.DataSource = finalizados;
            MostrarEquipsAndamento.DataSource = emAndamento;
            MostrarEquipsNaoFinalizados.DataSource = naoFinalizados;
        }
        private void TelaManutencao_Load(object sender, EventArgs e)
        {
            btnPesquisarFinalizado.Click += new EventHandler(btnPesquisarFinalizado_Click);
            btnPesquisarEmAndamento.Click += new EventHandler(btnPesquisarEmAndamento_Click);
            btnPesquisarNaoFinalizado.Click += new EventHandler(btnPesquisarNaoFinalizado_Click);

        }
        private void btnPesquisarFinalizado_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarFinalizado.Text.Trim();
            List<Manutencao> manutencaoData = (List<Manutencao>)MostrarEquipsFinalizados.DataSource; // Obtenha os dados da tabela

            if (manutencaoData != null)
            {
                List<Manutencao> resultadosPesquisa = manutencaoData
                    .Where(manutencao => manutencao.NomeEquipamento.ToUpper().Contains(nomePesquisado.ToUpper()))
                    .ToList();

                if (resultadosPesquisa.Any())
                {
                    MostrarEquipsFinalizados.DataSource = resultadosPesquisa;
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.");
                    LoadEquipamentos();
                }
            }
        }

        private void btnPesquisarEmAndamento_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarEmAndamento.Text.Trim();
            List<Manutencao> manutencaoData = (List<Manutencao>)MostrarEquipsAndamento.DataSource;

            if (manutencaoData != null)
            {
                List<Manutencao> resultadosPesquisa = manutencaoData
                    .Where(manutencao => manutencao.NomeEquipamento.ToUpper().Contains(nomePesquisado.ToUpper()))
                    .ToList();

                if (resultadosPesquisa.Any())
                {
                    MostrarEquipsAndamento.DataSource = resultadosPesquisa;
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.");
                    LoadEquipamentos();
                }
            }
        }

        private void btnPesquisarNaoFinalizado_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarNaoFinalizados.Text.Trim();
            List<Manutencao> manutencaoData = (List<Manutencao>)MostrarEquipsNaoFinalizados.DataSource; // Obtenha os dados da tabela

            if (manutencaoData != null)
            {
                List<Manutencao> resultadosPesquisa = manutencaoData
                    .Where(manutencao => manutencao.NomeEquipamento.ToUpper().Contains(nomePesquisado.ToUpper()))
                    .ToList();

                if (resultadosPesquisa.Any())
                {
                    MostrarEquipsNaoFinalizados.DataSource = resultadosPesquisa;
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.");
                    LoadEquipamentos();
                }
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
            var manutencaoData = ((sender as DataGridView).DataSource as List<Manutencao>);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipsFinalizados.Rows[e.RowIndex];

                int id_equipamento = (int)selectedRow.Cells["ChamadosFinalizados"].Value;
                Manutencao manutencao = manutencaoData.Find(m => m.id_chamado == id_equipamento);

                if (manutencao != null)
                {
                    int idStatusEquipamento = manutencaoBLL.ObterIdStatusEquipamento(id_equipamento); // Implemente essa função para obter o id_status associado ao equipamento selecionado

                    TelaStatus telaStatus = new TelaStatus(manutencao, idStatusEquipamento);
                    telaStatus.ShowDialog();
                }
            }
        }

        private void MostrarEquipsAndamento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var manutencaoData = ((sender as DataGridView).DataSource as List<Manutencao>);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipsAndamento.Rows[e.RowIndex];

                int id_equipamento = (int)selectedRow.Cells["ChamadosEmAndamento"].Value;
                Manutencao manutencao = manutencaoData.Find(m => m.id_chamado == id_equipamento);

                if (manutencao != null)
                {
                    int idStatusEquipamento = manutencaoBLL.ObterIdStatusEquipamento(id_equipamento); // Implemente essa função para obter o id_status associado ao equipamento selecionado

                    TelaStatus telaStatus = new TelaStatus(manutencao, idStatusEquipamento);
                    telaStatus.ShowDialog();
                }
            }
        }

        private void MostrarEquipsNaoFinalizados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var manutencaoData = ((sender as DataGridView).DataSource as List<Manutencao>);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipsNaoFinalizados.Rows[e.RowIndex];

                int id_equipamento = (int)selectedRow.Cells["ChamadosNaoFinalizados"].Value;
                Manutencao manutencao = manutencaoData.Find(m => m.id_chamado == id_equipamento);

                if (manutencao != null)
                {
                    int idStatusEquipamento = manutencaoBLL.ObterIdStatusEquipamento(id_equipamento); // Implemente essa função para obter o id_status associado ao equipamento selecionado

                    TelaStatus telaStatus = new TelaStatus(manutencao, idStatusEquipamento);
                    telaStatus.ShowDialog();
                }
            }
        }
        private void TelaManutencao_Activated(object sender, EventArgs e)
        {
            LoadEquipamentos();
        }

        private void btnReloadFinalizados_Click(object sender, EventArgs e)
        {
            LoadEquipamentos();
        }

        private void btnReloadAndamento_Click(object sender, EventArgs e)
        {
            LoadEquipamentos();
        }

        private void btnReloadNaoFinalizados_Click(object sender, EventArgs e)
        {
            LoadEquipamentos();
        }
    }
}
