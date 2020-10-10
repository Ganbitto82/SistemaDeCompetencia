using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{   
    public class DtoPuntuacion : DtoFormaDePuntuacion
    {
        
        public int PuntuacionId { get; set; }
        public int TantosOtorgados { get; set; }
    
    }
}
