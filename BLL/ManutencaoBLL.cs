﻿using DAL;
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

        public List<Manutencao> GetManutencoes()
        {
            return manutencaoDAL.GetManutencoes();
        }
        public int ObterIdStatusEquipamento(int idEquipamento)
        {
            return manutencaoDAL.ObterIdStatusEquipamento(idEquipamento);
        }

    }
}
