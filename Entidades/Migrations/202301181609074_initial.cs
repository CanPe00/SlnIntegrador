namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(),
                        DirectorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Director", t => t.DirectorId)
                .Index(t => t.DirectorId);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        ClinidaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinica", t => t.ClinidaId, cascadeDelete: true)
                .Index(t => t.ClinidaId);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Especialidad = c.String(),
                        Matricula = c.Int(nullable: false),
                        ClinidaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona", t => t.Id)
                .ForeignKey("dbo.Clinica", t => t.ClinidaId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.ClinidaId);
            
            CreateTable(
                "dbo.Director",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PostGrado = c.String(),
                        ClinicaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medico", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Enfermero",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Cuil = c.Int(nullable: false),
                        ClinidaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona", t => t.Id)
                .ForeignKey("dbo.Clinica", t => t.ClinidaId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.ClinidaId);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NroHistoriaClinica = c.Int(nullable: false),
                        ClinidaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona", t => t.Id)
                .ForeignKey("dbo.Clinica", t => t.ClinidaId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.ClinidaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paciente", "ClinidaId", "dbo.Clinica");
            DropForeignKey("dbo.Paciente", "Id", "dbo.Persona");
            DropForeignKey("dbo.Enfermero", "ClinidaId", "dbo.Clinica");
            DropForeignKey("dbo.Enfermero", "Id", "dbo.Persona");
            DropForeignKey("dbo.Director", "Id", "dbo.Medico");
            DropForeignKey("dbo.Medico", "ClinidaId", "dbo.Clinica");
            DropForeignKey("dbo.Medico", "Id", "dbo.Persona");
            DropForeignKey("dbo.Habitacion", "ClinidaId", "dbo.Clinica");
            DropForeignKey("dbo.Clinica", "DirectorId", "dbo.Director");
            DropIndex("dbo.Paciente", new[] { "ClinidaId" });
            DropIndex("dbo.Paciente", new[] { "Id" });
            DropIndex("dbo.Enfermero", new[] { "ClinidaId" });
            DropIndex("dbo.Enfermero", new[] { "Id" });
            DropIndex("dbo.Director", new[] { "Id" });
            DropIndex("dbo.Medico", new[] { "ClinidaId" });
            DropIndex("dbo.Medico", new[] { "Id" });
            DropIndex("dbo.Habitacion", new[] { "ClinidaId" });
            DropIndex("dbo.Clinica", new[] { "DirectorId" });
            DropTable("dbo.Paciente");
            DropTable("dbo.Enfermero");
            DropTable("dbo.Director");
            DropTable("dbo.Medico");
            DropTable("dbo.Habitacion");
            DropTable("dbo.Persona");
            DropTable("dbo.Clinica");
        }
    }
}
