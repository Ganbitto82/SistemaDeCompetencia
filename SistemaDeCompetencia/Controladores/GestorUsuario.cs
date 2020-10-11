using SistemaDeCompetencia.Dao;
using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Controladores
{
   public  class GestorUsuario
    {
        DAOLogin daoLogin = new DAOLoginEntityFramework();
        DAOUsuario daoUsuario = new DAOUsuarioEntityFramework();

        public DtoUsuario autenticarUsusario(DtoLogin loginDTO)
        {
            DtoUsuario userDTO = new DtoUsuario();


            List<Login> log = daoLogin.buscarPorCorreo(loginDTO.correoElectronico);
            if (log.Count > 0 && log.First().Contraseña.Equals(loginDTO.Contraseña))
            {
                userDTO.DtoUsuarioId = log.First().UsuarioId;
            }
            else
            {
                throw new Exception("El Usuario o Contraseña no son válidos.");
            }

            return userDTO;
        }
    }
}
