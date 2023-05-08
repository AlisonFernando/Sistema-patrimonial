using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class ConexaoDB
    {
        static private string servidor = "192.168.1.166";
        static private string bancoDados = "sys_patrimonial";
        static private string usuario = "at";
        static private string senha = "cadorna6667";

        static public string strConn = $"server={servidor}; User Id={usuario}; database={bancoDados}; password={senha}";
    }
}
