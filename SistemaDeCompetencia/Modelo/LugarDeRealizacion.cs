using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table ("LugarDeRealizacion")]
    public class LugarDeRealizacion
    {
        [Key]
        public int LugarId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Disponibilidad> Disponibilidades  { get; set; }
        public List<DeporteLugar> DeportesLugares { get; set; }

    }
}
