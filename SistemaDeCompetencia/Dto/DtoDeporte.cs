using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    
    public class DtoDeporte
    {
        public DtoDeporte(int deporteId, string nombre)
        {
            DeporteId = deporteId;
            Nombre = nombre;
        }

        public int DeporteId { get; set; }
        public string Nombre { get; set; }
        public List<DtoDeporteLugar> DeportesLugares { get; set; }

    }
}
