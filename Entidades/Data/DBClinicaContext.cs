using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data
{
    public class DBClinicaContext:DbContext
    {
        public DBClinicaContext() : base("KeyDB") { }

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Director> Directores { get; set; }
        public DbSet<Enfermero> Enfermeros { get; set;}
        public DbSet<Habitacion> Habitaciones { get;set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get;set; }
        public DbSet<Persona> Personas { get; set; }
    }
}
