using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Director")]
    public class Director:Medico
    {
        public Director(int id, string nombre, string apellido, string domicilio, int telefono, string email, string especialidad, int matricula, string postGrado) : base(id, nombre, apellido, domicilio, telefono, email, especialidad, matricula)
        {
            PostGrado = postGrado;
        }

        public Director() { }

        public string PostGrado { get; set; }

        public Clinica Clinica { get; set; }
        [ForeignKey(nameof(Clinica))]
        public int ClinicaId { get; set; }
    }
}
