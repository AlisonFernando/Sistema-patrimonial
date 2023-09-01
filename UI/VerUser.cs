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
    public partial class VerUser : Form
    {
        private UserBLL userBLL = new UserBLL();
        private List<Usuario> usuarios = new List<Usuario>();
        public VerUser()
        {
            InitializeComponent();
        }

        public void VerUser_Load(object sender, EventArgs e)
        {
            LoadUsuarios();
        }
        public void LoadUsuarios()
        {
            usuarios = userBLL.GetUsuarios();
            MostrarUsuarios.DataSource = usuarios;
        }
    }
}
