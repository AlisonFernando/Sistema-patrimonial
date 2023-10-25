using BLL;
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
        public CadEquipamento(Equipamento equipamento)
        {
            InitializeComponent();

            if (equipamento != null)
            {
                txtID.Text = equipamento.ID_equipamento.ToString();
                inputEquipNome.Text = equipamento.nome;
                inputDesEquip.Text = equipamento.descricao;
                inputPrecoEquip.Text = equipamento.valor;
                inputEtiquetaEquip.Text = equipamento.etiqueta.ToString();
            }
        }
        private void CadEquipamento_Load(object sender, EventArgs e)
        {
            CarregarMarcasComboBox();
            LoadEquipamentos();
            inputEtiquetaEquip.Enabled = true;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

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
            else if (string.IsNullOrWhiteSpace(equipamento.Valor))
            {
                MessageBox.Show("Verifique o valor digitado e tente novamente");
                return;
            }
            else if (equipamento.Etiqueta.Contains(" ") || equipamento.Valor.Contains(" "))
            {
                MessageBox.Show("Nome, descrição, etiqueta e valor não podem conter espaços em branco.");
                return;
            }

            // Verificação da etiqueta no banco de dados (apenas durante inserção)
            if (string.IsNullOrEmpty(txtID.Text))
            {
                EquipamentoBLL verificaretiqueta = new EquipamentoBLL();
                string verificar = verificaretiqueta.VerificarEtiqueta(equipamento.Etiqueta);

                if (verificar == "Etiqueta existente")
                {
                    MessageBox.Show("Essa etiqueta existe no banco de dados");
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
                MessageBox.Show("Aplicação com sucesso");
            }

            btn_Limpar.PerformClick();
            LoadEquipamentos();
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
                    equipamentoBLL.DeleteEquipamento(ID_equipamento, Program.UserEmail);
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

        public void MostrarEquipamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
