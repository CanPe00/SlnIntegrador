using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {

        public static List<Paciente> Listar()
        {
            //TODO SELECT
            List<Paciente> listaPacientes = new List<Paciente>();
            listaPacientes.Add(new Paciente(1, "Cande", "Perez", "Laprida", 123456, "candem@", 14));

            listaPacientes.Add(new Paciente(2, "Rocio", "Perez", "Maipu", 45698, "rop@", 58));
            //{
            //    Id =2,
            //    Nombre = "Rocio",
            //    Apellido = "Perez",
            //    Domicilio = "Maipu",
            //    Telefono = 45698,
            //    Email = "rop@",
            //    NroHistoriaClinica=58
            //});
            listaPacientes.Add(new Paciente(3, "Mariela", "Gonzalez", "Calle nro", 769856, "magon@", 789));
            //{
            //    Id = 3,
            //    Nombre = "Mariela",
            //    Apellido = "Gonzalez",
            //    Domicilio = "Calle nro",
            //    Telefono = 769856,
            //    Email = "magon@",
            //    NroHistoriaClinica = 789
            //});
            return listaPacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO INSERT
            return 0;
        }

        public static int Eliminar(int Id)
        {
            //TODO DELETE WHERE ID
            return 0;
        }
        public static Paciente TraerUno(int Id)
        {
            //TODO SELECT WHERE ID
            return null;
        }
    }
}
