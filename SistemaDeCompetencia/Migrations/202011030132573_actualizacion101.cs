namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion101 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enfrentamiento", "ParticipanteX_ParticipanteId", "dbo.Participante");
            DropIndex("dbo.Enfrentamiento", new[] { "ParticipanteX_ParticipanteId" });
            RenameColumn(table: "dbo.Enfrentamiento", name: "ParticipanteX_ParticipanteId", newName: "ParticipanteXId");
            AlterColumn("dbo.Enfrentamiento", "ParticipanteXId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enfrentamiento", "ParticipanteXId");
            AddForeignKey("dbo.Enfrentamiento", "ParticipanteXId", "dbo.Participante", "ParticipanteId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enfrentamiento", "ParticipanteXId", "dbo.Participante");
            DropIndex("dbo.Enfrentamiento", new[] { "ParticipanteXId" });
            AlterColumn("dbo.Enfrentamiento", "ParticipanteXId", c => c.Int());
            RenameColumn(table: "dbo.Enfrentamiento", name: "ParticipanteXId", newName: "ParticipanteX_ParticipanteId");
            CreateIndex("dbo.Enfrentamiento", "ParticipanteX_ParticipanteId");
            AddForeignKey("dbo.Enfrentamiento", "ParticipanteX_ParticipanteId", "dbo.Participante", "ParticipanteId");
        }
    }
}
