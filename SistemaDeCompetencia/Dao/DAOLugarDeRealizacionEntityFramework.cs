using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    class DAOLugarDeRealizacionEntityFramework : DAOLugarDeRealizacion
    {
        public LugarDeRealizacion buscarLugarPorId(int idLugar)
        {
            try
            {
                //creamos el context
                CompetenciaContext context = new CompetenciaContext();
                //retornamos el lugar con esa Id
                return context.LugarDeRealizacion.Where(l => l.LugarId == idLugar).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new Exception("Error al buscar el lugar en la Base de Datos");
            }

        }
    }
}
