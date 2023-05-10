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
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        static public string servidor = "192.168.1.166";
        static public string bancoDados = "sys_patrimonial";
        static public string usuario = "at";
        static public string senha = "cadorna6667";        

        public void conexao() {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("Persist Security Info=False;server=192.168.1.166;database=sys_patrimonial;uid=at;server= 192.168.1.166; database=sys_patrimonial;uid=at;pwd=cadorna6667");
        }
    }
}
    