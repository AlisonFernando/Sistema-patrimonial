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
    public partial class TelaVerColaboradores : Form
    {
        private ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
        private List<Colaborador> colaboradores = new List<Colaborador>();
        public TelaVerColaboradores()
        {
            InitializeComponent();
        }
        public void LoadColaboradores()
        {
            colaboradores = colaboradorBLL.GetColaboradoresAtivosComSetor();
            MostrarColaboradores.DataSource = colaboradores;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerColabs_Click(object sender, EventArgs e)
        {
            CadColaborador cadColaborador = new CadColaborador(null);
            cadColaborador.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LoadColaboradores();
            txtNomePesquisar.Text = string.Empty;
        }

        private void TelaVerColaboradores_Load(object sender, EventArgs e)
        {
            LoadColaboradores();
            btnPesquisar.Click += new EventHandler(btnPesquisar_Click);
            MostrarColaboradores.CellMouseDoubleClick += MostrarColaboradores_CellMouseDoubleClick;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtNomePesquisar.Text.Trim();

            List<Colaborador> colaboradoresFiltrados = colaboradores
                .Where(colaborador => colaborador.NomeColaborador.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (colaboradoresFiltrados.Count == 0)
            {
                MessageBox.Show("Colaborador não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite um equipamento e tente novamente");
                txtNomePesquisar.Focus();
            }
            else
            {
                MostrarColaboradores.DataSource = colaboradoresFiltrados;
            }
        }

        private void MostrarColaboradores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarColaboradores.Rows[e.RowIndex];
                string NomeColaborador = selectedRow.Cells["NomeColaborador"].Value as string;

                if (!string.IsNullOrEmpty(NomeColaborador))
                {
                    Colaborador colaborador = colaboradores.Find(f => f.NomeColaborador == NomeColaborador);

                    if (colaborador != null)
                    {
                        CadColaborador cadColaborador = new CadColaborador(colaborador);
                        cadColaborador.ShowDialog();
                    }
                    else
                    {
                        // Lidar com o caso em que o colaborador não foi encontrado
                    }
                }
            }
        }
    }
}
