using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            grdMedicos.DataSource = AdmMedico.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico() {
                Nombre = "Cande",
                Apellido = "Perez",
                Domicilio = "Laprida 532",
                Telefono = (int)3413033,
                Email = "candemo@",
                Especialidad = "Clínico",
                Matricula = 1236,
                ClinidaId = 1
            };
            AdmMedico.Insertar(medico);
        }
    }
}
