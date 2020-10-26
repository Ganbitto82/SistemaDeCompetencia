using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        public bool insertarCompetencia(Competencia c)
        {
            //creamos el context	
            //CompetenciaContext context = new CompetenciaContext();	
            /*	
             context.FormaDePuntuacion.Add(c.FormaDePuntuacion);	
             context.SaveChanges();	
             c.FormaDePuntuacionId = c.FormaDePuntuacion.FormaDePuntuacionId;	
            */

            //context = new CompetenciaContext();	

            context.Competencia.Add(c);
            context.SaveChanges();

            /* context = new CompetenciaContext();	
             foreach (Disponibilidad d in c.Disponibilidades)	
             {	
                 d.CompetenciaId = c.CompetenciaId;	
                 context.Disponibilidad.Add(d);	
             }	
            */
            return true;
        }

        public List<Competencia> buscarCompetencias(string nombreCompetencia, string stringEstado, string stringModalidad, string nombreDeporte)
        {
            List<Competencia> competencias = context.Competencia.Where(c => c.Nombre.Contains(nombreCompetencia)).ToList();
             if (!stringEstado.Equals("")) competencias = competencias.Where(c => c.Estado.ToString().Equals(stringEstado)).ToList();
             if (!stringModalidad.Equals("")) competencias = competencias.Where(c => c.Modalidad.ToString().Equals(stringModalidad)).ToList();
            if (!nombreDeporte.Equals(""))
            {
                Deporte deporte = context.Deporte.Where(d => d.Nombre.Equals(nombreDeporte)).FirstOrDefault();
                competencias = competencias.Where(c => c.DeporteId.Equals(deporte.DeporteId)).ToList();
            }
            /* Console.WriteLine(competencias.ElementAt(0).Estado.ToString());
         Console.WriteLine(competencias.ElementAt(0).Modalidad.ToString());
         Console.ReadLine();
         foreach(var c in competencias){
            Console.WriteLine(c.Nombre + c.Estado + c.Modalidad + c.DeporteId);
            Console.ReadLine();
        }*/
            return competencias;
        }

        public List<Competencia> todas()
        {
            return context.Competencia.Include(c => c.Deporte).Include(c => c.Disponibilidades).ToList();
        }


    }
}         


