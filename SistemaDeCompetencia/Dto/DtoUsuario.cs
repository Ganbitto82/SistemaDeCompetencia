using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dto
{
    public class DtoUsuario
    {

        public DtoUsuario()
        {
        }
        public DtoUsuario(int idDtoUsusario)
        {
            this.DtoUsuarioId = idDtoUsusario;
        }

        public int DtoUsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long NumeroDocumento { get; set; }
        public int DtoTipoDocumentoId { get; set; }
        public DtoTipoDocumento DtoTipoDocumento { get; set; }
        public int DtoDireccionId { get; set; }
        public DtoDireccion DtoDireccion { get; set; }
        public List<DtoLugarDeRealizacion> DtoLugares { get; set; }
        public List<DtoCompetencia> DtoCompetencias { get; set; }
    }
}
