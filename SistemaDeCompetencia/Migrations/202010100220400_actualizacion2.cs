namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Score", "Participante_ParticipanteId", "dbo.Participante");
            DropIndex("dbo.Score", new[] { "Participante_ParticipanteId" });
            RenameColumn(table: "dbo.Score", name: "Participante_ParticipanteId", newName: "ParticipanteId");
            AddColumn("dbo.Competencia", "Estado", c => c.Int(nullable: false));
            AddColumn("dbo.Competencia", "Modalidad", c => c.Int(nullable: false));
            AddColumn("dbo.DatosResultado", "GanadorY", c => c.Boolean(nullable: false));
            AddColumn("dbo.DatosResultado", "ParticipanteYPresente", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Score", "ParticipanteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Score", "ParticipanteId");
            AddForeignKey("dbo.Score", "ParticipanteId", "dbo.Participante", "ParticipanteId", cascadeDelete: true);
            DropColumn("dbo.Competencia", "TipoEstado");
            DropColumn("dbo.Competencia", "TipoModalidad");
            DropColumn("dbo.Participante", "ScoreId");
            DropColumn("dbo.Participante", "FixtureId");
            DropColumn("dbo.DatosResultado", "Ganador");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DatosResultado", "Ganador", c => c.Boolean(nullable: false));
            AddColumn("dbo.Participante", "FixtureId", c => c.Int(nullable: false));
            AddColumn("dbo.Participante", "ScoreId", c => c.Int(nullable: false));
            AddColumn("dbo.Competencia", "TipoModalidad", c => c.Int(nullable: false));
            AddColumn("dbo.Competencia", "TipoEstado", c => c.Int(nullable: false));
            DropForeignKey("dbo.Score", "ParticipanteId", "dbo.Participante");
            DropIndex("dbo.Score", new[] { "ParticipanteId" });
            AlterColumn("dbo.Score", "ParticipanteId", c => c.Int());
            DropColumn("dbo.DatosResultado", "ParticipanteYPresente");
            DropColumn("dbo.DatosResultado", "GanadorY");
            DropColumn("dbo.Competencia", "Modalidad");
            DropColumn("dbo.Competencia", "Estado");
            RenameColumn(table: "dbo.Score", name: "ParticipanteId", newName: "Participante_ParticipanteId");
            CreateIndex("dbo.Score", "Participante_ParticipanteId");
            AddForeignKey("dbo.Score", "Participante_ParticipanteId", "dbo.Participante", "ParticipanteId");
        }
    }
}
