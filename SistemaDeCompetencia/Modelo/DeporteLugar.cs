using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("DeporteLugar")]
    public class DeporteLugar
    {
        [Key , ForeignKey("LugarDeRealizacion"), Column(Order = 0)]
        public int LugarId { get; set; }
        [Key , ForeignKey("Deporte"), Column(Order = 1)]
        public int DeporteId { get; set; }
        [ForeignKey("LugarDeRealizacion")]
        public LugarDeRealizacion LugarDeRealizacion { get; set; }
        [ForeignKey("Deporte")]
        public Deporte Deporte { get; set; }

    }
}
