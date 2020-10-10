using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    
    public class DtoLugarDeRealizacion
    {
        
        public int LugarId { get; set; }
             
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public int UsuarioId { get; set; }
        public DtoUsuario DtoUsuario { get; set; }
        public List<DtoDisponibilidad> Disponibilidades  { get; set; }
        public List<DtoDeporteLugar> DeportesLugares { get; set; }

    }
}
