namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enfrentamiento", "FechaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enfrentamiento", "FechaId");
            AddForeignKey("dbo.Enfrentamiento", "FechaId", "dbo.Fecha", "FechaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enfrentamiento", "FechaId", "dbo.Fecha");
            DropIndex("dbo.Enfrentamiento", new[] { "FechaId" });
            DropColumn("dbo.Enfrentamiento", "FechaId");
        }
    }
}
