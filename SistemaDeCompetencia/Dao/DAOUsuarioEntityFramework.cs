using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    class DAOUsuarioEntityFramework : DAOUsuario
    {
        public Usuario buscarPorId(int id)
        {
            try
            {
                //creamos el context
                CompetenciaContext context = new CompetenciaContext();
                //retornamos el usuario con esa Id
                return context.Usuario.Where(u => u.UsuarioId == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw new Exception("Error al buscar el usuario en la Base de Datos");
            }
            
        }
    }
}
