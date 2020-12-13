using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{  [Table("FormaDePuntuacion")]
    public abstract class FormaDePuntuacion
    {   [Key]
        public  int FormaDePuntuacionId { get; set; }
        
    }
}
