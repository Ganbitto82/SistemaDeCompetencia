using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    public class DtoResultadoFinal : DtoFormaDePuntuacion
    {
        
        public int ResultadoFinalId { get; set; }
        public int Resultado { get; set; }
    }
}
