using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        public Paciente(int id, string nombre, string apellido, string domicilio, int telefono, string email, int nroHistoriaClinica) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }

        public int NroHistoriaClinica { get; set; }
    }
}
