using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        [StringLength(50)]
        [Required]
        public string correoElectronico { get; set; }
        [Required]
        [StringLength(30)]
        public string Contraseña { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Auditoria> Auditorias { get; set; }

    }
}
