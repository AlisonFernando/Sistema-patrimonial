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
        private List<Marca> marcas = new List<Marca>();
        public TelaCadastrarMarca()
        {
            InitializeComponent();
            LoadMarcas();
        }
        public void LoadMarcas()
        {
            marcas = marcaBLL.GetMarcas();
            MostrarMarcasCadastradas.DataSource = marcas;
        }

        private void CadastrarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nome = txtMarca.Text;

            // Verifica se o nome da marca está em branco ou contém apenas espaços em branco
            if (string.IsNullOrWhiteSpace(marca.Nome) || marca.Nome.Trim() == "" || Regex.IsMatch(marca.Nome, @"\s"))
            {
                MessageBox.Show("O nome da marca não pode ficar em branco ou conter espaços em branco.");
                return;
            }
            string verificar = marcaBLL.VerificarMarca(marca.Nome);

            if (verificar == "Marca existente")
            {
                MessageBox.Show("A marca já existe no banco de dados.");
                txtMarca.Focus();
            }
            else if (verificar == "Marca não existe")
            {
                string retorno = marcaBLL.CadMarca(marca);
                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Marca cadastrada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a marca no banco de dados.");
                }
            }
            LoadMarcas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtMarca.Text.Trim();

            List<Marca> marcasFiltradas = marcas
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
            LoadMarcas();
        }
    }
}
