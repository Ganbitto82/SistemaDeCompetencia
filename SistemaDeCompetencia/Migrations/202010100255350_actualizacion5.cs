namespace SistemaDeCompetencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Competencia", "Deporte_DeporteId", "dbo.Deporte");
            DropIndex("dbo.Competencia", new[] { "Deporte_DeporteId" });
            RenameColumn(table: "dbo.Competencia", name: "Deporte_DeporteId", newName: "DeporteId");
            AlterColumn("dbo.Competencia", "DeporteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Competencia", "DeporteId");
            AddForeignKey("dbo.Competencia", "DeporteId", "dbo.Deporte", "DeporteId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competencia", "DeporteId", "dbo.Deporte");
            DropIndex("dbo.Competencia", new[] { "DeporteId" });
            AlterColumn("dbo.Competencia", "DeporteId", c => c.Int());
            RenameColumn(table: "dbo.Competencia", name: "DeporteId", newName: "Deporte_DeporteId");
            CreateIndex("dbo.Competencia", "Deporte_DeporteId");
            AddForeignKey("dbo.Competencia", "Deporte_DeporteId", "dbo.Deporte", "DeporteId");
        }
    }
}
