using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Localidad")]
    public class Localidad
    {   [Key]
        public int LocalidadId { get; set; }
        [Required]
        [StringLength(50)]
        public string nombreLocalidad { get; set; }
        [ForeignKey("Provincia")]
        public int ProvinciaId { get; set; }
        public  Provincia Provincia { get; set; }
        
        public List<Direccion> Direcciones { get; set; }

    
    }
}
