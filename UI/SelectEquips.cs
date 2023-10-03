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
using UI;
using static UI.CadColaborador;

namespace UI
{
    public partial class SelectEquips : Form
    {
        Equipamento equipamento = new Equipamento();
        Colaborador colaborador = new Colaborador();
        private EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
        private List<Equipamento> equipamentos = new List<Equipamento>();
        private List<string> equipamentosSelecionados = new List<string>();
        public SelectEquips()
        {
            InitializeComponent();
            LoadEquipamentos();
            btnPesquisar.Click += new EventHandler(btnPesquisar_Click);
            MostrarEquipsDisponiveis.CellMouseDoubleClick += MostrarEquipsDisponiveis_CellMouseDoubleClick;
        }
        public void LoadEquipamentos()
        {
            equipamentos = equipamentoBLL.GetEquipamentosDisponiveis();
            MostrarEquipsDisponiveis.DataSource = equipamentos;
        }

        private List<int> equipamentosSelecionadosIDs = new List<int>(); // Crie uma lista para armazenar os IDs dos equipamentos selecionados

        private void MostrarEquipsDisponiveis_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipsDisponiveis.Rows[e.RowIndex];

                int ID_equipamento = (int)selectedRow.Cells["ID_equipamento"].Value;
                Equipamento equipamento = equipamentos.Find(f => f.ID_equipamento == ID_equipamento);

                if (equipamentosSelecionadosIDs.Contains(ID_equipamento))
                {
                    // Mostra a mensagem de erro
                    MessageBox.Show("Já escolheu este equipamento, escolha outro e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Adicione o ID do equipamento à lista de IDs de equipamentos selecionados
                    equipamentosSelecionadosIDs.Add(ID_equipamento);

                    // Obtém os outros valores das células da linha clicada na primeira DataGridView
                    string nome = selectedRow.Cells["Nome"].Value.ToString();
                    string valor = selectedRow.Cells["Valor"].Value.ToString();
                    string descricao = selectedRow.Cells["Descricao"].Value.ToString();
                    string etiqueta = selectedRow.Cells["Etiqueta_identificacao"].Value.ToString();

                    // Adicione os valores à segunda DataGridView
                    EquipsSelecionados.Rows.Add(ID_equipamento, nome, valor, descricao, etiqueta);
                }
            }
        }
        public List<int> ObterIdsEquipamentosSelecionados()
        {
            List<int> equipamentosSelecionados = new List<int>();

            foreach (DataGridViewRow row in EquipsSelecionados.Rows)
            {
                if (row.Cells["ID_select"].Value != null)
                {
                    int idEquipamento;
                    if (int.TryParse(row.Cells["ID_select"].Value.ToString(), out idEquipamento))
                    {
                        equipamentosSelecionados.Add(idEquipamento);
                    }
                }
            }

            return equipamentosSelecionados;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            EquipsSelecionados.Rows.Clear();
            equipamentosSelecionados.Clear();
        }


        private void btnCadColab_Click(object sender, EventArgs e)
        {

            Colaborador colaborador = new Colaborador();

            // Obtenha os dados do colaborador a partir de DadosGlobais
            colaborador.NomeColaborador = DadosGlobais.NomeColaborador;
            colaborador.SenhaColaborador = DadosGlobais.SenhaColaborador;
            colaborador.AgendaColaborador = DadosGlobais.AgendaColaborador;
            colaborador.TelefoneColaborador = DadosGlobais.TelefoneColaborador;
            colaborador.Ativo_inativo = DadosGlobais.Ativo_inativo;
            colaborador.EmailColaborador = DadosGlobais.EmailColaborador;
            colaborador.id_setor = DadosGlobais.id_setor;

            ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
            string verificar = colaboradorBLL.VerificarNome(colaborador.NomeColaborador);

            if (verificar == "nome não existe")
            {
                // Cadastre o colaborador
                string retorno = colaboradorBLL.CadColab(colaborador);

                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Colaborador cadastro com sucesso");

                    // Obtenha o ID do colaborador recém-cadastrado
                    int idColaborador = colaboradorBLL.ObterIdColaboradorPorNome(colaborador.NomeColaborador);

                    // Associe os equipamentos ao colaborador
                    List<int> equipamentosSelecionados = ObterIdsEquipamentosSelecionados();
                    string associacaoEquipamentos = colaboradorBLL.AssociarEquipamentosAoColaborador(idColaborador, equipamentosSelecionados);

                    if (associacaoEquipamentos == "Sucesso")
                    {
                        // Limpe a lista de equipamentos selecionados e a grade de exibição
                        EquipsSelecionados.Rows.Clear();
                        equipamentosSelecionados.Clear();

                        MessageBox.Show("Equipamentos associados com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao associar equipamentos ao colaborador");
                    }
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            /*UI.CadColaborador cadColaborador = new UI.CadColaborador();
            cadColaborador.ShowDialog();*/

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisar.Text.Trim();

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
                txtPesquisar.Focus();
            }
            else
            {
                MostrarEquipsDisponiveis.DataSource = equipamentosFiltrados;
            }
        }
    }
}
