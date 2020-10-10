using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{ 
    public class DtoFecha
    {
        [Key]
        public int FechaId { get; set; }
        public string FechaCompentencia { get; set; } 
        public int? FixtureId { get; set; }
        public DtoFixture DtoFixture { get; set; }

    }
}
