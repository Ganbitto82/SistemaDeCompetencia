using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    public class DtoTipoDocumento
    {
       
        public int TipoDocumentoId { get; set; }
        
        public string NombreTipo { get; set; }

        public List<DtoUsuario> Usuarios { get; set; }
    }
}

