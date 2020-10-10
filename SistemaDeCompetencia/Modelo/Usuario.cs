using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        
        [Required]
        [StringLength(50)]
         public string Nombre { get; set; }
        
        [Required]
        [StringLength(50)]
         public string Apellido { get; set; }
        [Required]
        public long NumeroDocumento { get; set; }
        
        [ForeignKey("TipoDocumento")]
        public int TipoDocumentoId { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        [ForeignKey("Direccion")]
        public int DireccionId { get; set; }
        public  Direccion Direccion { get; set; }
        public List<LugarDeRealizacion> Lugares { get; set; }
        public List<Competencia> Competencias { get; set; }

    }
}
