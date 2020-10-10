using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    
    public class DtoDeporteLugar
    {
      
        public int LugarId { get; set; }
        public int DeporteId { get; set; }
        public DtoLugarDeRealizacion DtoLugarDeRealizacion { get; set; }
        public DtoDeporte DtoDeporte { get; set; }

    }
}
