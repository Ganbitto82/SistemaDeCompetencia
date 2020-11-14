using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{   [Table("Resultado")]
    public class Resultado
    {
      [Key]
      public int ResultadoId { get; set; }
      public int ParticipanteX { get; set; }
      public int ParticipanteY { get; set; }
      [ForeignKey("DatosResultado")]
      public int? DatosResultadoId { get; set; }
      public DatosResultado DatosResultado { get; set; }

    }
}
