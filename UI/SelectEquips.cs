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
    public partial class SelectEquips : Form
    {
        Equipamento equipamento = new Equipamento();
        Colaborador colaborador = new Colaborador();
        private EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
        private List<Equipamento> equipamentos = new List<Equipamento>();
        public SelectEquips()
        {
            InitializeComponent();
            LoadEquipamentos();

        }
        public void LoadEquipamentos()
        {
            equipamentos = equipamentoBLL.GetEquipamentosDisponiveis();
            MostrarEquipsDisponiveis.DataSource = equipamentos;
        }

        private void MostrarEquipsDisponiveis_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipsDisponiveis.Rows[e.RowIndex];

                int ID_equipamento = (int)selectedRow.Cells["ID_equipamento"].Value;
                Equipamento equipamento = equipamentos.Find(f => f.ID_equipamento == ID_equipamento);

                EquipsSelecionados.Columns.Clear();

                // Cria uma coluna para o ID
                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                idColumn.HeaderText = "ID";
                idColumn.Name = "ID";
                EquipsSelecionados.Columns.Add(idColumn);

                // Cria uma coluna para o Nome
                DataGridViewTextBoxColumn nomeColumn = new DataGridViewTextBoxColumn();
                nomeColumn.HeaderText = "Nome";
                nomeColumn.Name = "Nome";
                EquipsSelecionados.Columns.Add(nomeColumn);

                // Cria uma coluna para o Valor
                DataGridViewTextBoxColumn valorColumn = new DataGridViewTextBoxColumn();
                valorColumn.HeaderText = "Valor";
                valorColumn.Name = "Valor";
                EquipsSelecionados.Columns.Add(valorColumn);

                // Cria uma coluna para a Descrição
                DataGridViewTextBoxColumn descricaoColumn = new DataGridViewTextBoxColumn();
                descricaoColumn.HeaderText = "Descrição";
                descricaoColumn.Name = "Descrição";
                EquipsSelecionados.Columns.Add(descricaoColumn);

                // Cria uma coluna para a Etiqueta
                DataGridViewTextBoxColumn etiquetaColumn = new DataGridViewTextBoxColumn();
                etiquetaColumn.HeaderText = "Etiqueta";
                etiquetaColumn.Name = "Etiqueta";
                EquipsSelecionados.Columns.Add(etiquetaColumn);
            }
        }
    }
}
