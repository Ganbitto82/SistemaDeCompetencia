namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enfrentamiento", "ParticipanteY_ParticipanteId", "dbo.Participante");
            DropIndex("dbo.Enfrentamiento", new[] { "ParticipanteY_ParticipanteId" });
            RenameColumn(table: "dbo.Enfrentamiento", name: "ParticipanteY_ParticipanteId", newName: "ParticipanteYId");
            AlterColumn("dbo.Enfrentamiento", "ParticipanteYId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enfrentamiento", "ParticipanteYId");
            AddForeignKey("dbo.Enfrentamiento", "ParticipanteYId", "dbo.Participante", "ParticipanteId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enfrentamiento", "ParticipanteYId", "dbo.Participante");
            DropIndex("dbo.Enfrentamiento", new[] { "ParticipanteYId" });
            AlterColumn("dbo.Enfrentamiento", "ParticipanteYId", c => c.Int());
            RenameColumn(table: "dbo.Enfrentamiento", name: "ParticipanteYId", newName: "ParticipanteY_ParticipanteId");
            CreateIndex("dbo.Enfrentamiento", "ParticipanteY_ParticipanteId");
            AddForeignKey("dbo.Enfrentamiento", "ParticipanteY_ParticipanteId", "dbo.Participante", "ParticipanteId");
        }
    }
}
