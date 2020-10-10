using SistemaDeCompetencia.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    
   public class DtoAuditoria
    {
       
        public int AuditoriaId { get; set; }
        public DateTime fecha { get; set; }
        public int DtoLoginId { get; set; }
        public  DtoLogin DtoLogin { get; set; }
    }
}
