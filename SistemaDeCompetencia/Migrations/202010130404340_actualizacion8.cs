namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Disponibilidad", "CompetenciaId", "dbo.Competencia");
            DropIndex("dbo.Disponibilidad", new[] { "CompetenciaId" });
            AlterColumn("dbo.Disponibilidad", "CompetenciaId", c => c.Int());
            CreateIndex("dbo.Disponibilidad", "CompetenciaId");
            AddForeignKey("dbo.Disponibilidad", "CompetenciaId", "dbo.Competencia", "CompetenciaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Disponibilidad", "CompetenciaId", "dbo.Competencia");
            DropIndex("dbo.Disponibilidad", new[] { "CompetenciaId" });
            AlterColumn("dbo.Disponibilidad", "CompetenciaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Disponibilidad", "CompetenciaId");
            AddForeignKey("dbo.Disponibilidad", "CompetenciaId", "dbo.Competencia", "CompetenciaId", cascadeDelete: true);
        }
    }
}
