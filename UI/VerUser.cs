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
            btnPesquisar.Click += new EventHandler(btnPesquisar_Click);
            MostrarUsuarios.CellMouseDoubleClick += MostrarUsuarios_CellMouseDoubleClick;
        }
        public void LoadUsuarios()
        {
            usuarios = userBLL.GetUsuarios();
            MostrarUsuarios.DataSource = usuarios;
        }

        private void btnVerEquips_Click(object sender, EventArgs e)
        {
            this.Close();
            UI.TelaCadUser telaCadUser = new UI.TelaCadUser(null);
            telaCadUser.ShowDialog();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisar.Text.Trim();
            List<Usuario> usuariosFiltrados = usuarios
                .Where(usuario => usuario.Nome.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (usuariosFiltrados.Count == 0)
            {
                MessageBox.Show("Usuario não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite o nome do usuario e tente novamente");
                txtPesquisar.Focus();
            }
            else
            {
                MostrarUsuarios.DataSource = usuariosFiltrados;
            }
        }

        private void MostrarUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarUsuarios.Rows[e.RowIndex];

                int id_usuario = (int)selectedRow.Cells["Id"].Value;
                Usuario usuario = usuarios.Find(f => f.id_usuario == id_usuario);

                TelaCadUser telaCadUser = new TelaCadUser(usuario);

                telaCadUser.ShowDialog();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            UI.TelaPrincipal telaPrincipal = new UI.TelaPrincipal();
            telaPrincipal.ShowDialog();
        }

        private void MostrarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
