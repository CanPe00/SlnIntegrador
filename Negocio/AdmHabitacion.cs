using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            //TODO SELECT
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            listaHabitaciones.Add(new Habitacion()
            {
                Id = 1,
                Numero = 52,
                Estado = true,
               
            }); ;
            listaHabitaciones.Add(new Habitacion()
            {
                Id = 2,
                Numero = 2,
                Estado = false,
                
            });
            listaHabitaciones.Add(new Habitacion()
            {
                Id = 3,
                Numero = 78,
                Estado = true,
            });
            return listaHabitaciones;
        }

        public static List<Habitacion> Listar(bool Estado)
        {
            //TODO SELECT WHERE ESTADO
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO INSERT
            return 0;
        }

        public static int Eliminar(int Id)
        {
            //TODO DELETE WHERE ID
            return 0;
        }
        public static Habitacion TraerUno(int Numero)
        {
            //TODO SELECT WHERE numero
            return null;
        }
    }
}
