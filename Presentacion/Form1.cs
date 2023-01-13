using Entidades;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarListas();
            medicosClinicos();
            habitaciones();

        }

        private void habitaciones()
        {
            //Mostrar una lista con el número y estado de las habitaciones en un listBox
            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                lstboxHabitaciones.Items.Add("Habitación N°: " + habitacion.Numero + "\tEstado: " + habitacion.Estado);
            }
        }

        private void mostrarListas()
        {
            //Mostrar la lista de médicos y pacientes en controles DataGridView
            dgvMedicos.DataSource = AdmMedico.Listar();
            dgvPacientes.DataSource = AdmPaciente.Listar();
        }

        private void medicosClinicos()
        {
            //Contar los médicos que son clínicos y mostrar sus nombre en un listBox
            lstboxMedicos.Items.Add("Cantidad de Medicos Clínicos: " + Medico.CantClinicos);
            lstboxMedicos.Items.Add("Nombres: \n");
            foreach (var item in Medico.Clinicos)
            {
                lstboxMedicos.Items.Add("\t -" + item);
            }
        }
    }
}
