using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

using Entidades.Dac;

namespace Negocio
{
    public static class AdmMedico
    {


        public static List<Medico> Listar()
        {
       

            //List<Medico> listaMedicos = new List<Medico>();
            //listaMedicos.Add(new Medico(1,"Cande", "Perez", "Laprida", 123456, "candem@", "Clinico", 1234));
            //listaMedicos.Add(new Medico(2, "Rocio", "Perez", "Maipu", 45698,"rop@", "Clinico", 4569));
            //listaMedicos.Add(new Medico(3,"Mariela","Gonzalez","Calle nro", 769856, "magon@", "Pediatra", 9632));
            return DacMedico.Select();
        }

        public static List<Medico> Listar(string Especialidad)
        {
            //TODO SELECT WHERE ESPECIALIDAD
            return DacMedico.Select(Especialidad);
        }

        public static int Insertar(Medico medico)
        {
            return DacMedico.Insert(medico);
        }

        public static int Eliminar(Medico medico)
        {
            return DacMedico.Delete(medico);
        }
        public static int Actualizar(Medico medico)
        {
            return DacMedico.Update(medico);
        }
        public static Medico TraerUno(int Id)
        {
            return DacMedico.SelectById(Id);
        }
    }
}
