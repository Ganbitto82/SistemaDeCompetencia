namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DatosResultado", "Actual_EnfrentamientoId", "dbo.Enfrentamiento");
            DropIndex("dbo.DatosResultado", new[] { "Actual_EnfrentamientoId" });
            AddColumn("dbo.Enfrentamiento", "Actual_DatosResultadoId", c => c.Int());
            CreateIndex("dbo.Enfrentamiento", "Actual_DatosResultadoId");
            AddForeignKey("dbo.Enfrentamiento", "Actual_DatosResultadoId", "dbo.DatosResultado", "DatosResultadoId");
            DropColumn("dbo.DatosResultado", "Actual_EnfrentamientoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DatosResultado", "Actual_EnfrentamientoId", c => c.Int());
            DropForeignKey("dbo.Enfrentamiento", "Actual_DatosResultadoId", "dbo.DatosResultado");
            DropIndex("dbo.Enfrentamiento", new[] { "Actual_DatosResultadoId" });
            DropColumn("dbo.Enfrentamiento", "Actual_DatosResultadoId");
            CreateIndex("dbo.DatosResultado", "Actual_EnfrentamientoId");
            AddForeignKey("dbo.DatosResultado", "Actual_EnfrentamientoId", "dbo.Enfrentamiento", "EnfrentamientoId");
        }
    }
}
