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
    public partial class SelectEquips : Form
    {
        Equipamento equipamento = new Equipamento();
        Colaborador colaborador = new Colaborador();
        public SelectEquips()
        {
            InitializeComponent();
        }

        private void MostrarEquipsDisponiveis_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
