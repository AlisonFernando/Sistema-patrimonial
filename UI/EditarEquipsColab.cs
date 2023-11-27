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
    public partial class EditarEquipsColab : Form
    {
        EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
        int ID_colaborador; // Adicionando uma variável para armazenar o ID_colaborador

        public EditarEquipsColab(int idColaborador)
        {
            InitializeComponent();
            ID_colaborador = idColaborador; // Atribuir o valor recebido ao ID_colaborador
            CarregarEquipamentos();
        }

        private void CarregarEquipamentos()
        {
            MostrarEquipsColaborador.Rows.Clear();
            MostrarEquipsColaborador.Columns.Clear();
            MostrarEquipsColaborador.ReadOnly = false;


            // Adicionar coluna de seleção
            MostrarEquipsColaborador.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Selecionar",
                HeaderText = "Selecionar",
                TrueValue = true,
                FalseValue = false,
                IndeterminateValue = CheckState.Indeterminate,
            });
            foreach (DataGridViewColumn coluna in MostrarEquipsColaborador.Columns)
            {
                coluna.ReadOnly = coluna.Name != "Selecionar";
            }

            // Adicionar outras colunas necessárias
            MostrarEquipsColaborador.Columns.Add("ID", "ID");
            MostrarEquipsColaborador.Columns.Add("Nome", "Nome");
            MostrarEquipsColaborador.Columns.Add("Descricao", "Descrição");
            MostrarEquipsColaborador.Columns.Add("Etiqueta", "Etiqueta");

            List<Equipamento> equipamentos = equipamentoBLL.ObterEquipamentosPorColaborador(ID_colaborador);

            foreach (Equipamento equipamento in equipamentos)
            {
                MostrarEquipsColaborador.Rows.Add(
                    false, // Valor padrão para a coluna de seleção
                    equipamento.ID_equipamento,
                    equipamento.Nome,
                    equipamento.Descricao,
                    equipamento.Etiqueta
                // Adicione outros campos conforme necessário
                );
            }
        }


        private void EditarEquipsColab_Load(object sender, EventArgs e)
        {
            CarregarEquipamentos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_selectEquips_Click(object sender, EventArgs e)
        {
            UI.SelectEquips selectEquips = new UI.SelectEquips(ID_colaborador, true);
            selectEquips.ShowDialog();
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            // Verificar se pelo menos um equipamento está selecionado
            bool peloMenosUmSelecionado = false;

            foreach (DataGridViewRow row in MostrarEquipsColaborador.Rows)
            {
                if (row.Cells["Selecionar"].Value != null && (bool)row.Cells["Selecionar"].Value)
                {
                    peloMenosUmSelecionado = true;

                    // Obter o ID do equipamento da célula correspondente
                    int idEquipamento = Convert.ToInt32(row.Cells["ID"].Value);

                    // Desvincular o equipamento (defina id_colaborador como null)
                    equipamentoBLL.DesvincularEquipamento(idEquipamento);
                    MessageBox.Show("Equipamento desassociado com sucesso!");
                }
            }

            // Verificar se pelo menos um equipamento foi selecionado
            if (!peloMenosUmSelecionado)
            {
                MessageBox.Show("Selecione pelo menos um equipamento para desvincular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sair da função se nenhum equipamento foi selecionado
            }

            // Recarregar os equipamentos após desvincular
            CarregarEquipamentos();
        }

    }
}
