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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TelaCadastrarMarca : Form
    {
        private MarcaBLL marcaBLL = new MarcaBLL();
        private List<Marca> marcasAtivas = new List<Marca>();
        private List<Marca> marcasDesativadas = new List<Marca>();
        private string nomeMarca;
        public TelaCadastrarMarca()
        {
            InitializeComponent();
            LoadMarcasAtivas();
            LoadMarcasDesativadas();
        }

        public void LoadMarcasAtivas()
        {
            marcasAtivas = marcaBLL.GetMarcasAtivas();
            MostrarMarcasCadastradas.DataSource = marcasAtivas;
        }
        public void LoadMarcasDesativadas()
        {
            marcasDesativadas = marcaBLL.GetMarcasDesativadas();
            MostrarMarcasDesativadas.DataSource = marcasDesativadas;
        }

        private void CadastrarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();

            if (!string.IsNullOrEmpty(txtID.Text))
                marca.ID_Marca = int.Parse(txtID.Text);

            marca.Nome = txtMarca.Text;
            marca.Ativo_inativo = checkAtivo.Checked;

            // Valida se o txtBox está vazio
            if (string.IsNullOrWhiteSpace(marca.Nome) || Regex.IsMatch(marca.Nome, @"\s"))
            {
                MessageBox.Show("O nome da marca não pode ficar em branco ou conter espaços em branco.");
                return;
            }

            MarcaBLL verificarMarca = new MarcaBLL();
            string verificar = verificarMarca.VerificarMarca(marca.Nome);

            if (verificar == "Marca existente")
            {
                if (string.IsNullOrEmpty(txtID.Text) || (string.Equals(marca.Nome, nomeMarca, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Essa marca já existe cadastrada.");
                    return;
                }
            }

            // Executa o cadastro ou atualização da marca
            string retorno;
            MarcaBLL cadMarcaBLL = new MarcaBLL();

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                retorno = cadMarcaBLL.UpdateMarca(marca, Program.UserEmail);
            }
            else
            {
                retorno = cadMarcaBLL.CadMarca(marca, Program.UserEmail);
            }

            if (retorno == "Sucesso")
            {
                MessageBox.Show("Ação efetuada com sucesso!");

                // Verifica se a marca editada é ativa ou desativada
                if (marca.Ativo_inativo)
                {
                    // Se ativa, recarrega apenas a lista de marcas ativas
                    LoadMarcasAtivas();
                }
                else
                {
                    // Se desativada, recarrega apenas a lista de marcas desativadas
                    LoadMarcasDesativadas();
                }

                btnLimpar.PerformClick();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtMarca.Text.Trim();

            List<Marca> marcasFiltradas = marcasAtivas
                .Where(marca => marca.Nome.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (marcasFiltradas.Count == 0)
            {
                MessageBox.Show("Marca não encontrada.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite uma marca e tente novamente");
                txtMarca.Focus();
            }
            else
            {
                MostrarMarcasCadastradas.DataSource = marcasFiltradas;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMarca.Text = string.Empty;
            LoadMarcasAtivas();
            LoadMarcasDesativadas();
        }

        private void MostrarMarcasCadastradas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarMarcasCadastradas.Rows[e.RowIndex];

                int id_marca = (int)selectedRow.Cells["IDMarca"].Value;
                txtID.Text = id_marca.ToString(); // Defina o valor de txtID com o ID da marca selecionada
                Marca marca = marcasAtivas.Find(u => u.id_marca == id_marca);

                txtMarca.Text = marca.nome;
                nomeMarca = marca.nome; // Guarde o nome da marca para referência posterior
            }
        }

        private void MostrarMarcasCadastradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idMarca = int.Parse(txtID.Text);
                marcaBLL.DesativarMarca(idMarca);
                MessageBox.Show("Marca desativada com sucesso.");
                LoadMarcasAtivas();
                LoadMarcasDesativadas();
            }
            else
            {
                MessageBox.Show("Selecione uma marca para desativar.");
            }
        }

        private void MostrarMarcasDesativadas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarMarcasDesativadas.Rows[e.RowIndex];

                int id_marca = (int)selectedRow.Cells["IDMarcaDesativada"].Value;
                txtID.Text = id_marca.ToString(); // Defina o valor de txtID com o ID da marca selecionada
                Marca marca = marcasDesativadas.Find(u => u.id_marca == id_marca);

                txtMarca.Text = marca.nome;
                nomeMarca = marca.nome; // Guarde o nome da marca para referência posterior
            }
        }
        private void btnAtivarMarca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idMarca = int.Parse(txtID.Text);
                marcaBLL.AtivarMarca(idMarca);
                MessageBox.Show("Marca ativada com sucesso.");
                LoadMarcasAtivas();
                LoadMarcasDesativadas();
            }
            else
            {
                MessageBox.Show("Selecione uma marca para ativar.");
            }
        }
    }
}
