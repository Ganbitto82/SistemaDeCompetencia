using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    class DAOParticipanteEntityFramework : DAOParticipante
    {
        public static CompetenciaContext context = new CompetenciaContext();
       public Boolean existeNombre(string nombre, int compentenciaId) 
        {
            try
            {
                return context.Participante.Where(p => p.CompentenciaId == compentenciaId).Where(p => p.Nombre.Equals(nombre)).Count() > 0;
            }
            catch (Exception)
            {

                throw new Exception("Error al Buscar Nombre de Participante en la Base de Datos");
            }
         
        }
        public Boolean existeCorreo(string correo, int compentenciaId) 
        {
            try
            {
                return context.Participante.Where(p => p.CompentenciaId == compentenciaId).Where(p => p.CorreoElectronico.Equals(correo)).Count() > 0;
            }
            catch (Exception)
            {

                throw new Exception("Error al Buscar Correo Electronico de Participante en la Base de Datos");
            }
           
        }

    }
}
