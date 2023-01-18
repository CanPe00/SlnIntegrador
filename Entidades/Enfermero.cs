using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Enfermero")]
    public class Enfermero:Persona
    {
        public Enfermero(int id, string nombre, string apellido, string domicilio, int telefono, string email, int cuil) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Cuil = cuil;
        }

        public int Cuil { get; set; }

        public Clinica Clinica { get; set; }
        [ForeignKey(nameof(Clinica))]
        public int ClinidaId { get; set; }

    }
}
