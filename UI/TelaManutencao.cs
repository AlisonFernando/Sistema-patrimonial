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
        private List<Manutencao> manutencaoData = new List<Manutencao>();

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

        private void btnPesquisarFinalizado_Click(object sender, EventArgs e)
        {
            List<Manutencao> manutencaoData = manutencaoBLL.GetManutencoes();
            string nomePesquisado = txtPesquisarFinalizado.Text.Trim();
            List<Manutencao> resultadosPesquisa = new List<Manutencao>();

            foreach (Manutencao manutencao in manutencaoData)
            {
                if (manutencao.NomeEquipamento.ToUpper().Contains(nomePesquisado.ToUpper()))
                {
                    resultadosPesquisa.Add(manutencao);
                }
            }
            MostrarEquipsFinalizados.DataSource = resultadosPesquisa;
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
            List<Manutencao> manutencaoData = manutencaoBLL.GetManutencoes();
            List<Manutencao> resultadosPesquisa = new List<Manutencao>();

            foreach (Manutencao manutencao in manutencaoData)
            {
                if (manutencao.NomeEquipamento.ToUpper().Contains(nomePesquisado.ToUpper()))
                {
                    resultadosPesquisa.Add(manutencao);
                }
            }
            MostrarEquipsAndamento.DataSource = resultadosPesquisa;

        }

        private void btnPesquisarNaoFinalizado_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarNaoFinalizados.Text.Trim();

            List<Manutencao> manutencaoData = manutencaoBLL.GetManutencoes();
            List<Manutencao> resultadosPesquisa = new List<Manutencao>();

            foreach (Manutencao manutencao in manutencaoData)
            {
                if (manutencao.NomeEquipamento.ToUpper().Contains(nomePesquisado.ToUpper()))
                {
                    resultadosPesquisa.Add(manutencao);
                }
            }
            MostrarEquipsNaoFinalizados.DataSource = resultadosPesquisa;
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

                int id_equipamento = (int)selectedRow.Cells["id_chamado"].Value;
                Manutencao manutencao = manutencaoData.Find(m => m.id_chamado == id_equipamento);

                if (manutencao != null)
                {
                    TelaStatus telaStatus = new TelaStatus(manutencao);
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

                int id_equipamento = (int)selectedRow.Cells["id_chamado"].Value;
                Manutencao manutencao = manutencaoData.Find(m => m.id_chamado == id_equipamento);

                if (manutencao != null)
                {
                    TelaStatus telaStatus = new TelaStatus(manutencao);
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

                int id_equipamento = (int)selectedRow.Cells["id_chamado"].Value;
                Manutencao manutencao = manutencaoData.Find(m => m.id_chamado == id_equipamento);

                if (manutencao != null)
                {
                    TelaStatus telaStatus = new TelaStatus(manutencao);
                    telaStatus.ShowDialog();
                }
            }
        }
    }
}
