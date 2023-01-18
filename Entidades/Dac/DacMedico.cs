using Entidades;
using Entidades.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Dac
{
    public static class DacMedico
    {
        private static DBClinicaContext context = new DBClinicaContext();
        public static List<Medico> Select()
        {
            return context.Medicos.ToList();
        }

        public static List<Medico> Select(string Especialidad)
        {
            return context.Medicos.Where(p => p.Especialidad == Especialidad).ToList();
        }

        public static int Insert(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();
         
        }

        public static int Update(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.Id);
            medicoOrigen.Nombre= medico.Nombre;
            medicoOrigen.Clinica= medico.Clinica;
            medicoOrigen.Apellido= medico.Apellido;
            medicoOrigen.Matricula= medico.Matricula;
            medicoOrigen.Especialidad= medico.Especialidad;
            medicoOrigen.Domicilio= medico.Domicilio;
            medicoOrigen.Email= medico.Email;
            medicoOrigen.Telefono= medico.Telefono;
            return context.SaveChanges();
        }

        public static int Delete(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.Id);
            if (medicoOrigen!=null)
            {
                context.Medicos.Remove(medicoOrigen);
                context.SaveChanges();
            }
            return 0;
        }

        public static Medico SelectById(int Id)
        {
            return context.Medicos.Find(Id);
        }


    }
}
