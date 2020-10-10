using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("TipoDocumento")]
    public class TipoDocumento
    {
        [Key]
        public int TipoDocumentoId { get; set; }
        [Required]
        public string NombreTipo { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
