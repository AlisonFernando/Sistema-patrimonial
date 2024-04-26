﻿using System;
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

        public string conec = "Persist Security Info = False; server=[servidor];database=[banco de dados];uid=[usuario];pwd=[senha];";

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
