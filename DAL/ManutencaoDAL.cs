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
    public class ManutencaoDAL
    {
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";

        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;



        public List<manutencao> GetManutencoes()
        {
            List<manutencao> manutencaoList = new List<manutencao>();

            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();

                string query = "SELECT M.*, C.descricao AS ChamadoDescricao, U.Nome AS UsuarioNome, E.Nome_equipamento, S.andamento_do_chamado " +
                               "FROM tb_manutencao M " +
                               "INNER JOIN tb_chamado C ON M.id_chamado = C.id_chamado " +
                               "INNER JOIN tb_usuario U ON C.id_usuario = U.id_usuario " +
                               "INNER JOIN tb_equipamentos E ON M.ID_equipamento = E.ID_equipamento " +
                               "INNER JOIN tb_status S ON M.id_status = S.id_status;"; 

                connection.Close();
            }

            return manutencaoList;
        }


    }
}
