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
        Competencia buscarPorId(int competenciaId);
        Competencia insertarCompetencia(Competencia c);
        List<Competencia> buscarCompetencias(string nombreCompetencia, string stringEstado, string stringModalidad, string nombreDeporte, int usuarioId);

        Competencia modificarCompetencia(Competencia compentencia);

        void eliminar(int fixtureId);
    }
}
