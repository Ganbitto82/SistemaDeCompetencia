using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Direccion")]
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        [Required]
        [StringLength(50)]
        public string calle { get; set; }
        [Required]
        public int numero { get; set; }

        public int? departamento { get; set; }
        [ForeignKey("Localidad")]
        public int LocalidadId { get; set; }
        public  Localidad Localidad { get; set; }
        public List<Usuario> Usuarios {get;set;} 
    }
}
