using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto

{ 
    public class DtoScore
    {  
        public int ScoreId { get; set;  }
        public int? Puntos { get; set; }
        public int? PartidosGanados { get; set; }
        public int? PatidosPerdidos { get; set; }
        public int? PartidosEmpatados { get; set; }
        public int? TantosAFavor { get; set; }
        public int? TantosEnContra { get; set; }
        public int? Diferencia { get; set; }
            
        public DtoParticipante DtoParticipante { get; set; }
        
    }
}
