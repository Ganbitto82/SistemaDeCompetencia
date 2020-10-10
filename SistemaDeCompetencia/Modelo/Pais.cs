using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
         public int PaisId { get; set; }
        [StringLength(50)]
        [Required]
        public string nombrePais { get; set; }
        public List<Provincia> Provincias { get; set; }

    }
}
