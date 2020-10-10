using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    public class DtoDireccion
    {
        
        public int DtoDireccionId { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public int? departamento { get; set; }
        public int DtoLocalidadId { get; set; }
        public DtoLocalidad DtoLocalidad { get; set; }
        public List<DtoUsuario> Usuarios { get; set; }
    }
}
