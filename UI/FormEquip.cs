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
            DataTable dt = new DataTable();
            MarcaBLL marcaBLL = new MarcaBLL();

            dt = marcaBLL.CarregarMarcas();

            escolherMarca.DataSource = dt;

            int idMarcaSelecionada = Convert.ToInt32(escolherMarca.SelectedValue);
            foreach (DataRow row in dt.Rows)
            {
                string nomeMarca = row["Nome_marca"].ToString();

                escolherMarca.Items.Add(nomeMarca);
            }
        }
    }
}
