using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Auditoria")]
   public class Auditoria
    {
        [Key]
        public int AuditoriaId { get; set; }
        public DateTime fecha { get; set; }
        [ForeignKey("Login")]
        public int LoginId { get; set; }
        public  Login Login { get; set; }
    }
}
