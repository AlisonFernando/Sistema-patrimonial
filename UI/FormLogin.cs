using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using model;

namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login modelLogin = new Login();
            modelLogin.Email = input_email.Text;
            modelLogin.Password = input_email.Text;

            LoginBLL loginBLL = new LoginBLL();
        }
    }
}
