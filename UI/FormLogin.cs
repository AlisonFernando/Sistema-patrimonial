﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using model;

namespace UI
{
    public partial class FormLogin : Form
    {
        public UserBLL userBLL = new UserBLL();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = input_email.Text;
            string senha = input_senha.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Digite um email válido e tente novamente.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Digite uma senha válida e tente novamente.");
                return;
            }
            else if (email.Any(char.IsUpper))
            {
                MessageBox.Show("O email não pode conter letras maiúsculas.");
                return;
            }
            else if (userBLL.VerificarCredenciais(email, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Hide();

                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Closed += (s, args) => this.Close(); // Fecha o aplicativo quando a tela principal for fechada
                telaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }
    }
}
