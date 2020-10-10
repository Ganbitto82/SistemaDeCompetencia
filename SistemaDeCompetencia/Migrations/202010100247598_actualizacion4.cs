namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fixture", "Competencia_CompetenciaId", "dbo.Competencia");
            DropForeignKey("dbo.Competencia", "Fixture_FixtureId", "dbo.Fixture");
            DropForeignKey("dbo.Competencia", "FixtureId", "dbo.Fixture");
            DropIndex("dbo.Competencia", new[] { "FixtureId" });
            DropIndex("dbo.Competencia", new[] { "Fixture_FixtureId" });
            DropIndex("dbo.Fixture", new[] { "Competencia_CompetenciaId" });
            DropColumn("dbo.Competencia", "Fixture_FixtureId");
            RenameColumn(table: "dbo.Competencia", name: "FixtureId", newName: "Fixture_FixtureId");
            AlterColumn("dbo.Competencia", "Fixture_FixtureId", c => c.Int());
            CreateIndex("dbo.Competencia", "Fixture_FixtureId");
            AddForeignKey("dbo.Competencia", "Fixture_FixtureId", "dbo.Fixture", "FixtureId");
            DropColumn("dbo.Fixture", "Competencia_CompetenciaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fixture", "Competencia_CompetenciaId", c => c.Int());
            DropForeignKey("dbo.Competencia", "Fixture_FixtureId", "dbo.Fixture");
            DropIndex("dbo.Competencia", new[] { "Fixture_FixtureId" });
            AlterColumn("dbo.Competencia", "Fixture_FixtureId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Competencia", name: "Fixture_FixtureId", newName: "FixtureId");
            AddColumn("dbo.Competencia", "Fixture_FixtureId", c => c.Int());
            CreateIndex("dbo.Fixture", "Competencia_CompetenciaId");
            CreateIndex("dbo.Competencia", "Fixture_FixtureId");
            CreateIndex("dbo.Competencia", "FixtureId");
            AddForeignKey("dbo.Competencia", "FixtureId", "dbo.Fixture", "FixtureId", cascadeDelete: true);
            AddForeignKey("dbo.Competencia", "Fixture_FixtureId", "dbo.Fixture", "FixtureId");
            AddForeignKey("dbo.Fixture", "Competencia_CompetenciaId", "dbo.Competencia", "CompetenciaId");
        }
    }
}
