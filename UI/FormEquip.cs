﻿using BLL;
using DAL;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CadEquipamento : Form
    {
        private EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
        private List<Equipamento> equipamentos = new List<Equipamento>();
        private List<Equipamento> equipamentosDesativados = new List<Equipamento>();
        public CadEquipamento(Equipamento equipamento)
        {
            InitializeComponent();

            if (equipamento != null)
            {
                inputEtiquetaEquip.Enabled = false;
                txtID.Text = equipamento.ID_equipamento.ToString();
                inputEquipNome.Text = equipamento.nome;
                inputDesEquip.Text = equipamento.descricao;
                inputPrecoEquip.Text = equipamento.valor;
                inputEtiquetaEquip.Text = equipamento.etiqueta.ToString();
                inputEtiquetaEquip.Enabled = false;
                
            }
        }
        private void CadEquipamento_Load(object sender, EventArgs e)
        {
            CarregarMarcasComboBox();
            LoadEquipamentosAtivos();
            LoadEquipamentosDesativados();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

        }
        public void LoadEquipamentosAtivos()
        {
            equipamentos = equipamentoBLL.GetEquipamentosAtivos();
            MostrarEquipamentosAtivos.DataSource = equipamentos;
            inputEtiquetaEquip.Enabled = true;
        }
        public void LoadEquipamentosDesativados()
        {
            equipamentosDesativados = equipamentoBLL.GetEquipamentosDesativados();
            MostrarEquipamentosDesativados.DataSource = equipamentosDesativados;
            inputEtiquetaEquip.Enabled = true;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Equipamento equipamento = new Equipamento();

            if (!string.IsNullOrEmpty(txtID.Text))
                equipamento.ID_equipamento = int.Parse(txtID.Text);

            equipamento.Nome = inputEquipNome.Text;
            equipamento.Descricao = inputDesEquip.Text;
            equipamento.Valor = inputPrecoEquip.Text;
            equipamento.Etiqueta = inputEtiquetaEquip.Text;
            equipamento.Ativo_inativo = check_ativo.Checked;

            // Habilita apenas o campo "etiqueta" durante a atualização
            inputEtiquetaEquip.Enabled = string.IsNullOrEmpty(txtID.Text);

            // Verificação de espaços em branco nos campos Nome, Descrição, Etiqueta e Valor
            if (string.IsNullOrEmpty(equipamento.Nome))
            {
                MessageBox.Show("Verifique o nome e tente novamente");
                return;
            }
            else if (string.IsNullOrEmpty(equipamento.Descricao))
            {
                MessageBox.Show("Verifique a descrição e tente novamente");
                return;
            }
            else if (string.IsNullOrWhiteSpace(equipamento.Etiqueta))
            {
                MessageBox.Show("Verifique a etiqueta e tente novamente");
                return;
            }
            else if (equipamento.Etiqueta.Contains(" "))
            {
                MessageBox.Show("Etiqueta não pode conter espaços em branco.");
                return;
            }

            if (!check_ativo.Checked)
            {
                MessageBox.Show("É necessário selecionar a opção Ativo para cadastrar/editar o equipamento.");
                return;
            }

            // Verificação da etiqueta no banco de dados (apenas durante inserção)
            if (string.IsNullOrEmpty(txtID.Text))
            {
                EquipamentoBLL verificaretiqueta = new EquipamentoBLL();
                string verificar = verificaretiqueta.VerificarEtiqueta(equipamento.Etiqueta);

                if (verificar == "Etiqueta existente")
                {
                    MessageBox.Show("Essa etiqueta já existe no banco de dados");
                    return;
                }
            }

            // Realiza o cadastro ou atualização do equipamento
            string retorno;
            EquipamentoBLL cadEqupBLL = new EquipamentoBLL();

            if (!string.IsNullOrEmpty(txtID.Text))
                retorno = cadEqupBLL.UpdateEquipamentos(equipamento, Program.UserEmail);
            else
                retorno = cadEqupBLL.CadEquip(equipamento, Program.UserEmail);

            if (retorno == "Sucesso")
            {
                MessageBox.Show("Operação realizada com sucesso");
                btn_Limpar.PerformClick();
                LoadEquipamentosAtivos();
                LoadEquipamentosDesativados();
            }

            btn_Limpar.PerformClick();
            LoadEquipamentosAtivos();
            LoadEquipamentosDesativados();
        }

        private void CarregarMarcasComboBox()
        {
            MarcaBLL marcaBLL = new MarcaBLL();
            DataTable dt = marcaBLL.CarregarMarcas();

            escolherMarca.DisplayMember = "Nome"; // Define a coluna a ser exibida
            escolherMarca.ValueMember = "id_marca"; // Define a coluna a ser usada como valor selecionado
            escolherMarca.DataSource = dt;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            inputEquipNome.Text = string.Empty;
            inputDesEquip.Text = string.Empty;
            inputEtiquetaEquip.Text = string.Empty;
            inputPrecoEquip.Text = string.Empty;
            inputEtiquetaEquip.Enabled = true;
            LoadEquipamentosAtivos();
            LoadEquipamentosDesativados();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVerEquips telaVerEquips = new TelaVerEquips();
            telaVerEquips.ShowDialog();
        }

        private void inputPrecoEquip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Se o caractere é um número ou ponto decimal, atualize o valor formatado
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                string textoAtual = inputPrecoEquip.Text.Replace("R$", "").Trim();
                if (decimal.TryParse(textoAtual, out decimal preco))
                {
                    string valorFormatado = string.Format(new CultureInfo("pt-BR"), "R${0:N2}", preco);
                    inputPrecoEquip.Text = valorFormatado;
                }
            }
        }

        private void btn_Desativar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idEquipamento = int.Parse(txtID.Text);
                equipamentoBLL.DesativarEquipamento(idEquipamento);
                MessageBox.Show("Equipamento desativado com sucesso.");
                LoadEquipamentosAtivos();
                LoadEquipamentosDesativados();
            }
            else
            {
                MessageBox.Show("Selecione um Setor para desativar.");
            }
        }

        private void MostrarEquipamentosAtivos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipamentosAtivos.Rows[e.RowIndex];

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

        private void MostrarEquipamentosDesativados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarEquipamentosDesativados.Rows[e.RowIndex];

                int ID_equipamento = (int)selectedRow.Cells["ID_equipamentoDesativado"].Value;
                Equipamento equipamento = equipamentosDesativados.Find(f => f.ID_equipamento == ID_equipamento);

                txtID.Text = ID_equipamento.ToString();
                inputEquipNome.Text = equipamento.Nome;
                inputPrecoEquip.Text = equipamento.Valor;
                inputDesEquip.Text = equipamento.Descricao;
                inputEtiquetaEquip.Text = equipamento.Etiqueta;
                inputEtiquetaEquip.Enabled = false;
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idEquip = int.Parse(txtID.Text);
                equipamentoBLL.AtivarEquipamentos(idEquip);
                MessageBox.Show("Equipamento ativado com sucesso.");
                LoadEquipamentosAtivos();
                LoadEquipamentosDesativados();
            }
            else
            {
                MessageBox.Show("Selecione um equipamento para ativar.");
            }
        }

        private void btnPesquisarAtivo_Click(object sender, EventArgs e)
        {
            string nomePesquisado = inputEquipNome.Text.Trim();

            // Verificar se a marca pesquisada está nas marcas ativas
            Equipamento EquipAtivo = equipamentos
                .FirstOrDefault(equipamento => equipamento.Nome.Equals(nomePesquisado, StringComparison.OrdinalIgnoreCase));

            // Verificar se a marca pesquisada está nas marcas desativadas
            Equipamento EquipDesativado = equipamentosDesativados
                .FirstOrDefault(equipamento => equipamento.Nome.Equals(nomePesquisado, StringComparison.OrdinalIgnoreCase));

            if (EquipAtivo != null)
            {
                MessageBox.Show($"O equipamento '{EquipAtivo.Nome}' está ativo.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarEquipamentosAtivos.DataSource = new List<Equipamento> { EquipAtivo };
            }
            else if (EquipDesativado != null)
            {
                MessageBox.Show($"O equipamento '{EquipDesativado.Nome}' está desativada.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarEquipamentosDesativados.DataSource = new List<Equipamento> { EquipDesativado };
            }
            else
            {
                MessageBox.Show("Equipamento não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputEquipNome.Text = string.Empty;
            inputDesEquip.Text = string.Empty;
            inputEtiquetaEquip.Text = string.Empty;
            inputPrecoEquip.Text = string.Empty;
            inputEtiquetaEquip.Enabled = true;
            LoadEquipamentosAtivos();
            LoadEquipamentosDesativados();
            LoadEquipamentosAtivos();
            LoadEquipamentosDesativados();
        }
    }
}
