using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Modelo
{
    public class CompetenciaContext : DbContext
    {
        public CompetenciaContext() : base("name=CompetenciaContext") { }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Auditoria> Auditoria { get; set; }
        public DbSet<LugarDeRealizacion> LugarDeRealizacion { get; set; }
        public DbSet<Disponibilidad> Disponibilidad { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<Deporte> Deporte { get; set; }
        public DbSet<DeporteLugar> DeporteLugar { get; set; }
        public DbSet<Participante> Participante { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<FormaDePuntuacion> FormaDePuntuacion { get; set; }
        public DbSet<Puntuacion> Puntuacion { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<ResultadoFinal> ResultadoFinal { get; set; }
        public DbSet<Fixture> Fixture { get; set; }
        public DbSet<Fecha> Fechas { get; set; }
        public DbSet<Enfrentamiento> Enfrentamientos { get; set; }
        public DbSet<DatosResultado> DatosResultados { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Participante>().HasRequired(t => t.ParticipanteId).WillCascadeOnDelete(false);



        }

    }

    
}