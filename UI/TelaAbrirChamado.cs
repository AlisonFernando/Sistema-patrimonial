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
    public partial class TelaAbrirChamado : Form
    {

        public TelaAbrirChamado()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            if (selectEtiqueta.SelectedIndex != -1)
            {
                EquipamentoDAL equipamentoDAL = new EquipamentoDAL();
                

                // Obtenha o ID do equipamento selecionado na etiqueta
                //string nomeColaborador = colaboradorDAL.ObterNomeColaboradorPorId.SelectedValue.ToString();
                
                // Use o ID do equipamento para buscar o nome do equipamento correspondente
                //string nomeEquipamento = equipamentoDAL.ObterNomeEquipamentoPorId(idEquipamento);

                // Exiba o nome do equipamento no TextBox
                //txtEquip.Text = nomeEquipamento;
                //txtColab.Text = nomeColaborador;
            }
            else
            {
                MessageBox.Show("Selecione uma etiqueta antes de pesquisar.");
            }

        }

        private void TelaAbrirChamado_Load(object sender, EventArgs e)
        {
            CarregarEtiquetasComboBox();
        }
        private void CarregarEtiquetasComboBox()
        {
            ChamadoBLL chamadoBLL = new ChamadoBLL();
            DataTable dt = chamadoBLL.ChamarEtiquetas();

            selectEtiqueta.DisplayMember = "Etiqueta_identificacao";
            selectEtiqueta.ValueMember = "ID_equipamento";
            selectEtiqueta.DataSource = dt;
        }

    }
}
