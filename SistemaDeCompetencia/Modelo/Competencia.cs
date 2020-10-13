using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table ("Competencia")]
   public class Competencia
    {
       [Key]
       public int CompetenciaId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(8000)]
        public string Reglamento { get; set; }
        public bool? DarDeBaja { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? HoraBaja { get; set; }
        public int? PuntosPorPartidosGanado { get; set; }
        public int? PuntosPorPartidoEmpatado { get; set; }
        public int? PuntosPorPresentarse { get; set; }
        public bool PermisoDeEmpate { get; set; }
        public Estado Estado { get; set; }
        public Modalidad Modalidad { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public  Usuario Usuario { get; set; }
        
        public List<Disponibilidad> Disponibilidades { get; set; }
        public List<Participante> Participantes { get; set; }

        [ForeignKey("FormaDePuntuacion")]
        public int FormaDePuntuacionId { get; set; }
        public FormaDePuntuacion FormaDePuntuacion { get; set; }
        public Fixture Fixture { get; set; }

        [ForeignKey("Deporte")]
        public int DeporteId { get; set; }
        public Deporte Deporte { get; set; }

        public Competencia()
        {
            Disponibilidades = new List<Disponibilidad>();
            DarDeBaja = false;
        }

    }
}
