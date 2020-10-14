using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto

{
   
   public class DtoCompetencia
    {
       
       public int CompetenciaId { get; set; }
       public string Nombre { get; set; }
       public string Reglamento { get; set; }
       public bool? DarDeBaja { get; set; }
       public DateTime? FechaBaja { get; set; }
       public int? HoraBaja { get; set; }
       public int? PuntosPorPartidosGanado { get; set; }
       public int? PuntosPorPartidoEmpatado { get; set; }
       public int? PuntosPorPresentarse { get; set; }
       public bool PermisoDeEmpate { get; set; }
       public DtoEstado TipoEstado { get; set; }
       public DtoModalidad TipoModalidad { get; set; }
       
       public int UsuarioId { get; set; }
       public  DtoUsuario DtoUsuario { get; set; }
            
        
        public List<DtoDisponibilidad> Disponibilidades { get; set; }
        public List<DtoParticipante> Participantes { get; set; }

      
        public int FormaDePuntuacionId { get; set; }
        public DtoFormaDePuntuacion DtoFormaDePuntuacion { get; set; }
        public int FixtureId { get; set; }
      

    }
}
