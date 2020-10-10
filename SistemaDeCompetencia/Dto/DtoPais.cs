using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    public class DtoPais
    {

        public class Pais
        {

            public int PaisId { get; set; }

            public string NombrePais { get; set; }
            public List<DtoProvincia> Provincias { get; set; }

        }
    }
}
