using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacMedico
    {
        public static List<Medico> Select()
        {
            //TODO SELECT
            return null;
        }

        public static List<Medico> Select(string Especialidad)
        {
            //TODO SELECT WHERE ESPECIALIDAD
            return null;
        }

        public static int Insert(Medico medico)
        {
            //TODO INSERT
            return 0;
        }

        public static int Eliminar(int Id)
        {
            //TODO DELETE WHERE ID
            return 0;
        }

        public static Medico SelectById(int Id)
        {
            //TODO SELECT WHERE ID
            return null;
        }


    }
}
