using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    public class DtoFixture
    {
      
        public int FixtureId { get; set; }
        public List<DtoFecha> Fechas { get; set; }

    }
}
