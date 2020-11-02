namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion9 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Competencia", name: "Fixture_FixtureId", newName: "FixtureId");
            RenameIndex(table: "dbo.Competencia", name: "IX_Fixture_FixtureId", newName: "IX_FixtureId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Competencia", name: "IX_FixtureId", newName: "IX_Fixture_FixtureId");
            RenameColumn(table: "dbo.Competencia", name: "FixtureId", newName: "Fixture_FixtureId");
        }
    }
}
