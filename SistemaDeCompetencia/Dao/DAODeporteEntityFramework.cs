using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    class DAODeporteEntityFramework : DAODeporte
    {
        public List<Deporte> listarDeportes(int idUsuario)
        {   
            //Inicializamos un Set de deportes (los Set no permiten elementos repetidos
            HashSet<Deporte> listaDeportes = new HashSet<Deporte>();
            //inicializamos una lista de DeporteLugar
            List<DeporteLugar> listaDeporteLugares = new List<DeporteLugar>();
            //creamos el context
            CompetenciaContext context = new CompetenciaContext();


            try
            {


                //obtenemos la lista de DeporteLugar
                listaDeporteLugares.AddRange(context.DeporteLugar);

                //agregamos al set listaDeportes los deportes que haya utilizado el usuario en algun LugarDeRealizacion
                foreach (var deporteLugar in listaDeporteLugares)
                {
                    if (deporteLugar.LugarDeRealizacion.UsuarioId.Equals(idUsuario)) listaDeportes.Add(deporteLugar.Deporte);
                }

                //retornamos la lista de deportes
                return listaDeportes.ToList();
            }
            catch (Exception)
            {

                throw new Exception("Error al Buscar Deporte en la Base de Datos");
            }
            


        }

    }
}
