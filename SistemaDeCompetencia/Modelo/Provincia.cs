using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Provincia")]
    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }
        [Required]
        [StringLength(50)]
        public String nombreProvincia { get; set; }
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public  Pais Pais { get; set; }

        public List<Localidad> Localidades { get; set; }
        
       

    }
}
