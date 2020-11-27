using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    public class DtoEnfrentamiento
    {   [Key]
        public int EnfrentamientoId { get; set; }
        public DtoParticipante ParticipanteX { get; set; }
        public DtoParticipante ParticipanteY { get; set; }
        public DtoEnfrentamiento SucesorPerdedorId { get; set; }
        public DtoEnfrentamiento SucesorGanadorId { get; set; }
        public List<DtoEnfrentamiento> SucesorPerdedores { get; set; }
        public List<DtoEnfrentamiento> SucesorGanadores { get; set; }
        public List<DtoDatosResultado> Historicos { get; set; }

        public DtoFecha Fecha { get; set; }
        public DtoDatosResultado Actual { get; set; }



    }
}
