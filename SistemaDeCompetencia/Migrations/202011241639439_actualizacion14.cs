namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion14 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fecha", "FixtureId", "dbo.Fixture");
            DropIndex("dbo.Fecha", new[] { "FixtureId" });
            AlterColumn("dbo.Fecha", "FixtureId", c => c.Int(nullable: false));
            CreateIndex("dbo.Fecha", "FixtureId");
            AddForeignKey("dbo.Fecha", "FixtureId", "dbo.Fixture", "FixtureId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fecha", "FixtureId", "dbo.Fixture");
            DropIndex("dbo.Fecha", new[] { "FixtureId" });
            AlterColumn("dbo.Fecha", "FixtureId", c => c.Int());
            CreateIndex("dbo.Fecha", "FixtureId");
            AddForeignKey("dbo.Fecha", "FixtureId", "dbo.Fixture", "FixtureId");
        }
    }
}
