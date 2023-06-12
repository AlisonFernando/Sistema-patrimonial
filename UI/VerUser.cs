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
    public partial class VerUser : Form
    {
        private DataTable dataTable;
        public VerUser()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void VerUser_Load(object sender, EventArgs e)
        {
            // Crie um DataTable com algumas colunas de exemplo
            dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Senha", typeof(string));

            // Adicione algumas linhas de exemplo ao DataTable
            dataTable.Rows.Add(1, "João", "alison@fafibe.com", "alison");
            dataTable.Rows.Add(1, "João", "jean@fafibe.com", "jean");
            dataTable.Rows.Add(1, "João", "camilat@fafibe.com", "camila");

            // Preencha a DataGridView com o DataTable
            dataGridView1.DataSource = dataTable;
        }
    }
}
