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
        public bool AtualizarStatusEquipamento(int id_equipamento, int idStatus)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();

                string query = "UPDATE tb_manutencao SET id_status = @idStatus WHERE id_equipamento = @id_equipamento";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Adicione os parâmetros com seus valores
                    command.Parameters.AddWithValue("@idStatus", idStatus);
                    command.Parameters.AddWithValue("@id_equipamento", id_equipamento);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verifique se a atualização foi bem-sucedida
                        if (rowsAffected > 0)
                        {
                            return true; // Atualização bem-sucedida
                        }
                        else
                        {
                            return false; // Nenhuma linha afetada, atualização não bem-sucedida
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Lide com exceções do MySQL, registre erros ou faça qualquer ação necessária
                        Console.WriteLine("Erro MySQL: " + ex.Message);
                        return false; // Erro no MySQL, atualização não bem-sucedida
                    }
                }
            }

            return false; // O código não deve chegar até aqui, mas forneça um valor padrão para cobrir todos os cenários
        }



    }
}
