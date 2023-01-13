using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace Negocio
{
    public static class AdmMedico
    {


        public static List<Medico> Listar()
        {
            //TODO SELECT

            List<Medico> listaMedicos = new List<Medico>();
            listaMedicos.Add(new Medico(1,"Cande", "Perez", "Laprida", 123456, "candem@", "Clinico", 1234));
            listaMedicos.Add(new Medico(2, "Rocio", "Perez", "Maipu", 45698,"rop@", "Clinico", 4569));
            listaMedicos.Add(new Medico(3,"Mariela","Gonzalez","Calle nro", 769856, "magon@", "Pediatra", 9632));
            return listaMedicos;
        }

        public static List<Medico> Listar(string Especialidad)
        {
            //TODO SELECT WHERE ESPECIALIDAD
            return null;
        }

        public static int Insertar(Medico medico)
        {
            //TODO INSERT
            return 0;
        }

        public static int Eliminar(int Id)
        {
            //TODO DELETE WHERE ID
            return 0;
        }
        public static Medico TraerUno(int Id)
        {
            //TODO SELECT WHERE ID
            return null;
        }
    }
}
