using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Deporte")]
    public class Deporte
    {
        [Key]
        public int DeporteId { get; set; }
       
        [StringLength(50)]
        [Index(IsUnique =true)]
         public string Nombre { get; set; }
        public List<DeporteLugar> DeportesLugares { get; set; }
        public List<Competencia> Competencias { get; set; }

    }
}
