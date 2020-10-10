using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
   
    public class DtoDisponibilidad
    {
        public int DisponibilidadId { get; set; }
       
        public int Disponible { get; set; }
        
        public int LugarId { get; set; }
        public int CompetenciaId { get; set; }
        public  DtoCompetencia DtoCompetencia { get; set; }

    }
}
