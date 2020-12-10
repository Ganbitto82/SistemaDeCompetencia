namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaDeCompetencia.Modelo.CompetenciaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SistemaDeCompetencia.Modelo.CompetenciaContext context)
        {

            /* context.Pais.AddOrUpdate(
               new Modelo.Pais() {  nombrePais = "ARGENTINA" }
              );
             context.Provincia.AddOrUpdate(
              new Modelo.Provincia() {PaisId=  1,ProvinciaId = 1 , nombreProvincia = "SANTA FE" },
              new Modelo.Provincia() {PaisId = 1,ProvinciaId = 2, nombreProvincia = "BUENOS AIRES" },
              new Modelo.Provincia() {PaisId = 1,ProvinciaId = 3, nombreProvincia = "CORDOBA" }
             ); 
             context.Localidad.AddOrUpdate(
               new Modelo.Localidad() { ProvinciaId = 1 , nombreLocalidad="ROSARIO" },
               new Modelo.Localidad() { ProvinciaId = 1, nombreLocalidad = "SANTA FE" }
                 );
             context.Direccion.AddOrUpdate(
                 new Modelo.Direccion() { LocalidadId = 1 ,calle = "PJE CONTRERAS", numero = 8530 }
                   ); 
             context.TipoDocumento.AddOrUpdate(
                 new Modelo.TipoDocumento() {NombreTipo="DNI" }
                 ); 
             context.Usuario.AddOrUpdate(
                 new Modelo.Usuario() { Nombre = "JUAN", Apellido = "PEREZ", NumeroDocumento = 3333333, TipoDocumentoId = 1, DireccionId = 3 }
                  ); 
             context.Login.AddOrUpdate(
                 new Modelo.Login() { UsuarioId = 4, correoElectronico ="A@GMAIL.COM",Contraseña="123" }

                 );
         }*/
        }
    }
}