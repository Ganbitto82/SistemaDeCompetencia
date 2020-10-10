using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
     public class DtoLogin
    {
        
        public int LoginId { get; set; }
        public string correoElectronico { get; set; }
        public string Contraseña { get; set; }
        public int UsuarioId { get; set; }
        public DtoUsuario DtoUsuario { get; set; }
        public List<DtoAuditoria> Auditorias { get; set; }

    }
}
