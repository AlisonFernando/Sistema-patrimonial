﻿using BLL;
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
        private ChamadoBLL chamadoBLL;
        public TelaAbrirChamado()
        {
            InitializeComponent();
            chamadoBLL = new ChamadoBLL();
        }
        private void TelaAbrirChamado_Load(object sender, EventArgs e)
        {
            CarregarEtiquetasComboBox();
            CarregarChamadoStatusComboBox();
            CarregarNomeUsuarioComboBox();

        }

        private void CarregarEtiquetasComboBox()
        {
            DataTable dt = chamadoBLL.ChamarEtiquetasDisponiveis();

            selectEtiqueta.DisplayMember = "Etiqueta_identificacao";
            selectEtiqueta.ValueMember = "ID_equipamento";
            selectEtiqueta.DataSource = dt;
        }

        private void CarregarNomeUsuarioComboBox()
        {
            DataTable dt = chamadoBLL.EscolherNomeUsuario();

            selectUser.DisplayMember = "Nome"; // Define a coluna a ser exibida
            selectUser.ValueMember = "id_usuario";    // Define a coluna a ser usada como valor selecionado
            selectUser.DataSource = dt;
        }
        private void CarregarChamadoStatusComboBox()
        {
            DataTable dt = chamadoBLL.BuscarStatusChamado();

            selectChamado.DisplayMember = "andamento_do_chamado";
            selectChamado.ValueMember = "id_status";
            selectChamado.DataSource = dt;
        }


        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (selectEtiqueta.SelectedValue != null)
            {
                int idEquipamento = Convert.ToInt32(selectEtiqueta.SelectedValue);

                // Chamar o método BuscarNomeEquipamento do ChamadoBLL
                var nomes = chamadoBLL.BuscarNomeEquipamento(idEquipamento);

                // Exibir os nomes no TextBox
                txtEquip.Text = nomes.NomeEquipamento;
                txtColab.Text = nomes.NomeColaborador;
            }
            else
            {
                MessageBox.Show("Selecione uma etiqueta antes de pesquisar.");
            }
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtEquip.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtColab.Text = string.Empty;
        }

        private void btnCadUserSucesso_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos obrigatórios estão preenchidos
            if (selectEtiqueta.SelectedValue == null)
            {

                MessageBox.Show("Selecione uma etiqueta antes de abrir o chamado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text) || string.IsNullOrEmpty(txtDesc.Text.Trim()))
            {
                MessageBox.Show("Preencha a descrição antes de abrir o chamado.");
                return;
            }

            else if (selectUser.SelectedValue == null)
            {
                MessageBox.Show("Selecione um usuário antes de abrir o chamado.");
                return;
            }

            else if (selectChamado.SelectedValue == null)
            {
                MessageBox.Show("Selecione um status antes de abrir o chamado.");
                return;
            }

            Chamado chamado = new Chamado
            {
                DataHora = DateTime.Now,
                Descricao = txtDesc.Text,
                id_usuario = Convert.ToInt32(selectUser.SelectedValue),
                id_status = Convert.ToInt32(selectChamado.SelectedValue),
                id_equipamento = selectEtiqueta.SelectedValue.ToString(),
                id_colaborador = Convert.ToInt32(selectUser.SelectedValue),
            };

            chamadoBLL.CadChamado(chamado, Program.UserEmail);


            CarregarEtiquetasComboBox();
            LimparCampos();

            MessageBox.Show("Chamado aberto com sucesso!");
        }
        private void LimparCampos()
        {
            txtEquip.Text = string.Empty;
            txtColab.Text = string.Empty;
            txtDesc.Clear();
            selectUser.SelectedIndex = -1;
            selectChamado.SelectedIndex = -1;
            selectEtiqueta.SelectedIndex = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
