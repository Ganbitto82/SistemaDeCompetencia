namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Competencia", "Deporte_DeporteId", c => c.Int());
            AddColumn("dbo.Competencia", "Fixture_FixtureId", c => c.Int());
            CreateIndex("dbo.Competencia", "FixtureId");
            CreateIndex("dbo.Competencia", "Deporte_DeporteId");
            CreateIndex("dbo.Competencia", "Fixture_FixtureId");
            AddForeignKey("dbo.Competencia", "Deporte_DeporteId", "dbo.Deporte", "DeporteId");
            AddForeignKey("dbo.Competencia", "Fixture_FixtureId", "dbo.Fixture", "FixtureId");
            AddForeignKey("dbo.Competencia", "FixtureId", "dbo.Fixture", "FixtureId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competencia", "FixtureId", "dbo.Fixture");
            DropForeignKey("dbo.Competencia", "Fixture_FixtureId", "dbo.Fixture");
            DropForeignKey("dbo.Competencia", "Deporte_DeporteId", "dbo.Deporte");
            DropIndex("dbo.Competencia", new[] { "Fixture_FixtureId" });
            DropIndex("dbo.Competencia", new[] { "Deporte_DeporteId" });
            DropIndex("dbo.Competencia", new[] { "FixtureId" });
            DropColumn("dbo.Competencia", "Fixture_FixtureId");
            DropColumn("dbo.Competencia", "Deporte_DeporteId");
        }
    }
}
