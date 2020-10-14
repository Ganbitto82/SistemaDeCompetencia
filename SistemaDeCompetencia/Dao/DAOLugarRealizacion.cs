using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
   interface DAOLugarDeRealizacion
    {
        List<LugarDeRealizacion> listarLugar(int deporteId, int usuarioId);
        LugarDeRealizacion buscarLugarPorId(int idLugar);
    }
}
