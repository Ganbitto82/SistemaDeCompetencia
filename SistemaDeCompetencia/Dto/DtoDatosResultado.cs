using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
   
    public class DtoDatosResultado
    {
  
        public int DatosResultadoId { get; set; }
        public bool GanadorX { get; set; }
        public bool Ganador { get; set; }
        public bool Empate { get; set; }
        public bool ParticipanteXPresente { get; set; }
        public DtoEnfrentamiento Historico { get; set; }
        public DtoEnfrentamiento Actual { get; set; }
        public List<DtoResultado> Resultados { get; set; }

        


    }
}
