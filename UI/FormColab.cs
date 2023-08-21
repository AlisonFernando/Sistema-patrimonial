using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using model;

namespace UI
{
    public partial class CadColaborador : Form
    {
        public CadColaborador()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Colaborador colaborador = new Colaborador();
            Setor setor = new Setor();

            colaborador.NomeColaborador = InputColabNome.Text;
            colaborador.SenhaColaborador = inputColabSenha.Text;
            colaborador.AgendaColaborador = inputColabAgenda.Text;
            colaborador.TelefoneColaborador = inputColabTel.Text;
            colaborador.Ativo_inativo = check_ativo.Checked;
            colaborador.EmailColaborador = inputColabEmail.Text;
            colaborador.setor_id = escolherSetor.SelectedValue.ToString();
            //colaborador.equipamento_id = checkedListBox1.SelectedValue.ToString();
            //colaborador.equipamento_id = listBox1.SelectedValue.ToString();

            // Executa a verificação se caso o usuário não digitar nenhum valor nos campos
            if (colaborador.NomeColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o nome do colaborador e tente novamente");
                return;
            }
            else if (colaborador.SenhaColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a senha e tente novamento");
                return;
            }
            else if (colaborador.AgendaColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a agenda e tente novamente");
                return;
            }
            else if (colaborador.TelefoneColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o telefone e tente novamente");
                return;
            }
            else if (colaborador.EmailColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o email e tente novamente");
                return;
            }
            //Verificação se o nome digitado já existe ou não no banco de dados

            ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
            string verificar = colaboradorBLL.VerificarNome(colaborador.NomeColaborador);
            if (verificar == "nome existente")
            {
                MessageBox.Show("Já possui no banco de dados");
                return;

            }
            else if (verificar == "nome não existe")
            {
                ColaboradorBLL CadcolaboradorBLL = new ColaboradorBLL();
                string retorno = CadcolaboradorBLL.CadColab(colaborador);

                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Cadastro efetuado");
                }
            }

        }

        private void CadColaborador_Load(object sender, EventArgs e)
        {
            CarregarSetorComboBox();
            CarregarEquipamentos();
            //ObterEquipamentosSelecionados();
        }

        private void CarregarSetorComboBox()
        {
            SetorBLL setorBLL = new SetorBLL();
            DataTable dt = setorBLL.CarregarSetor();

            escolherSetor.DisplayMember = "Nome_Setor"; // Define a coluna a ser exibida
            escolherSetor.ValueMember = "ID_setor";    // Define a coluna a ser usada como valor selecionado
            escolherSetor.DataSource = dt;
        }

        /*private void CarregarEquipamentos()
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
            DataTable dt = equipamentoBLL.ChamarEquipamentos();

            checkedListBox1.DataSource = dt;
            checkedListBox1.DisplayMember = "Nome_equipamento";
            checkedListBox1.ValueMember = "ID_equipamento";
        }
        private void ObterEquipamentosSelecionados()
        {
            StringBuilder selectedIds = new StringBuilder();

            foreach (DataRowView item in checkedListBox1.CheckedItems)
            {
                if (selectedIds.Length > 0)
                    selectedIds.Append(",");

                selectedIds.Append(item["ID_equipamento"]);
            }.
        }*/

        /*private void CarregarEquipamentos()
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
            DataTable dt = equipamentoBLL.ChamarEquipamentos();

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Nome_equipamento";
            listBox1.ValueMember = "ID_equipamento";
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ObterEquipamentosSelecionados();
        }

        private void ObterEquipamentosSelecionados()
        {
            StringBuilder selectedIds = new StringBuilder();

            foreach (DataRowView item in listBox1.SelectedItems)
            {
                if (selectedIds.Length > 0)
                    selectedIds.Append(",");

                selectedIds.Append(item["ID_equipamento"]);
            }
        }*/

        private List<string> selectedIds = new List<string>();
        private void CarregarEquipamentos()
        {

            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
            DataTable dt = equipamentoBLL.ChamarEquipamentos();

            dataGridViewEquipamentos.DataSource = dt;

            foreach (DataGridViewRow row in dataGridViewEquipamentos.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["Selecionar"] as DataGridViewCheckBoxCell;

                if (cell.Value != null && (bool)cell.Value)
                {
                    string selectedId = row.Cells["ID_equipamento"].Value.ToString();
                    selectedIds.Add(selectedId);
                }
            }

            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            colaboradorDAL.SalvarEquipamentosSelecionados(selectedIds);
        }

    }
}
