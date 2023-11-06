using Dapper;
using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ColaboradorDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";

        public void InserirColaborador(Colaborador colaborador, string emailUsuarioLogado)
        {
            string ativo = "0";
            if (colaborador.Ativo_inativo)
            {
                ativo = "1";
            }
            string senhaNaoCriptografada = colaborador.SenhaColaborador;
            string senhaCriptografada = HashPassword(senhaNaoCriptografada);
            colaborador.SenhaHash = senhaCriptografada;

            sql = "INSERT INTO tb_colaborador(Nome, Email, Agenda, Telefone, Ativo_inativo, Senha, id_setor) VALUES " +
                  "(@NomeColaborador, @EmailColaborador, @AgendaColaborador, @TelefoneColaborador, @Ativo_inativo, @senha_colaborador, @id_setor) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nomeColaborador", colaborador.NomeColaborador);
            cmd.Parameters.AddWithValue("@emailColaborador", colaborador.EmailColaborador);
            cmd.Parameters.AddWithValue("@agendaColaborador", colaborador.AgendaColaborador);
            cmd.Parameters.AddWithValue("@telefoneColaborador", colaborador.TelefoneColaborador);
            cmd.Parameters.AddWithValue("@ativo_inativo", ativo);
            cmd.Parameters.AddWithValue("@senha_colaborador", colaborador.SenhaHash);
            cmd.Parameters.AddWithValue("@id_setor", colaborador.id_setor);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();


            // Inserir o registro de log na tabela tb_logs
            DateTime dataHoraAcao = DateTime.Now;
            string tipoOperacao = "cadastro de colaborador"; // Defina o tipo de operação conforme necessário

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


        public int ObterIdColaboradorPorNome(string nomeColaborador)
        {
            int idColaborador = -1; // Valor padrão caso o colaborador não seja encontrado

            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();

                string query = "SELECT id_colaborador FROM tb_colaborador WHERE Nome = @nomeColaborador";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nomeColaborador", nomeColaborador);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idColaborador = Convert.ToInt32(result);
                }

                connection.Close();
            }

            return idColaborador;
        }


        public void AssociarEquipamentosAoColaborador(int id_colaborador, List<int> idsEquipamentosSelecionados)
        {
            // Conexão com o banco de dados MySQL (substitua com suas configurações)
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();

                foreach (int ID_equipamento in idsEquipamentosSelecionados)
                {
                    // Atualize a tabela tb_equipamentos com o ID do colaborador
                    string updateQuery = "UPDATE tb_equipamentos SET id_colaborador = @id_colaborador WHERE ID_equipamento = @ID_equipamento";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@id_colaborador", id_colaborador);
                    cmd.Parameters.AddWithValue("@ID_equipamento", ID_equipamento);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public bool VerificarNome(String nomeColab)
        {
            bool nomeExists = false;
            string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Nome = @nomeColaborador";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nomeColaborador", nomeColab);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        nomeExists = true;
                    }
                }
            }
            return nomeExists;
        }
        public void SalvarEquipamentosSelecionados(List<string> idsSelecionados)
        {
            string sql = "INSERT INTO tb_colaborador (equipamento_id) VALUES (@ID_equipamento)";
            using (MySqlConnection connection = mConn.AbrirConexao()) {

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {

                    foreach (string id in idsSelecionados)
                    {
                        
                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID_equipamento", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        public string ObterNomeColaboradorPorId(string idcolaborador)
        {
            string nomeColaborador = string.Empty;

            string sql = "SELECT Nome_colaborador FROM tb_colaborador WHERE ID_colaborador = @id";
            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idcolaborador);
                    nomeColaborador = cmd.ExecuteScalar() as string;
                }
            }
            return nomeColaborador;
        }

        public List<Colaborador> GetColaboradoresAtivosComSetor()
        {
            List<Colaborador> colaboradores = new List<Colaborador>();

            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();

                string query = "SELECT c.ID_colaborador, c.Nome, c.Email, c.Telefone, c.Agenda, s.Nome_setor " +
                              "FROM tb_colaborador c " +
                              "INNER JOIN tb_setor s ON c.id_setor = s.id_setor " +
                              "WHERE c.Ativo_inativo = 1";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Colaborador colaborador = new Colaborador();

                            colaborador.ID_colaborador = (int)reader["ID_colaborador"];
                            colaborador.NomeColaborador = reader["Nome"].ToString();
                            colaborador.EmailColaborador = reader["Email"].ToString();
                            colaborador.TelefoneColaborador = reader["Telefone"].ToString();
                            colaborador.AgendaColaborador = reader["Agenda"].ToString();
                            colaborador.SetorNome = reader["Nome_setor"].ToString();

                            colaboradores.Add(colaborador);

                        }
                        
                    }
                }

                connection.Close();
            }

            return colaboradores;
        }
        public void DesativarColaborador(int ID_Colab)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                using (var transaction = dbConnection.BeginTransaction())
                {
                    try
                    {
                        // Passo 1: Desativar o colaborador
                        string queryDesativarColaborador = "UPDATE tb_colaborador SET Ativo_inativo = 0 WHERE ID_colaborador = @ID_Colab";
                        dbConnection.Execute(queryDesativarColaborador, new { ID_Colab = ID_Colab }, transaction);

                        // Passo 2: Atualizar os equipamentos associados ao colaborador
                        string queryAtualizarEquipamentos = "UPDATE tb_equipamentos SET id_colaborador = NULL WHERE id_colaborador = @ID_Colab";
                        dbConnection.Execute(queryAtualizarEquipamentos, new { ID_Colab = ID_Colab }, transaction);

                        // Commit da transação se tudo for bem
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Lidar com erros e fazer um rollback da transação se algo der errado
                        transaction.Rollback();
                        throw; // Re-throw da exceção para notificar que algo deu errado
                    }
                }
            }
        }

        public Colaborador ObterColaboradorPorID(int idColaborador)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                string query = "SELECT * FROM tb_colaborador WHERE ID_colaborador = @idColaborador";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idColaborador", idColaborador);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Colaborador colaborador = new Colaborador
                        {
                            ID_colaborador = Convert.ToInt32(reader["ID_colaborador"]),
                            NomeColaborador = reader["NomeColaborador"].ToString(),
                            // Adicione outros campos conforme necessário
                        };
                        return colaborador;
                    }
                    return null; // Se não encontrou o colaborador
                }
            }
        }

        public DataTable ConsultarColaborador()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Nome FROM tb_colaborador WHERE Ativo_inativo = 1";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}
