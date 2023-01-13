﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico:Persona
    {
        
        public string Especialidad { get; set; }
        public int Matricula { get; set; }

        private static int cantClinicos;
        public static int CantClinicos { get { return cantClinicos; } }

        private static List<string> clinicos = new List<string>() ;
        public static  List<string> Clinicos { get { return clinicos; } }



        public Medico(int id, string nombre, string apellido, string domicilio, int telefono, string email, string especialidad, int matricula) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad = especialidad;
            Matricula = matricula;
            if (Especialidad == "Clinico")
            {
                cantClinicos++;
                clinicos.Add(Nombre);
                

            }
        }

        





    }
}
