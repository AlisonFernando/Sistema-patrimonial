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

        public string HashPassword(string password)
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
        public bool InserirTokenRecuperacao(int idUsuario, string token, DateTime dataExpiracao, DateTime dataCriacao, string emailUsuarioLogado)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_token (id_usuario, token, data_expiracao, data_criacao) VALUES (@id_usuario, @token, @dataExpiracao, @dataCriacao)", connection))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@token", token);
                    cmd.Parameters.AddWithValue("@dataExpiracao", dataExpiracao);
                    cmd.Parameters.AddWithValue("@dataCriacao", dataCriacao);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Inserir o registro de log na tabela tb_logs
                    DateTime dataHoraAcao = DateTime.Now;
                    string tipoOperacao = "token de recuperação de senha gereado"; // Defina o tipo de operação conforme necessário

                    string sql = "INSERT INTO tb_logs (EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                    cmd.Parameters.Clear();
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                    cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                    cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                    cmd.ExecuteNonQuery();
                    mConn.FecharConexao();

                    return rowsAffected > 0;
                }
            }
        }

        public bool VerificarTokenRecuperacaoValido(int idUsuario, string token)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tb_token WHERE id_usuario = @idUsuario AND token = @token AND data_expiracao > NOW()", connection))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@token", token);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool AtualizarSenha(int idUsuario, string novaSenha, string emailUsuarioLogado)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE tb_usuario SET senha = @novaSenha WHERE id_usuario = @idUsuario", connection))
                {
                    cmd.Parameters.AddWithValue("@novaSenha", novaSenha);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Inserir o registro de log na tabela tb_logs
                    DateTime dataHoraAcao = DateTime.Now;
                    string tipoOperacao = "atualização de senha do usuário"; // Defina o tipo de operação conforme necessário

                    string sql = "INSERT INTO tb_logs (EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                    cmd.Parameters.Clear();
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                    cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                    cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                    cmd.ExecuteNonQuery();
                    mConn.FecharConexao();

                    return rowsAffected > 0;
                }
            }
        }


        public int ObterIdUsuarioPorEmail(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                string query = "SELECT id_usuario FROM tb_usuario WHERE email = @email";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
