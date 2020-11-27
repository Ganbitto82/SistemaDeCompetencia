namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enfrentamiento", "LugarDeRealizacion_LugarId", c => c.Int());
            CreateIndex("dbo.Enfrentamiento", "LugarDeRealizacion_LugarId");
            AddForeignKey("dbo.Enfrentamiento", "LugarDeRealizacion_LugarId", "dbo.LugarDeRealizacion", "LugarId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enfrentamiento", "LugarDeRealizacion_LugarId", "dbo.LugarDeRealizacion");
            DropIndex("dbo.Enfrentamiento", new[] { "LugarDeRealizacion_LugarId" });
            DropColumn("dbo.Enfrentamiento", "LugarDeRealizacion_LugarId");
        }
    }
}
