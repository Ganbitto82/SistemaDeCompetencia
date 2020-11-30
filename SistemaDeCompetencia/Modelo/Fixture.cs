using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{[Table ("Fixture")]
    public class Fixture
    {
        [Key]
        public int FixtureId { get; set; }
      
        public List<Fecha> Fechas { get; set; }

        public Fixture()
        {
            Fechas = new List<Fecha>();
        }
    }
}
