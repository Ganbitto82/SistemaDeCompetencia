namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auditoria",
                c => new
                    {
                        AuditoriaId = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        LoginId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuditoriaId)
                .ForeignKey("dbo.Login", t => t.LoginId, cascadeDelete: true)
                .Index(t => t.LoginId);
            
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        LoginId = c.Int(nullable: false, identity: true),
                        correoElectronico = c.String(nullable: false, maxLength: 50),
                        Contraseña = c.String(nullable: false, maxLength: 30),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LoginId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        NumeroDocumento = c.Long(nullable: false),
                        TipoDocumentoId = c.Int(nullable: false),
                        DireccionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Direccion", t => t.DireccionId, cascadeDelete: true)
                .ForeignKey("dbo.TipoDocumento", t => t.TipoDocumentoId, cascadeDelete: true)
                .Index(t => t.TipoDocumentoId)
                .Index(t => t.DireccionId);
            
            CreateTable(
                "dbo.Competencia",
                c => new
                    {
                        CompetenciaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Reglamento = c.String(),
                        DarDeBaja = c.Boolean(),
                        FechaBaja = c.DateTime(),
                        HoraBaja = c.Int(),
                        PuntosPorPartidosGanado = c.Int(),
                        PuntosPorPartidoEmpatado = c.Int(),
                        PuntosPorPresentarse = c.Int(),
                        PermisoDeEmpate = c.Boolean(nullable: false),
                        TipoEstado = c.Int(nullable: false),
                        TipoModalidad = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FormaDePuntuacionId = c.Int(nullable: false),
                        FixtureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompetenciaId)
                .ForeignKey("dbo.FormaDePuntuacion", t => t.FormaDePuntuacionId, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.FormaDePuntuacionId);
            
            CreateTable(
                "dbo.Disponibilidad",
                c => new
                    {
                        DisponibilidadId = c.Int(nullable: false, identity: true),
                        Disponible = c.Int(nullable: false),
                        LugarId = c.Int(nullable: false),
                        CompetenciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DisponibilidadId)
                .ForeignKey("dbo.Competencia", t => t.CompetenciaId, cascadeDelete: true)
                .ForeignKey("dbo.LugarDeRealizacion", t => t.LugarId, cascadeDelete: true)
                .Index(t => t.LugarId)
                .Index(t => t.CompetenciaId);
            
            CreateTable(
                "dbo.LugarDeRealizacion",
                c => new
                    {
                        LugarId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LugarId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: false)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.DeporteLugar",
                c => new
                    {
                        LugarId = c.Int(nullable: false),
                        DeporteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LugarId, t.DeporteId })
                .ForeignKey("dbo.Deporte", t => t.DeporteId, cascadeDelete: true)
                .ForeignKey("dbo.LugarDeRealizacion", t => t.LugarId, cascadeDelete: true)
                .Index(t => t.LugarId)
                .Index(t => t.DeporteId);
            
            CreateTable(
                "dbo.Deporte",
                c => new
                    {
                        DeporteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DeporteId)
                .Index(t => t.Nombre, unique: true);
            
            CreateTable(
                "dbo.FormaDePuntuacion",
                c => new
                    {
                        FormaDePuntuacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.FormaDePuntuacionId);
            
            CreateTable(
                "dbo.Participante",
                c => new
                    {
                        ParticipanteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        CorreoElectronico = c.String(nullable: false, maxLength: 50),
                        CompentenciaId = c.Int(nullable: false),
                        ScoreId = c.Int(nullable: false),
                        FixtureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParticipanteId)
                .ForeignKey("dbo.Competencia", t => t.CompentenciaId, cascadeDelete: true)
                .Index(t => t.CompentenciaId);
            
            CreateTable(
                "dbo.Enfrentamiento",
                c => new
                    {
                        EnfrentamientoId = c.Int(nullable: false, identity: true),
                        SucesorGanador_EnfrentamientoId = c.Int(),
                        SucesorPerdedor_EnfrentamientoId = c.Int(),
                        ParticipanteX_ParticipanteId = c.Int(),
                        ParticipanteY_ParticipanteId = c.Int(),
                    })
                .PrimaryKey(t => t.EnfrentamientoId)
                .ForeignKey("dbo.Enfrentamiento", t => t.SucesorGanador_EnfrentamientoId)
                .ForeignKey("dbo.Enfrentamiento", t => t.SucesorPerdedor_EnfrentamientoId)
                .ForeignKey("dbo.Participante", t => t.ParticipanteX_ParticipanteId)
                .ForeignKey("dbo.Participante", t => t.ParticipanteY_ParticipanteId)
                .Index(t => t.SucesorGanador_EnfrentamientoId)
                .Index(t => t.SucesorPerdedor_EnfrentamientoId)
                .Index(t => t.ParticipanteX_ParticipanteId)
                .Index(t => t.ParticipanteY_ParticipanteId);
            
            CreateTable(
                "dbo.DatosResultado",
                c => new
                    {
                        DatosResultadoId = c.Int(nullable: false, identity: true),
                        GanadorX = c.Boolean(nullable: false),
                        Ganador = c.Boolean(nullable: false),
                        Empate = c.Boolean(nullable: false),
                        ParticipanteXPresente = c.Boolean(nullable: false),
                        Actual_EnfrentamientoId = c.Int(),
                        Historico_EnfrentamientoId = c.Int(),
                    })
                .PrimaryKey(t => t.DatosResultadoId)
                .ForeignKey("dbo.Enfrentamiento", t => t.Actual_EnfrentamientoId)
                .ForeignKey("dbo.Enfrentamiento", t => t.Historico_EnfrentamientoId)
                .Index(t => t.Actual_EnfrentamientoId)
                .Index(t => t.Historico_EnfrentamientoId);
            
            CreateTable(
                "dbo.Resultado",
                c => new
                    {
                        ResultadoId = c.Int(nullable: false, identity: true),
                        ParticipanteX = c.Int(nullable: false),
                        ParticipanteY = c.Int(nullable: false),
                        DatosResultadoId = c.Int(),
                    })
                .PrimaryKey(t => t.ResultadoId)
                .ForeignKey("dbo.DatosResultado", t => t.DatosResultadoId)
                .Index(t => t.DatosResultadoId);
            
            CreateTable(
                "dbo.Direccion",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        calle = c.String(nullable: false, maxLength: 50),
                        numero = c.Int(nullable: false),
                        departamento = c.Int(),
                        LocalidadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("dbo.Localidad", t => t.LocalidadId, cascadeDelete: true)
                .Index(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        LocalidadId = c.Int(nullable: false, identity: true),
                        nombreLocalidad = c.String(nullable: false, maxLength: 50),
                        ProvinciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocalidadId)
                .ForeignKey("dbo.Provincia", t => t.ProvinciaId, cascadeDelete: true)
                .Index(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Provincia",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                        nombreProvincia = c.String(nullable: false, maxLength: 50),
                        PaisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinciaId)
                .ForeignKey("dbo.Pais", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        PaisId = c.Int(nullable: false, identity: true),
                        nombrePais = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PaisId);
            
            CreateTable(
                "dbo.TipoDocumento",
                c => new
                    {
                        TipoDocumentoId = c.Int(nullable: false, identity: true),
                        NombreTipo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TipoDocumentoId);
            
            CreateTable(
                "dbo.Fecha",
                c => new
                    {
                        FechaId = c.Int(nullable: false, identity: true),
                        FechaCompentencia = c.String(),
                        FixtureId = c.Int(),
                    })
                .PrimaryKey(t => t.FechaId)
                .ForeignKey("dbo.Fixture", t => t.FixtureId)
                .Index(t => t.FixtureId);
            
            CreateTable(
                "dbo.Fixture",
                c => new
                    {
                        FixtureId = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false),
                        Competencia_CompetenciaId = c.Int(),
                    })
                .PrimaryKey(t => t.FixtureId)
                .ForeignKey("dbo.Competencia", t => t.Competencia_CompetenciaId)
                .Index(t => t.Competencia_CompetenciaId);
            
            CreateTable(
                "dbo.Score",
                c => new
                    {
                        ScoreId = c.Int(nullable: false, identity: true),
                        Puntos = c.Int(),
                        PartidosGanados = c.Int(),
                        PatidosPerdidos = c.Int(),
                        PartidosEmpatados = c.Int(),
                        TantosAFavor = c.Int(),
                        TantosEnContra = c.Int(),
                        Diferencia = c.Int(),
                        Participante_ParticipanteId = c.Int(),
                    })
                .PrimaryKey(t => t.ScoreId)
                .ForeignKey("dbo.Participante", t => t.Participante_ParticipanteId)
                .Index(t => t.Participante_ParticipanteId);
            
            CreateTable(
                "dbo.Puntuacion",
                c => new
                    {
                        FormaDePuntuacionId = c.Int(nullable: false),
                        PuntuacionId = c.Int(nullable: false),
                        TantosOtorgados = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FormaDePuntuacionId)
                .ForeignKey("dbo.FormaDePuntuacion", t => t.FormaDePuntuacionId)
                .Index(t => t.FormaDePuntuacionId);
            
            CreateTable(
                "dbo.ResultadoFinal",
                c => new
                    {
                        FormaDePuntuacionId = c.Int(nullable: false),
                        ResultadoFinalId = c.Int(nullable: false),
                        Resultado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FormaDePuntuacionId)
                .ForeignKey("dbo.FormaDePuntuacion", t => t.FormaDePuntuacionId)
                .Index(t => t.FormaDePuntuacionId);
            
            CreateTable(
                "dbo.Set",
                c => new
                    {
                        FormaDePuntuacionId = c.Int(nullable: false),
                        SetId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FormaDePuntuacionId)
                .ForeignKey("dbo.FormaDePuntuacion", t => t.FormaDePuntuacionId)
                .Index(t => t.FormaDePuntuacionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Set", "FormaDePuntuacionId", "dbo.FormaDePuntuacion");
            DropForeignKey("dbo.ResultadoFinal", "FormaDePuntuacionId", "dbo.FormaDePuntuacion");
            DropForeignKey("dbo.Puntuacion", "FormaDePuntuacionId", "dbo.FormaDePuntuacion");
            DropForeignKey("dbo.Score", "Participante_ParticipanteId", "dbo.Participante");
            DropForeignKey("dbo.Fecha", "FixtureId", "dbo.Fixture");
            DropForeignKey("dbo.Fixture", "Competencia_CompetenciaId", "dbo.Competencia");
            DropForeignKey("dbo.Auditoria", "LoginId", "dbo.Login");
            DropForeignKey("dbo.Login", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "TipoDocumentoId", "dbo.TipoDocumento");
            DropForeignKey("dbo.Usuario", "DireccionId", "dbo.Direccion");
            DropForeignKey("dbo.Direccion", "LocalidadId", "dbo.Localidad");
            DropForeignKey("dbo.Localidad", "ProvinciaId", "dbo.Provincia");
            DropForeignKey("dbo.Provincia", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Competencia", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Enfrentamiento", "ParticipanteY_ParticipanteId", "dbo.Participante");
            DropForeignKey("dbo.Enfrentamiento", "ParticipanteX_ParticipanteId", "dbo.Participante");
            DropForeignKey("dbo.Enfrentamiento", "SucesorPerdedor_EnfrentamientoId", "dbo.Enfrentamiento");
            DropForeignKey("dbo.Enfrentamiento", "SucesorGanador_EnfrentamientoId", "dbo.Enfrentamiento");
            DropForeignKey("dbo.DatosResultado", "Historico_EnfrentamientoId", "dbo.Enfrentamiento");
            DropForeignKey("dbo.Resultado", "DatosResultadoId", "dbo.DatosResultado");
            DropForeignKey("dbo.DatosResultado", "Actual_EnfrentamientoId", "dbo.Enfrentamiento");
            DropForeignKey("dbo.Participante", "CompentenciaId", "dbo.Competencia");
            DropForeignKey("dbo.Competencia", "FormaDePuntuacionId", "dbo.FormaDePuntuacion");
            DropForeignKey("dbo.Disponibilidad", "LugarId", "dbo.LugarDeRealizacion");
            DropForeignKey("dbo.LugarDeRealizacion", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.DeporteLugar", "LugarId", "dbo.LugarDeRealizacion");
            DropForeignKey("dbo.DeporteLugar", "DeporteId", "dbo.Deporte");
            DropForeignKey("dbo.Disponibilidad", "CompetenciaId", "dbo.Competencia");
            DropIndex("dbo.Set", new[] { "FormaDePuntuacionId" });
            DropIndex("dbo.ResultadoFinal", new[] { "FormaDePuntuacionId" });
            DropIndex("dbo.Puntuacion", new[] { "FormaDePuntuacionId" });
            DropIndex("dbo.Score", new[] { "Participante_ParticipanteId" });
            DropIndex("dbo.Fixture", new[] { "Competencia_CompetenciaId" });
            DropIndex("dbo.Fecha", new[] { "FixtureId" });
            DropIndex("dbo.Provincia", new[] { "PaisId" });
            DropIndex("dbo.Localidad", new[] { "ProvinciaId" });
            DropIndex("dbo.Direccion", new[] { "LocalidadId" });
            DropIndex("dbo.Resultado", new[] { "DatosResultadoId" });
            DropIndex("dbo.DatosResultado", new[] { "Historico_EnfrentamientoId" });
            DropIndex("dbo.DatosResultado", new[] { "Actual_EnfrentamientoId" });
            DropIndex("dbo.Enfrentamiento", new[] { "ParticipanteY_ParticipanteId" });
            DropIndex("dbo.Enfrentamiento", new[] { "ParticipanteX_ParticipanteId" });
            DropIndex("dbo.Enfrentamiento", new[] { "SucesorPerdedor_EnfrentamientoId" });
            DropIndex("dbo.Enfrentamiento", new[] { "SucesorGanador_EnfrentamientoId" });
            DropIndex("dbo.Participante", new[] { "CompentenciaId" });
            DropIndex("dbo.Deporte", new[] { "Nombre" });
            DropIndex("dbo.DeporteLugar", new[] { "DeporteId" });
            DropIndex("dbo.DeporteLugar", new[] { "LugarId" });
            DropIndex("dbo.LugarDeRealizacion", new[] { "UsuarioId" });
            DropIndex("dbo.Disponibilidad", new[] { "CompetenciaId" });
            DropIndex("dbo.Disponibilidad", new[] { "LugarId" });
            DropIndex("dbo.Competencia", new[] { "FormaDePuntuacionId" });
            DropIndex("dbo.Competencia", new[] { "UsuarioId" });
            DropIndex("dbo.Usuario", new[] { "DireccionId" });
            DropIndex("dbo.Usuario", new[] { "TipoDocumentoId" });
            DropIndex("dbo.Login", new[] { "UsuarioId" });
            DropIndex("dbo.Auditoria", new[] { "LoginId" });
            DropTable("dbo.Set");
            DropTable("dbo.ResultadoFinal");
            DropTable("dbo.Puntuacion");
            DropTable("dbo.Score");
            DropTable("dbo.Fixture");
            DropTable("dbo.Fecha");
            DropTable("dbo.TipoDocumento");
            DropTable("dbo.Pais");
            DropTable("dbo.Provincia");
            DropTable("dbo.Localidad");
            DropTable("dbo.Direccion");
            DropTable("dbo.Resultado");
            DropTable("dbo.DatosResultado");
            DropTable("dbo.Enfrentamiento");
            DropTable("dbo.Participante");
            DropTable("dbo.FormaDePuntuacion");
            DropTable("dbo.Deporte");
            DropTable("dbo.DeporteLugar");
            DropTable("dbo.LugarDeRealizacion");
            DropTable("dbo.Disponibilidad");
            DropTable("dbo.Competencia");
            DropTable("dbo.Usuario");
            DropTable("dbo.Login");
            DropTable("dbo.Auditoria");
        }
    }
}
