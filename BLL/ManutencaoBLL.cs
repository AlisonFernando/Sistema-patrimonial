using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManutencaoBLL
    {
        ManutencaoDAL manutencaoDAL= new ManutencaoDAL();

        public List<manutencao> GetManutencoes()
        {
            return manutencaoDAL.GetManutencoes();
        }

    }
}
