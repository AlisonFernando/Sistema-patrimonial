using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ConexaoDB
    {
        public MySqlConnection mConn;

        public string conec = "Persist Security Info = False; server=192.168.1.166;database=sys_patrimonial;uid=at";

        public MySqlConnection AbrirConexao()
        {
            mConn = new MySqlConnection(conec);
            mConn.Open();

            return mConn;
        }
        public void FecharConexao()
        {
            mConn = new MySqlConnection(conec);
            mConn.Clone();
            mConn.Dispose();
            mConn.ClearAllPoolsAsync();
        }
    }
}