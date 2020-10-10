using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("DatosResultado")]
    public class DtoDatosResultado
    {
        [Key]
        public int DatosResultadoId { get; set; }
        public bool GanadorX { get; set; }
        public bool GanadorY { get; set; }
        public bool Empate { get; set; }
        public bool ParticipanteXPresente { get; set; }
        public bool ParticipanteYPresente { get; set; }
        public Enfrentamiento Historico { get; set; }
        public Enfrentamiento Actual { get; set; }
        public List<Resultado> Resultados { get; set; }

        


    }
}
