using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static model.Logs;

namespace BLL
{
    public class LogsBLL
    {
        private LogsDAL logsDAL;

        public void InserirLog(Logs log)
        {
            // Inserir o registro de log na camada de acesso a dados (LogsDAL)
            logsDAL.InserirLog(log);
        }

        public List<Logs> ObterLogs()
        {
            // Recuperar a lista de registros de log da camada de acesso a dados (LogsDAL)
            return logsDAL.ObterLogs();
        }
    }
}
