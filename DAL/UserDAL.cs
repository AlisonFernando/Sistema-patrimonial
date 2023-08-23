using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using Org.BouncyCastle.Utilities;
using sis_patrimonial;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Data;
using Dapper;
using System.Data.Common;

namespace DAL
{
    public class UserDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirUsuario(Usuario usuario)
        {
            string senhaNaoCriptografada = usuario.Senha; // Supondo que você tenha uma propriedade 'Senha' na classe Usuario
            string senhaCriptografada = HashPassword(senhaNaoCriptografada);
            usuario.SenhaHash = senhaCriptografada;

            sql = "INSERT INTO tb_usuario(Nome, Email, Senha) VALUES (@Nome, @Email, @Senha) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.SenhaHash);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }
        private string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashedPassword;
        }

        public bool VerificarEmail(String email)
        {
            bool emailExists = false;
            string sql = "SELECT COUNT(*) FROM tb_usuario WHERE Email = @email";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        emailExists = true;
                    }
                }
            }
            return emailExists;
        }

        public List<Usuario> GetUsuarios()
        {
            using (IDbConnection connection = mConn.AbrirConexao()) {
                return connection.Query<Usuario>("SELECT id_usuario, Nome, Email, Senha FROM tb_usuario").ToList();
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            using (IDbConnection connection = mConn.AbrirConexao())
            {
                connection.Execute("UPDATE tb_usuario SET Nome = @Nome, Email = @Email WHERE id_usuario = @id_usuario", usuario);
            }
        }

        public void DeleteUsuario(int id_usuario)
        {
            using (IDbConnection connection = mConn.AbrirConexao())
            {
                connection.Execute("DELETE FROM tb_usuario WHERE id_usuario = @id_usuario", new { id_usuario });
            }
        }

    }
}
