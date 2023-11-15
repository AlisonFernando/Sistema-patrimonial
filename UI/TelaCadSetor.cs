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
    public partial class TelaCadSetor : Form
    {
        SetorBLL setorBLL = new SetorBLL();
        private List<Setor> setores = new List<Setor>();
        private List<Setor> setoresDesativado = new List<Setor>();
        private string nomeSetor;
        public TelaCadSetor()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = string.Empty;
            LoadSetorAtivo();
            LoadSetorDesativado();
        }
        public void LoadSetorAtivo()
        {
            setores = setorBLL.GetSetorAtivo();
            MostrarSetores.DataSource = setores;
        }
        public void LoadSetorDesativado()
        {
            setoresDesativado = setorBLL.GetSetorDesativado();
            MostrarSetoresDesativados.DataSource = setoresDesativado;
        }

        private void TelaCadSetor_Load(object sender, EventArgs e)
        {
            LoadSetorAtivo();
            LoadSetorDesativado();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor();

            if (!string.IsNullOrEmpty(txtID.Text))
                setor.ID_Setor = int.Parse(txtID.Text);

            setor.nome = txtPesquisar.Text;
            setor.Ativo_inativo = checkAtivo.Checked;

            // Verifica se o txtBox está vazio
            if (string.IsNullOrWhiteSpace(setor.Nome) || Regex.IsMatch(setor.Nome, @"\s"))
            {
                MessageBox.Show("O nome da marca não pode ficar em branco ou conter espaços em branco.");
                return;
            }

            // Verifica se o checkAtivo está marcado
            if (!checkAtivo.Checked)
            {
                MessageBox.Show("É necessário selecionar a opção Ativo para cadastrar/editar o setor.");
                return;
            }


            // Validação se o setor já está cadastrado no banco de dados
            SetorBLL verificarNome = new SetorBLL();
            string verificar = verificarNome.VerificarNome(setor.nome);

            if (verificar == "Setor existente")
            {
                MessageBox.Show("Esse setor já está cadastrado, tente novamente");
                txtPesquisar.Focus();
                return;
            }
            else if (verificar == "Setor não existe")
            {
                string retorno;
                SetorBLL cadSetorBLL = new SetorBLL();
                if (!string.IsNullOrEmpty(txtID.Text))
                    retorno = cadSetorBLL.UpdateSetor(setor);
                else
                {
                    retorno = cadSetorBLL.CadSetor(setor);

                    if (retorno == "Sucesso")
                    {
                        MessageBox.Show("Aplicação com sucesso");
                        btnLimpar.PerformClick();
                        LoadSetorAtivo();
                        LoadSetorDesativado();
                        return; // Impede que o código continue
                    }
                    else
                    {
                        MessageBox.Show("Erro ao aplicar a ação.");
                    }
                }
                MessageBox.Show("Nome do setor alterado com sucesso");
                LoadSetorAtivo();
                LoadSetorDesativado();
            }
        }
        private void MostrarSetores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarSetores.Rows[e.RowIndex];

                int ID_setor = (int)selectedRow.Cells["ID_setor"].Value;
                Setor setor = setores.Find(f => f.ID_Setor == ID_setor);

                txtID.Text = setor.id_setor.ToString();
                txtPesquisar.Text = setor.nome;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisar.Text.Trim();

            List<Setor> setoresFiltrados = setores
                .Where(setor => setor.Nome.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (setoresFiltrados.Count == 0)
            {
                MessageBox.Show("Setor não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite um setor e tente novamente");
                txtPesquisar.Focus();
            }
            else
            {
                MostrarSetores.DataSource = setoresFiltrados;
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idSetor = int.Parse(txtID.Text);
                setorBLL.DesativarSetor(idSetor);
                MessageBox.Show("Setor desativado com sucesso.");
                LoadSetorAtivo();
                LoadSetorDesativado();
            }
            else
            {
                MessageBox.Show("Selecione um Setor para desativar.");
            }
        }

        private void btnAtivarSetor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idSetor = int.Parse(txtID.Text);
                setorBLL.AtivarSetor(idSetor);
                MessageBox.Show("Setor ativado com sucesso.");
                LoadSetorAtivo();
                LoadSetorDesativado();
            }
            else
            {
                MessageBox.Show("Selecione um setor para ativar.");
            }
        }

        private void MostrarSetoresDesativados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarSetoresDesativados.Rows[e.RowIndex];

                int ID_setor = (int)selectedRow.Cells["ID_SetorDesativado"].Value;
                txtID.Text = ID_setor.ToString();
                Setor setor = setoresDesativado.Find(f => f.id_setor == ID_setor);

                txtPesquisar.Text = setor.nome;
                nomeSetor = setor.Nome;
            }
        }

        private void btnLimparDesativado_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = string.Empty;
            LoadSetorAtivo();
            LoadSetorDesativado();
        }
    }
}
