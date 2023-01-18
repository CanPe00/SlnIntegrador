using Entidades.Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Dac
{
    public static class DacHabitacion
    {
        private static DBClinicaContext context = new DBClinicaContext();
        public static List<Habitacion> Select()
        {
            return context.Habitaciones.ToList();
        }

        public static List<Habitacion> Select(bool Estado)
        {
            return context.Habitaciones.Where(p => p.Estado == Estado).ToList();
        }

        public static int Insert(Habitacion habitacion)
        {
            context.Habitaciones.Add(habitacion);
            return context.SaveChanges();

        }

        public static int Update(Habitacion habitacion)
        {
            Habitacion habitacionOrigen = context.Habitaciones.Find(habitacion.Id);
            habitacionOrigen.Numero = habitacion.Numero;
            habitacionOrigen.Estado = habitacion.Estado;
            habitacion.ClinidaId = habitacion.ClinidaId;
            return context.SaveChanges();
        }

        public static int Delete(Habitacion habitacion)
        {
            Habitacion habitacionOrigen = context.Habitaciones.Find(habitacion.Id);
            if (habitacionOrigen != null)
            {
                context.Habitaciones.Remove(habitacionOrigen);
                context.SaveChanges();
            }
            return 0;
        }

        public static Habitacion SelectById(int id)
        {
            return context.Habitaciones.Find(id);
        }
    }
}
