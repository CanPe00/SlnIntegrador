using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero:Persona
    {
        public Enfermero(int id, string nombre, string apellido, string domicilio, int telefono, string email, int cuil) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Cuil = cuil;
        }

        public int Cuil { get; set; }
    }
}
