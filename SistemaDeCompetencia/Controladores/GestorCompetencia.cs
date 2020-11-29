using SistemaDeCompetencia.Dao;
using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCompetencia.Controladores
{
    class GestorCompetencia
    {
        DAODeporte daoDeporte = new DAODeporteEntityFramework();
        DAOCompetencia dAOCompetencia = new DAOCompetenciaEntityFramework();
        DAOUsuario daoUsuario = new DAOUsuarioEntityFramework();
        DAOLugarDeRealizacion daoLugar = new DAOLugarDeRealizacionEntityFramework();
        DAOParticipante daoParticipante = new DAOParticipanteEntityFramework();
        // private int[,,] fixtureEnteros;

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
            catch (Exception ex)
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
        public DtoCompetencia darDeAltaCompetenciaDeporiva(DtoCompetencia dtoCompetencia)
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

            c.Estado = Modelo.Estado.CREADA;

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

            c = dAOCompetencia.insertarCompetencia(c);
            dtoCompetencia.CompetenciaId = c.CompetenciaId;

            return dtoCompetencia;
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
        public List<DtoCompetencia> FiltrarCompetencias(string nombreCompetencia, string stringEstado, string stringModalidad, string nombreDeporte, DtoUsuario dtoUsuario)
        {
            List<DtoCompetencia> listaDtoCompetencia = new List<DtoCompetencia>();

            if (!validarCampos(nombreCompetencia, stringEstado, stringModalidad, nombreDeporte))
            {

                List<Competencia> listaCompetencia = dAOCompetencia.buscarCompetencias(nombreCompetencia, stringEstado, stringModalidad, nombreDeporte, dtoUsuario.DtoUsuarioId);

                foreach (var competencia in listaCompetencia)
                {
                    DtoCompetencia dtoCompetencia = new DtoCompetencia();
                    DtoDeporte dtoDeporte = new DtoDeporte();
                    dtoCompetencia.CompetenciaId = competencia.CompetenciaId;
                    dtoCompetencia.Nombre = competencia.Nombre;
                    dtoCompetencia.Estado = competencia.Estado;
                    dtoCompetencia.Modalidad = competencia.Modalidad;

                    dtoDeporte.DeporteId = competencia.DeporteId;
                    dtoDeporte.Nombre = competencia.Deporte.Nombre;
                    dtoCompetencia.DtoDeporte = dtoDeporte;

                    listaDtoCompetencia.Add(dtoCompetencia);

                }

            }
            else
            {
                MessageBox.Show("Debe ingresar al menos uno de los criterios de búsqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return listaDtoCompetencia;


        }
        public bool validarCampos(string nombreCompetencia, string stringEstado, string stringModalidad, string nombreDeporte)
        {
            if (nombreCompetencia.Equals("") && stringEstado.Equals("") && stringModalidad.Equals("") && nombreDeporte.Equals(""))

                return true;
            else
                return false;

        }

        public bool DarDeAltaParticipante(DtoParticipante dtoParticipante, int competenciaId)
        {
            if (!validarParticipante(dtoParticipante, competenciaId))
            {
                return false;
            }

            Competencia competencia = new Competencia();
            competencia = dAOCompetencia.buscarPorId(competenciaId);

            if (competencia.Estado.Equals(Estado.ENDISPUTA) || competencia.Estado.Equals(Estado.FINALIZADA))
            {
                MessageBox.Show("No se puede agregar participante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (var p in competencia.Participantes)
            {
                if (dtoParticipante.Nombre == p.Nombre || dtoParticipante.CorreoElectronico == p.CorreoElectronico)
                {
                    MessageBox.Show(" Ya existe ese nombre o correo en la competencia ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }


            }
            //eliminar();

            //competencia.Estado = Estado.CREADA;
            Participante participante = new Participante();

            participante.Nombre = dtoParticipante.Nombre;
            participante.CorreoElectronico = dtoParticipante.CorreoElectronico;

            competencia.Participantes.Add(participante);

            competencia = dAOCompetencia.modificarCompetencia(competencia);

            return true;
        }

        bool validarParticipante(DtoParticipante dtoParticipante, int competenciaId)
        {
            if (dtoParticipante == null && dtoParticipante.CorreoElectronico.Equals("") && dtoParticipante.Nombre.Equals(""))
            {
                MessageBox.Show("No se permiten datos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (daoParticipante.existeNombre(dtoParticipante.Nombre, competenciaId) || daoParticipante.existeCorreo(dtoParticipante.CorreoElectronico, competenciaId))
                {
                    MessageBox.Show(" Ya existe ese nombre o correo en la competencia ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        public List<DtoParticipante> listarParticipantesCompetencia(int competenciaId)
        {
            Competencia competencia = new Competencia();
            competencia = dAOCompetencia.buscarPorId(competenciaId);
            List<DtoParticipante> listaDtoParticipante = new List<DtoParticipante>();

            foreach (var participante in competencia.Participantes)
            {
                DtoParticipante dtoparticipante = new DtoParticipante();
                dtoparticipante.ParticipanteId = participante.ParticipanteId;
                dtoparticipante.Nombre = participante.Nombre;
                dtoparticipante.CorreoElectronico = participante.CorreoElectronico;
                listaDtoParticipante.Add(dtoparticipante);
            }

            return listaDtoParticipante;
        }

        private Competencia generarFixture(int competenciaId)
        {
            Competencia competencia = dAOCompetencia.buscarPorId(competenciaId);

            //int[,,] fixtureEnteros = new int[5,5,5];

            if (competencia.Estado.Equals(Estado.ENDISPUTA) || competencia.Estado.Equals(Estado.FINALIZADA))
            {
                MessageBox.Show("No se puede generar un fixture", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return competencia;
            }


            Fixture fixture = new Fixture();
            int[,,] fixtureEnteros = genererarEnfrentamientos(competencia.Participantes.Count());



            for (int i = 1; i <= fixtureEnteros.GetLength(0); i++)
            {
                Fecha fecha = new Fecha();
                fecha.FechaCompentencia = i.ToString();

                List<Disponibilidad> listaAuxDisp = new List<Disponibilidad>();
                foreach (var d in competencia.Disponibilidades)
                {
                    Disponibilidad disponibilidad = new Disponibilidad();
                    disponibilidad.DisponibilidadId = d.DisponibilidadId;
                    disponibilidad.Disponible = d.Disponible;

                    disponibilidad.LugarDeRealizacion = d.LugarDeRealizacion;
                    listaAuxDisp.Add(disponibilidad);
                }
                for (int j = 1; j <= fixtureEnteros.GetLength(1); j++)
                {
                    Enfrentamiento enfrentamiento = new Enfrentamiento();

                    enfrentamiento.ParticipanteX = competencia.Participantes.ElementAt(fixtureEnteros[i, j, 0]);
                    enfrentamiento.ParticipanteY = competencia.Participantes.ElementAt(fixtureEnteros[i, j, 1]);

                    if (listaAuxDisp.Count().Equals(0))
                    {
                        listaAuxDisp.Remove(listaAuxDisp.First());
                    }

                    enfrentamiento.LugarDeRealizacion = listaAuxDisp.First().LugarDeRealizacion;

                    listaAuxDisp.First().Disponible--;
                    fecha.Enfrentamientos.Add(enfrentamiento);
                }

                fixture.Fechas.Add(fecha);

            }

            competencia.Fixture = fixture;
            competencia.Estado = Estado.PLANIFICADA;
            competencia = dAOCompetencia.modificarCompetencia(competencia);



            return competencia;

        }

       
        public DtoCompetencia VerCompetencia(int compentenciaId)
        {
            Competencia competencia = new Competencia();
            DtoCompetencia dtocompetencia = new DtoCompetencia();
            competencia = dAOCompetencia.buscarPorId(compentenciaId);
            dtocompetencia.CompetenciaId = competencia.CompetenciaId;
            dtocompetencia.Nombre = competencia.Nombre;
            dtocompetencia.Modalidad = competencia.Modalidad;
            dtocompetencia.Estado = competencia.Estado;
            DtoDeporte dtoDeporte = new DtoDeporte();
            dtoDeporte.DeporteId = competencia.DeporteId;
            dtoDeporte.Nombre = competencia.Deporte.Nombre;

            dtocompetencia.DtoDeporte = dtoDeporte;


            if (dtocompetencia.Estado.Equals("PLANICFICADA") || dtocompetencia.Estado.Equals("ENDISPUTA"))
            {
                Fecha fecha = proximaFecha(competencia);

                DtoFecha dtoFecha = new DtoFecha();

                foreach (var enfrentamiento in fecha.Enfrentamientos)
                {
                    DtoParticipante dtoparticipanteX = new DtoParticipante();
                    DtoParticipante dtoparticipanteY = new DtoParticipante();

                    dtoparticipanteX.Nombre = enfrentamiento.ParticipanteX.Nombre;
                    dtoparticipanteY.Nombre = enfrentamiento.ParticipanteY.Nombre;

                    DtoEnfrentamiento dtoEnfrentamiento = new DtoEnfrentamiento();

                    dtoEnfrentamiento.ParticipanteX = dtoparticipanteX;
                    dtoEnfrentamiento.ParticipanteY = dtoparticipanteY;
                    dtoFecha.Enfrentamientos.Add(dtoEnfrentamiento);

                }
                DtoFixture dtofixture = new DtoFixture();
                dtofixture.Fechas.Add(dtoFecha);

                dtocompetencia.DtoFixture.Fechas = dtofixture.Fechas;
                dtocompetencia.DtoFixture.FixtureId = competencia.CompetenciaId;

                List<DtoParticipante> listadtoParticipantes = new List<DtoParticipante>();

                foreach (var participante in competencia.Participantes)
                {
                    DtoParticipante dtoParticipante = new DtoParticipante();
                    dtoParticipante.Nombre = participante.Nombre;
                    dtoParticipante.ParticipanteId = participante.ParticipanteId;
                    listadtoParticipantes.Add(dtoParticipante);
                }

                dtocompetencia.Participantes = listadtoParticipantes;

            }


            return dtocompetencia;
        }

        private Fecha proximaFecha(Competencia competencia)
        {
            throw new NotImplementedException();
        }

        private static int[,,] genererarEnfrentamientos(int cantidadPaticipantes)
        {            


            return calcularLiga(cantidadPaticipantes);

        }

        static private int[,,] calcularLiga(int numEquipos)
        {
            if (numEquipos % 2 == 0)
                return calcularLigaNumEquiposPar(numEquipos);
            else
                return calcularLigaNumEquiposImPar(numEquipos);
        }

        private static int[,,] calcularLigaNumEquiposImPar(int numEquipos)
        {
            int numRondas = numEquipos;
            int numPartidosPorRonda = numEquipos / 2;


            int[,,] rondas = new int[numRondas, numPartidosPorRonda, 2];

            for (int i = 0, k = 0; i < numRondas; i++)
            {
                for (int j = -1; j < numPartidosPorRonda; j++)
                {
                    if (j >= 0)
                    {

                        rondas[i, j, 0] = k;
                    }

                    k++;

                    if (k == numRondas)
                        k = 0;
                }
            }

            int equipoMasAlto = numEquipos - 1;

            for (int i = 0, k = equipoMasAlto; i < numRondas; i++)
            {
                for (int j = 0; j < numPartidosPorRonda; j++)
                {
                    rondas[i, j, 1] = k;

                    k--;

                    if (k == -1)
                        k = equipoMasAlto;
                }
            }

            return rondas;
        }

        private static int[,,] calcularLigaNumEquiposPar(int numEquipos)
        {
            int numRondas = numEquipos - 1;
            int numPartidosPorRonda = numEquipos / 2;

            int[,,] rondas = new int[numRondas, numPartidosPorRonda, 2];

            for (int i = 0, k = 0; i < numRondas; i++)
            {
                for (int j = 0; j < numPartidosPorRonda; j++)
                {


                    rondas[i, j, 0] = k;

                    k++;

                    if (k == numRondas)
                        k = 0;
                }
            }

            for (int i = 0; i < numRondas; i++)
            {
                if (i % 2 == 0)
                {
                    rondas[i, 0, 1] = numEquipos - 1;
                }
                else
                {
                    rondas[i, 0, 1] = rondas[i, 0, 0];
                    rondas[i, 0, 0] = numEquipos - 1;
                }
            }

            int equipoMasAlto = numEquipos - 1;
            int equipoImparMasAlto = equipoMasAlto - 1;

            for (int i = 0, k = equipoImparMasAlto; i < numRondas; i++)
            {
                for (int j = 1; j < numPartidosPorRonda; j++)
                {
                    rondas[i, j, 1] = k;

                    k--;

                    if (k == -1)
                        k = equipoImparMasAlto;
                }
            }

            return rondas;
        }
    }
     
}
