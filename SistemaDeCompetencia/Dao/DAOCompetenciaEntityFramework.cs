using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    class DAOCompetenciaEntityFramework : DAOCompetencia
    {
        public List<Competencia> buscarPorNombre(string nombreCompetencia)
        {
            //creamos el context
            CompetenciaContext context = new CompetenciaContext();
            try
            {
                // buscamos las competencias con ese nombre
                List<Competencia> competencias = context.Competencia.Where(c => c.Nombre == nombreCompetencia).ToList();

                //retornamos las competencias que no fueron dadas de baja
                return competencias.FindAll(c => c.DarDeBaja == false);
            }
            catch (Exception)
            {

                throw new Exception("Error al buscar Competencia en la Base de datos.");
            }
        }
       
         
    }
}         


