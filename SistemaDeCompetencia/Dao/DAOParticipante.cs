using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    interface DAOParticipante
    {
          
        Boolean existeNombre(string nombre, int compentenciaId);
        Boolean existeCorreo(string correo, int compentenciaId);
    }
}
