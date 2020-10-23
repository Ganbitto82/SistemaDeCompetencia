using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    interface DAOCompetencia
    {
        List<Competencia> buscarPorNombre(String nombreCompetencia);
        bool insertarCompetencia(Competencia c);
        List<Competencia> buscarCompetencias(string nombreCompetencia, string stringEstado, string stringModalidad, string nombreDeporte);

    }
}
