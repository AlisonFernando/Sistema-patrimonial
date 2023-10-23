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
    public partial class TelaCadSetor : Form
    {
        SetorBLL setorBLL = new SetorBLL();
        private List<Setor> setores = new List<Setor>();
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
            LoadSetor();
        }
        public void LoadSetor()
        {
            setores = setorBLL.GetSetor();
            MostrarSetores.DataSource = setores;
        }

        private void TelaCadSetor_Load(object sender, EventArgs e)
        {
            LoadSetor();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor();

            if (!string.IsNullOrEmpty(txtID.Text))
                setor.ID_Setor = int.Parse(txtID.Text);

            setor.nome = txtPesquisar.Text;

            // Validações do campo nome
            if (string.IsNullOrWhiteSpace(setor.nome) || setor.nome.Contains(" "))
            {
                MessageBox.Show("Verifique o nome do setor e tente novamente");
                txtPesquisar.Focus();
                return; // Impede o cadastro se o campo estiver em branco ou conter espaços em branco
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
                        LoadSetor();
                        return; // Impede que o código continue
                    }
                    else
                    {
                        MessageBox.Show("Erro ao aplicar a ação.");
                    }
                }
                MessageBox.Show("Nome do setor alterado com sucesso");
                LoadSetor();
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int ID_setor = int.Parse(txtID.Text);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este setor?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    setorBLL.DeleteSetor(ID_setor);
                    LoadSetor();
                }
                MessageBox.Show("Setor deletado com sucesso!");
            }
            LoadSetor();
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
    }
}
