using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
   public class DtoLocalidad
    {
        
        public int LocalidadId { get; set; }
        
        public string nombreLocalidad { get; set; }
       
        public int ProvinciaId { get; set; }
        public DtoProvincia Provincia { get; set; }

        public List<DtoDireccion> Direcciones { get; set; }

    }
}
