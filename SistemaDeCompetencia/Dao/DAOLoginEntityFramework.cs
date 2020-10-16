using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCompetencia.Dao
{
    class DAOLoginEntityFramework : DAOLogin
    {
        public List<Login> buscarPorCorreo(string user)
        {
            try
            {
                //creamos el context
                var context = new CompetenciaContext();
                //buscamos los login que coinciden con el correoElectronico
                List<Login> log = context.Login.Where(l => l.correoElectronico == user).ToList();
                //retornamos la lista de logins
                return log;
            }
            catch (Exception)
            {
                throw new Exception("Error al buscar el Correo en la Base de Datos");
            }

            
        }
    }
}
