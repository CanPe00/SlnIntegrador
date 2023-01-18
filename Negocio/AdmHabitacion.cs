
using Entidades;
using Entidades.Dac;
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

            //List<Habitacion> listaHabitaciones = new List<Habitacion>();
            //listaHabitaciones.Add(new Habitacion()
            //{
            //    Id = 1,
            //    Numero = 52,
            //    Estado = true,

            //}); ;
            //listaHabitaciones.Add(new Habitacion()
            //{
            //    Id = 2,
            //    Numero = 2,
            //    Estado = false,

            //});
            //listaHabitaciones.Add(new Habitacion()
            //{
            //    Id = 3,
            //    Numero = 78,
            //    Estado = true,
            //});
            return DacHabitacion.Select();
        }

        public static List<Habitacion> Listar(bool Estado)
        {
            return DacHabitacion.Select(Estado);
        }

        public static int Insertar(Habitacion habitacion)
        {
            return DacHabitacion.Insert(habitacion);
        }

        public static int Eliminar(Habitacion habitacion)
        {
            return DacHabitacion.Delete(habitacion);
        }
        public static Habitacion TraerUno(int Id)
        {
            return DacHabitacion.SelectById(Id);
        }
    }
}
