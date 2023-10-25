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
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";
        public void InserirUsuario(Usuario usuario, string emailUsuarioLogado)
        {
            string senhaNaoCriptografada = usuario.Senha;
            string senhaCriptografada = HashPassword(senhaNaoCriptografada);
            usuario.SenhaHash = senhaCriptografada;

            // Inserir o usuário na tabela tb_usuario
            sql = "INSERT INTO tb_usuario(Nome, Email, Senha, UserAcesso) VALUES (@Nome, @Email, @Senha, @UserAcesso)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);
            cmd.Parameters.AddWithValue("@Senha", usuario.SenhaHash);
            cmd.Parameters.AddWithValue("@UserAcesso", usuario.UserAcesso);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();

            // Inserir o registro de log na tabela tb_logs
            DateTime dataHoraAcao = DateTime.Now;
            string tipoOperacao = "cadastro de usuário"; // Defina o tipo de operação conforme necessário

            sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
            cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
            cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

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
        
        public string ObterSenhaCriptografada(string usuario)
        {
            string sql = "SELECT Senha FROM tb_usuario WHERE Email = @usuario";
            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    return command.ExecuteScalar() as string;
                }
            }
        }
        
        public List<Usuario> GetUsuarios()
        {
            
            using(IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Usuario>("SELECT id_usuario, Nome, Email, Senha, UserAcesso FROM tb_usuario").ToList();
            }
        }
        public void UpdateUsuario(Usuario usuario, string emailUsuarioLogado)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "UPDATE tb_usuario SET Nome = @Nome, Email = @Email WHERE id_usuario = @id_usuario";
                dbConnection.Execute(query, usuario);

                mConn.FecharConexao();

                // Inserir o registro de log na tabela tb_logs
                DateTime dataHoraAcao = DateTime.Now;
                string tipoOperacao = "atualização de usuário"; // Defina o tipo de operação conforme necessário

                sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                cmd = new MySqlCommand(sql, mConn.AbrirConexao());

                cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                cmd.ExecuteNonQuery();
                mConn.FecharConexao();
            }
        }

        public void DeleteUsuario(int id_usuario, Usuario usuario, string emailUsuarioLogado)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "DELETE FROM tb_usuario WHERE id_usuario = @id_usuario";
                dbConnection.Execute(query, new { id_usuario });

                mConn.FecharConexao();

                // Inserir o registro de log na tabela tb_logs
                DateTime dataHoraAcao = DateTime.Now;
                string tipoOperacao = "cadastro de usuário"; // Defina o tipo de operação conforme necessário

                sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                cmd = new MySqlCommand(sql, mConn.AbrirConexao());

                cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                cmd.ExecuteNonQuery();
                mConn.FecharConexao();
            }
        }
        public int ObterUserChamado(string email)
        {
            sql = "SELECT UserAcesso FROM tb_usuario WHERE Email = @Email";

            cmd = new MySqlCommand(sql, mConn.AbrirConexao());
            cmd.Parameters.AddWithValue("@Email", email);
            var result = cmd.ExecuteScalar();
            mConn.FecharConexao();

            return result == DBNull.Value ? -1 : Convert.ToInt32(result);
        }
    }
}
