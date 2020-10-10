using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCompetencia.Dto;

namespace SistemaDeCompetencia.Dto

{
      public class DtoParticipante
    {  
        public int ParticipanteId { get; set; }
        
        public string Nombre { get; set; }
       
        public string CorreoElectronico { get; set; }
       
        public int CompentenciaId { get; set; }
        public DtoCompetencia DtoCompetencia { get; set; }
        public int ScoreId { get; set; }
        public int FixtureId { get; set; }
       public List<DtoEnfrentamiento> EnfrentamientosX { get; set; }
       public List<DtoEnfrentamiento> EnfrentamientosY { get; set; }

    }
}
