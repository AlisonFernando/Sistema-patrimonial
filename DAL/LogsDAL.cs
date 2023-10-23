using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static model.Logs;

namespace DAL
{
    public class LogsDAL
    {
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@";

        public void InserirLog(Logs log)
        {
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                string query = "INSERT INTO tb_logs (Data_hora, operacao, entidade, id_Usuario) " +
                               "VALUES (@DataHora, @Operacao, @Entidade, @IdUsuario)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DataHora", log.DataHora);
                cmd.Parameters.AddWithValue("@Operacao", log.Operacao);
                cmd.Parameters.AddWithValue("@Entidade", log.Entidade);
                cmd.Parameters.AddWithValue("@IdUsuario", log.IdUsuario);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Logs> ObterLogs()
        {
            List<Logs> logs = new List<Logs>();

            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                string query = "SELECT * FROM tb_logs";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Logs log = new Logs
                        {
                            IdLog = Convert.ToInt32(reader["id_log"]),
                            DataHora = Convert.ToDateTime(reader["Data_hora"]),
                            Operacao = reader["Operacao"].ToString(),
                            Entidade = reader["Entidade"].ToString(),
                            IdUsuario = Convert.ToInt32(reader["Id_Usuario"])
                        };
                        logs.Add(log);
                    }
                }
            }

            return logs;
        }
    }
}
