using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{[Table("Enfrentamiento")]
    public class Enfrentamiento
    {[Key]
        public int EnfrentamientoId { get; set; }
        [ForeignKey("ParticipanteX")]
        public int ParticipanteXId { get; set; }
        public Participante ParticipanteX { get; set; }
        [ForeignKey("ParticipanteY")]
        public int ParticipanteYId { get; set; }
        public Participante ParticipanteY { get; set; }
        public Enfrentamiento SucesorPerdedor { get; set; }
        public Enfrentamiento SucesorGanador { get; set; }
        [InverseProperty("SucesorPerdedor")]
        public List<Enfrentamiento> SucesorPerdedores { get; set; }
        [InverseProperty("Sucesorganador")]
        public List<Enfrentamiento> SucesorGanadores { get; set; }
        [InverseProperty("Historico")]
        public List<DatosResultado> Historicos { get; set; }
        [ForeignKey("Fecha")]
        public int FechaId { get; set; }
        public Fecha Fecha { get; set; }
        public DatosResultado Actual { get; set; }

        public LugarDeRealizacion LugarDeRealizacion { get; set; }


    }
}
