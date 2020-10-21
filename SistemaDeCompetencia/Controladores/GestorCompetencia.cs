using SistemaDeCompetencia.Dao;
using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Controladores
{
    class GestorCompetencia
    {
        DAODeporte daoDeporte = new DAODeporteEntityFramework();
        DAOCompetencia dAOCompetencia = new DAOCompetenciaEntityFramework();
        DAOUsuario daoUsuario = new DAOUsuarioEntityFramework();
        DAOLugarDeRealizacion daoLugar = new DAOLugarDeRealizacionEntityFramework();
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
                List<LugarDeRealizacion> listaLugares = daoLugar.listarLugar(deporteId, usuarioId);
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
        public Boolean darDeAltaCompetenciaDeporiva(DtoCompetencia dtoCompetencia)
        {
            //validamos los datos ingresados 
            try
            {
                this.validarDatos(dtoCompetencia);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            //seteamos los atributos simples
            Competencia c = new Competencia();
            c.PermisoDeEmpate = dtoCompetencia.PermisoDeEmpate;
            c.Nombre = dtoCompetencia.Nombre;
            c.Reglamento = dtoCompetencia.Reglamento;
            c.PuntosPorPartidosGanado = dtoCompetencia.PuntosPorPartidosGanado;
            c.PuntosPorPartidoEmpatado = dtoCompetencia.PuntosPorPartidoEmpatado;
            c.PuntosPorPresentarse = dtoCompetencia.PuntosPorPresentarse;
            /* ver como se hace con la modalidad*/
            c.Modalidad = dtoCompetencia.Modalidad;
             
            c.Estado = Modelo.Estado.Creada;

            //seteamos el usuario
            Usuario u = daoUsuario.buscarPorId(dtoCompetencia.DtoUsuario.DtoUsuarioId);
            c.Usuario = u;
            c.UsuarioId = u.UsuarioId;

            /* agregar deporte a competencia y a dtoCompetencia */
            Deporte d = daoDeporte.buscarPorId(dtoCompetencia.DtoDeporte.DeporteId);
            c.Deporte = d;
            c.DeporteId = d.DeporteId;
             

            //seteamos las disponibilidades
            foreach (var dtoDisponibilidad in dtoCompetencia.Disponibilidades)
            {
                LugarDeRealizacion l = daoLugar.buscarLugarPorId(dtoDisponibilidad.LugarId);
                Disponibilidad disp = new Disponibilidad();
                disp.LugarDeRealizacion = l;
                disp.LugarId = l.LugarId;
                disp.Disponible = dtoDisponibilidad.Disponible;

                c.Disponibilidades.Add(disp);

            }
            // inicializamos la forma de puntuacion dependiendo lo elegido
            FormaDePuntuacion f = new FormaDePuntuacion();
            switch (dtoCompetencia.DtoFormaDePuntuacion)
            {
                case DtoPuntuacion punt:
                    {
                        f = new Puntuacion();
                        ((Puntuacion)f).TantosOtorgados = punt.TantosOtorgados;
                    }
                    break;
                case DtoSet set:
                    {
                        f = new Set();
                        ((Set)f).Cantidad = set.Cantidad;
                    }
                    break;
                case DtoResultadoFinal resFin:
                    {
                        f = new ResultadoFinal();
                    }
                    break;
            }

            c.FormaDePuntuacion = f;

            dAOCompetencia.insertarCompetencia(c);

            return true;
        }
     public bool validarDatos(DtoCompetencia dtoCompetencia)
        {
            //Si el nombre de la competencia es nulo o vacio, no hay disponibilidades o tipo de modalidad o forma de puntuacion se lanza una excepcion
            if (string.IsNullOrWhiteSpace(dtoCompetencia.Nombre)
                || dtoCompetencia.Disponibilidades.Count < 1
                //|| dtoCompetencia.Modalidad == null
                || dtoCompetencia.DtoFormaDePuntuacion == null
                ) throw new Exception("Faltan completar datos.");

            //validamos el nombre de la competencia
            if (this.nombreEnUso(dtoCompetencia.Nombre)) throw new Exception("El Nombre de la competencia ya se encuentra en uso.");
            //Si la forma de puntuacion es Set y la cantidad de sets es par o mayor a 10 se lanza una excepcion
            if (dtoCompetencia.DtoFormaDePuntuacion.GetType().Equals(typeof(DtoSet)) && ((((DtoSet)dtoCompetencia.DtoFormaDePuntuacion).Cantidad % 2 == 0) || (((DtoSet)dtoCompetencia.DtoFormaDePuntuacion).Cantidad > 10))) throw new Exception("La cantidad de Sets no es un número impar o es un número mayor a 10");
            //Si la modalidad de la competencia es LIGA, se permite el empate y los puntos por partido ganado son menores que los puntos por partido empatado se lanza una excepcion
            if (dtoCompetencia.Modalidad.Equals(Modalidad.SISTEMA_DE_LIGA) && dtoCompetencia.PermisoDeEmpate.Equals(true) && (dtoCompetencia.PuntosPorPartidosGanado < dtoCompetencia.PuntosPorPartidoEmpatado)) throw new Exception("La cantidad de puntos por partido ganado es menor que la cantidad de puntos por partido empatado.");
            // Si la modalidad de la competencia es LIGA y los puntos por presentarse con mayor o igual a los puntos por partido ganado se lanza una excepcion. 
            if (dtoCompetencia.Modalidad.Equals(Modalidad.SISTEMA_DE_LIGA) && (dtoCompetencia.PuntosPorPresentarse >= dtoCompetencia.PuntosPorPartidosGanado)) throw new Exception("Los puntos por presentarse son mayor o igual a la cantidad de puntos por partido ganado.");
            return true;
        }
        public bool nombreEnUso(string nombre)
        {
            //retornamos true si ya esta en uso el nombre y false si el nombre esta disponible
            return (dAOCompetencia.buscarPorNombre(nombre).Count() != 0);

        }
       
    }
}
