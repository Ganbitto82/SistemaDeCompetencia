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

            List<DeporteLugar> listaDeporteLugar = new List<DeporteLugar>();

            List<DeporteLugar> listaID = new List<DeporteLugar>();

            List<LugarDeRealizacion> listaTodosLugares = new List<LugarDeRealizacion>();

            List<LugarDeRealizacion> listaLugares = new List<LugarDeRealizacion>();
            CompetenciaContext context = DAOCompetenciaEntityFramework.context;
            //CompetenciaContext context = new CompetenciaContext();
            try
            {

                //obtenemos la lista de DeporteLugar
                listaDeporteLugar.AddRange(context.DeporteLugar);
                //obtenemos la lista de DeporteLugar
                listaTodosLugares.AddRange(context.LugarDeRealizacion);

                //agregamos al set listaDeportes los idDelugares que haya utilizado el usuario en algun LugarDeRealizacion
                foreach (var deporteLugar in listaDeporteLugar)
                {
                    if (deporteLugar.DeporteId.Equals(deporteId))

                        listaID.Add(deporteLugar);
                }

                foreach (var Lugar in listaID)
                {
                    listaLugares.Add(context.LugarDeRealizacion.Where(l => l.LugarId == Lugar.LugarId && l.UsuarioId == usuarioId).FirstOrDefault());
                }

                //retornamos la lista de deportes
                return listaLugares.ToList();


            }
            catch (Exception)
            {

                throw new Exception("Error al Buscar Deporte en la Base de Datos");
            }




        }
    }
}