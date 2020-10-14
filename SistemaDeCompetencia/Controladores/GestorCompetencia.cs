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
    class GestorCompetencia
    {
        DAODeporte daoDeporte = new DAODeporteEntityFramework();
        DAOLugar daoLugar = new DAOLugarEntityFramework();

        public List<DtoDeporte> listarDeportes()
        { 
        
            //inicializamos listaDTODeportes
            List<DtoDeporte> listaDtoDeportes = new List<DtoDeporte>();
            //capturamos la excepcion por si hay problemas al obtener los deportes
            try
            {
                //obtenemos la lista de deportes del usuario
                List<Deporte> listaDeportes = daoDeporte.listarDeportes();
                //iteramos por los deportes y los pasamos a dto, luego los agregamos a la listaDtoDeportes
                foreach (var deporte in listaDeportes)
                {
                    listaDtoDeportes.Add(new DtoDeporte(deporte.DeporteId, deporte.Nombre));
                }

                //retornamos listaDtoDeportes
                return listaDtoDeportes;
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
        public List<DtoLugarDeRealizacion> listarLugares(int deporteId, int usuarioId) 
        {
            List<DtoLugarDeRealizacion> listaDtoLugares = new List<DtoLugarDeRealizacion>();
             
            try
            {
                List<LugarDeRealizacion> listaLugares = daoLugar.listarLugar(deporteId , usuarioId);
                foreach (var lugar in listaLugares) 
                {
                    DtoLugarDeRealizacion DtoLugar = new DtoLugarDeRealizacion();
                    
                    DtoLugar.LugarId = lugar.LugarId;
                    DtoLugar.Nombre = lugar.Nombre;
                    DtoLugar.UsuarioId = lugar.UsuarioId;
                    
                    listaDtoLugares.Add(DtoLugar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaDtoLugares;
        }
        
    }
}
