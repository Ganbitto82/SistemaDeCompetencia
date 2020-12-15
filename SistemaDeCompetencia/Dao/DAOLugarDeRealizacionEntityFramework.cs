using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaDeCompetencia.Dao
{
    class DAOLugarDeRealizacionEntityFramework : DAOLugarDeRealizacion
    {
        public LugarDeRealizacion buscarLugarPorId(int idLugar)
        {
            try
            {
                //creamos el context
                //CompetenciaContext context = new CompetenciaContext();
                CompetenciaContext context = DAOCompetenciaEntityFramework.context;
                //retornamos el lugar con esa Id
                return context.LugarDeRealizacion.Where(l => l.LugarId == idLugar).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new Exception("Error al buscar el lugar en la Base de Datos");
            }

        }

        public List<LugarDeRealizacion> listarLugar(int deporteId, int usuarioId)
        {
                             
            try
            {
                CompetenciaContext context = DAOCompetenciaEntityFramework.context;

                List<LugarDeRealizacion> listaLugares = new List<LugarDeRealizacion>();
                //buscamos los deporteLugar con el deporteId
                var a = context.DeporteLugar.Where(c => c.DeporteId == deporteId).ToList();
                //buscamos los lugares de realizacion con usuarioId
                var b = context.LugarDeRealizacion.Where(l => l.UsuarioId == usuarioId).ToList();
                
                // recorre lo deporteLugar y los lugaresDeRealizacion con el LugarId
                //cargando una lista de lugares
                foreach (var dl in a) 
                {
                    foreach (var l in b) 
                    {
                        if (l.LugarId == dl.LugarId)

                            listaLugares.Add(l);
                    }
                         
                
                }
                return listaLugares;


            }
            catch (Exception)
            {

                throw new Exception("Error al Buscar Deporte en la Base de Datos");
            }




        }
    }
}