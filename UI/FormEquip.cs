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
    public partial class CadEquip : Form
    {
        public CadEquip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipamento equipamento = new Equipamento();
            Marca marca = new Marca();

            equipamento.Nome = inputEquipNome.Text;
            equipamento.Descricao = inputDesEquip.Text;
            equipamento.Valor = inputPrecoEquip.Text;
            equipamento.Etiqueta = inputEtiquetaEquip.Text;
            equipamento.Ativo_inativo = check_ativo.Checked;
            equipamento.marca_id = escolherMarca.SelectedValue.ToString();

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

            EquipamentoBLL vequipamentoBLL = new EquipamentoBLL();
            string verificar = vequipamentoBLL.VerificarEtiqueta(equipamento.Etiqueta);

            if (verificar == "Etiqueta existente")
            {
                MessageBox.Show("A etiqueta já existe no banco de dados");
                return;
            }

            else if (verificar == "Etiqueta não existe")
            {

                // Realiza o cadastro do equipamento
                EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
                string retorno = equipamentoBLL.CadEquip(equipamento);

                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Cadastro efetuado");

                }
            }
        }

        private void CadEquip_Load(object sender, EventArgs e)
        {
            CarregarMarcasComboBox();
        }

        private void CarregarMarcasComboBox()
        {
            MarcaBLL marcaBLL = new MarcaBLL();
            DataTable dt = marcaBLL.CarregarMarcas();

            escolherMarca.DisplayMember = "Nome_marca"; // Define a coluna a ser exibida
            escolherMarca.ValueMember = "ID_marca";    // Define a coluna a ser usada como valor selecionado
            escolherMarca.DataSource = dt;
        }
    }
}
