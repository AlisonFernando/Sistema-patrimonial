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
    public partial class TelaCadastrarMarca : Form
    {
        public TelaCadastrarMarca()
        {
            InitializeComponent();
        }

        private void CadastrarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nome = inputMarcaNome.Text;

            // Verifica se o nome da marca está em branco ou contém apenas espaços em branco
            if (string.IsNullOrWhiteSpace(marca.Nome) || marca.Nome.Trim() == "")
            {
                MessageBox.Show("O nome da marca não pode ficar em branco ou conter apenas espaços em branco.");
                return;
            }

            MarcaBLL marcaBLL = new MarcaBLL();
            string verificar = marcaBLL.VerificarMarca(marca.Nome);

            if (verificar == "Marca existente")
            {
                MessageBox.Show("A marca já existe no banco de dados.");
            }
            else if (verificar == "Marca não existe")
            {
                string retorno = marcaBLL.CadMarca(marca);
                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Marca cadastrada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a marca no banco de dados.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
