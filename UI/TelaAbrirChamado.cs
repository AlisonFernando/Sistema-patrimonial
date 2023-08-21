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

        }

        private void TelaAbrirChamado_Load(object sender, EventArgs e)
        {
            CarregarEtiquetasComboBox();
        }
        private void CarregarEtiquetasComboBox()
        {
            //Carregando as etiquetas de equipamentos disponiveis
            if (selectEtiqueta.SelectedIndex != -1)
            {
                // Supondo que você tenha um método para obter informações do equipamento e do colaborador
                string idEtiqueta = selectEtiqueta.SelectedValue.ToString();

                EquipamentoDAL equipamentoDAL = new EquipamentoDAL();
                string nomeEquipamento = equipamentoDAL.ObterNomeEquipamentoPorEtiqueta(idEtiqueta);
                txtEquip.Text = nomeEquipamento;
            }
            else
            {
                MessageBox.Show("Selecione uma etiqueta antes de pesquisar");
                return;
            }
        }   
    }
}
