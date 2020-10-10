using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{   
    public class DtoResultado
    {
      
      public int ResultadoId { get; set; }
      public int ParticipanteX { get; set; }
      public int ParticipanteY { get; set; }
      public int? DatosResultadoId { get; set; }
      public DtoDatosResultado DatosResultado { get; set; }

    }
}
