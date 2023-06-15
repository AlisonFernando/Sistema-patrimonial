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
            Marca marca= new Marca();

            marca.Nome = inputMarcaNome.Text;


            // Executa a verificação se caso o usuário não digitar nenhum valor nos campos
            if (marca.Nome.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique seu nome e tente novamente");
                return;
            }

            // Verifica se o nome da marca digitada já existe
            MarcaBLL verificarMarcaBLL = new MarcaBLL();
            string verificar = verificarMarcaBLL.VerificarMarca(marca.Nome);

            if (verificar == "Marca existente")
            {
                MessageBox.Show("A marca digitada já existe no banco de dados");
                return;
            }
            else if (verificar == "Marca não existe")
            {

                // Realiza o cadastro do usuário
                MarcaBLL marcaBLL = new MarcaBLL();
                string retorno = marcaBLL.CadMarca(marca);

                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Marca cadastrada");

                }
            }
        }
    }
}
