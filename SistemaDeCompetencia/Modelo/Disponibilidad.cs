using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Disponibilidad")]
    public class Disponibilidad
    {
        
        [Key]
        public int DisponibilidadId { get; set; }
        [Required]
        public int Disponible { get; set; }
        [ForeignKey("LugarDeRealizacion")]
        public int LugarId { get; set; }
        public  LugarDeRealizacion LugarDeRealizacion { get; set; }
        [ForeignKey("Competencia")]
        public int? CompetenciaId { get; set; }
        public  Competencia Competencia { get; set; }

    }
}
