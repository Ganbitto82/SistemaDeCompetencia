using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
   public class DtoProvincia
    {
       
        public int ProvinciaId { get; set; }
        
        public String nombreProvincia { get; set; }
        public int PaisId { get; set; }
        public DtoPais DtoPais { get; set; }
        public List<DtoLocalidad> Localidades { get; set; }
    }
}
