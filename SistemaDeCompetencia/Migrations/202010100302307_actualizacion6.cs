namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Puntuacion", "PuntuacionId");
            DropColumn("dbo.ResultadoFinal", "ResultadoFinalId");
            DropColumn("dbo.Set", "SetId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Set", "SetId", c => c.Int(nullable: false));
            AddColumn("dbo.ResultadoFinal", "ResultadoFinalId", c => c.Int(nullable: false));
            AddColumn("dbo.Puntuacion", "PuntuacionId", c => c.Int(nullable: false));
        }
    }
}
