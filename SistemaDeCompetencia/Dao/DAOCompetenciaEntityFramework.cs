using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    class DAOCompetenciaEntityFramework : DAOCompetencia
    {
        public static CompetenciaContext context = new CompetenciaContext();
        public List<Competencia> buscarPorNombre(string nombreCompetencia)
        {
            //creamos el context
            //CompetenciaContext context = new CompetenciaContext();
            try
            {
                // buscamos las competencias con ese nombre
                List<Competencia> competencias = context.Competencia.Where(c => c.Nombre == nombreCompetencia).ToList();

                //retornamos las competencias que no fueron dadas de baja
                return competencias.FindAll(c => c.DarDeBaja == false);
            }
            catch (Exception)
            {

                throw new Exception("Error al buscar Competencia en la Base de datos.");
            }
        }
        public Competencia insertarCompetencia(Competencia c)
        {
            	

            context.Competencia.Add(c);
            context.SaveChanges();

           
          
            return c;
        }

        public List<Competencia> buscarCompetencias(string nombreCompetencia, string stringEstado, string stringModalidad, string nombreDeporte, int usuarioId)
        {
            List<Competencia> competencias = context.Competencia.Include("Deporte").Where(c => c.UsuarioId == usuarioId ).ToList();
            if (!nombreCompetencia.Equals("")) competencias =competencias.Where(c => c.Nombre.Contains(nombreCompetencia)).ToList();
            if (!stringEstado.Equals("")) competencias = competencias.Where(c => c.Estado.ToString().Equals(stringEstado)).ToList();
            if (!stringModalidad.Equals("")) competencias = competencias.Where(c => c.Modalidad.ToString().Equals(stringModalidad)).ToList();
            if (!nombreDeporte.Equals("")) competencias = competencias.Where(c => c.Deporte.Nombre.Equals(nombreDeporte)).ToList();
             

            
                return competencias;
        }

       public  Competencia buscarPorId(int competenciaId) 
        {
            try
            {

               return context.Competencia
              .Include(c => c.Fixture.Fechas.Select(f => f.Enfrentamientos.Select(e => e.Actual)))
              .Include(c => c.Fixture.Fechas.Select(f => f.Enfrentamientos.Select(x=>x.ParticipanteX)))
              .Include(c => c.Fixture.Fechas.Select(f => f.Enfrentamientos.Select(y=>y.ParticipanteY)))
              .Include(c => c.Deporte)
              .Include(c => c.Usuario)
              .Include(c => c.FormaDePuntuacion)
              .Include(c => c.Participantes)
              .Include(c => c.Disponibilidades)
              .Where(c => c.CompetenciaId.Equals(competenciaId)).FirstOrDefault();

                    
            }
            catch 
            {
                throw new Exception("Error al buscar Competencia en la Base de datos.");
            }
                        
        }
      public Competencia modificarCompetencia(Competencia c) 
        {
            context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return c;
           
        }
        public void eliminar(int fixtureId) 
        {
            var fixture = context.Fixture.Find(fixtureId);
            context.Entry(fixture).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
            
        }

    }
}         


