using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Participante")]
    public class Participante
    {   [Key]
        public int ParticipanteId { get; set; }
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }
        [ForeignKey("Competencia")]
        public int CompentenciaId { get; set; }
        public Competencia Competencia { get; set; }
       
        [InverseProperty("ParticipanteX")]
        public List<Enfrentamiento> EnfrentamientosX { get; set; }
        [InverseProperty("ParticipanteY")]
        public List<Enfrentamiento> EnfrentamientosY { get; set; }
        public List<Score> Scores { get; set; }
    }
}
