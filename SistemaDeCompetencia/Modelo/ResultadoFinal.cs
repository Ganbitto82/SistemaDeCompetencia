using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{[Table("ResultadoFinal")]
    public class ResultadoFinal : FormaDePuntuacion
    {
        public int Resultado { get; set; }
    }
}
