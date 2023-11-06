using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StatusDAL
    {
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public DataTable CarregarStatus()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM tb_status";

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
        public bool AtualizarStatusEquipamento(int id_equipamento, int idStatus, string emailUsuarioLogado, string novaDescricao)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;

                    try
                    {
                        // Iniciar uma transação para garantir a consistência das atualizações
                        command.Transaction = connection.BeginTransaction();

                        // Atualizar a coluna "descricao" na tabela "tb_manutencao"
                        string descricaoQuery = "UPDATE tb_manutencao SET id_status = @idStatus, descricao = @novaDescricao WHERE id_equipamento = @id_equipamento";
                        command.CommandText = descricaoQuery;

                        command.Parameters.AddWithValue("@idStatus", idStatus);
                        command.Parameters.AddWithValue("@novaDescricao", novaDescricao);
                        command.Parameters.AddWithValue("@id_equipamento", id_equipamento);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Verificar se a atualização foi bem-sucedida
                        if (rowsAffected > 0)
                        {
                            // Inserir o registro de log na tabela "tb_logs"
                            DateTime dataHoraAcao = DateTime.Now;
                            string tipoOperacao = "atualização no status do chamado"; // Defina o tipo de operação conforme necessário

                            string logQuery = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                            command.CommandText = logQuery;

                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                            command.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                            command.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                            command.ExecuteNonQuery();

                            // Confirmar a transação
                            command.Transaction.Commit();

                            return true; // Atualização bem-sucedida
                        }
                        else
                        {
                            // Rollback da transação se a atualização não afetar nenhuma linha
                            command.Transaction.Rollback();
                            return false; // Nenhuma linha afetada, atualização não bem-sucedida
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Lidar com exceções do MySQL, registrar erros ou fazer qualquer ação necessária
                        Console.WriteLine("Erro MySQL: " + ex.Message);

                        // Rollback da transação em caso de erro
                        command.Transaction.Rollback();

                        return false; // Erro no MySQL, atualização não bem-sucedida
                    }
                }
            }
        }
    }
}
