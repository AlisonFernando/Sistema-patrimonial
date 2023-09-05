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
    public partial class CadEquip : Form
    {
        private EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
        private List<Equipamento> equipamentos = new List<Equipamento>();
        public CadEquip()
        {
            InitializeComponent();
        }

        private void CadEquip_Load(object sender, EventArgs e)
        {
            CarregarMarcasComboBox();
            LoadEquipamentos();
        }
        public void LoadEquipamentos()
        {
            equipamentos = equipamentoBLL.GetEquipamentos();
            MostrarEquipamentos.DataSource = equipamentos;
            inputEtiquetaEquip.Enabled = true;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            Equipamento equipamento = new Equipamento();
            if (!string.IsNullOrEmpty(txtID.Text))
                equipamento.ID_equipamento = int.Parse(txtID.Text);

            equipamento.Nome = inputEquipNome.Text;
            equipamento.Descricao = inputDesEquip.Text;
            equipamento.Valor = inputPrecoEquip.Text;
            equipamento.Etiqueta = inputEtiquetaEquip.Text;
            equipamento.Ativo_inativo = check_ativo.Checked;
            equipamento.id_marca = escolherMarca.SelectedValue.ToString();

            // Executa a verificação se caso o usuário não digitar nenhum valor nos campos
            if (equipamento.Nome.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o nome do equipamento e tente novamente");
                return;
            }
            else if (equipamento.Descricao.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a descrição e tente novamente");
                return;
            }
            else if (equipamento.Valor.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o valor digitado e tente novamente");
                return;
            }
            else if (equipamento.Etiqueta.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a etiqueta e tente novamente");
                return;
            }



            string verificar;
            //Verifica se a etiqueta existe no banco de dados
            if (string.IsNullOrEmpty(txtID.Text))
            {
                EquipamentoBLL verificaretiqueta = new EquipamentoBLL();
                verificar = verificaretiqueta.VerificarEtiqueta(equipamento.Etiqueta);

            }
            else
                verificar = "Etiqueta não existe";

            if (verificar == "Etiqueta existente")
            {
                MessageBox.Show("Essa etiqueta existe no banco de dados");
                return;
            }
            else if (verificar == "Etiqueta não existe")
            {

                // Realiza o cadastro do equipamento
                string retorno;

                EquipamentoBLL cadEqupBLL = new EquipamentoBLL();
                if (!string.IsNullOrEmpty(txtID.Text))
                    retorno = cadEqupBLL.UpdateEquipamentos(equipamento);
                else
                    retorno = cadEqupBLL.CadEquip(equipamento);

                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Cadastro efetuado");
                }
            }

            btn_Limpar.PerformClick();
            LoadEquipamentos();
        }

        private void CarregarMarcasComboBox()
        {
            MarcaBLL marcaBLL = new MarcaBLL();
            DataTable dt = marcaBLL.CarregarMarcas();

            escolherMarca.DisplayMember = "Nome"; // Define a coluna a ser exibida
            escolherMarca.ValueMember = "id_marca";    // Define a coluna a ser usada como valor selecionado
            escolherMarca.DataSource = dt;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            inputEquipNome.Text = string.Empty;
            inputDesEquip.Text = string.Empty;
            inputEtiquetaEquip.Text = string.Empty;
            inputPrecoEquip.Text = string.Empty;
            inputEtiquetaEquip.Enabled = true;
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int ID_equipamento = int.Parse(txtID.Text);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este equipamento?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    equipamentoBLL.DeleteEquipamento(ID_equipamento);
                    LoadEquipamentos();
                }
                MessageBox.Show("Equipamento deletado com sucesso!");
                inputEtiquetaEquip.Enabled = true;
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarEquipamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipamentos.Rows[e.RowIndex];

                int ID_equipamento = (int)selectedRow.Cells["ID_equipamento"].Value;
                Equipamento equipamento = equipamentos.Find(f => f.ID_equipamento == ID_equipamento);

                txtID.Text = equipamento.ID_equipamento.ToString();
                inputEquipNome.Text = equipamento.Nome;
                inputPrecoEquip.Text = equipamento.Valor;
                inputDesEquip.Text = equipamento.Descricao;
                inputEtiquetaEquip.Text = equipamento.Etiqueta;
                inputEtiquetaEquip.Enabled = false;
            }
        }
    }
}
