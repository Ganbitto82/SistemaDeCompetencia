using SistemaDeCompetencia.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{  [Table ("Fecha")]
    public class Fecha
    {
        [Key]
        public int FechaId { get; set; }
        public string FechaCompentencia { get; set; } 
        [ForeignKey("Fixture")]
        public int? FixtureId { get; set; }
        public Fixture Fixture { get; set; }
        public List<Enfrentamiento> Enfrentamientos { get; set; }
    }
}
