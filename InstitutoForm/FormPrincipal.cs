using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoForm
{
    public partial class FormPrincipal : Form
    {
        private FormAlumno formAlumno;
        private FormProfesor formProfesor;
        private FormAsignatura formAsignatura;
        private FormConsultas formConsultas; 
        public FormPrincipal()
        {
            InitializeComponent();
            this.formAlumno = new FormAlumno();
            this.formProfesor = new FormProfesor();
            this.formAsignatura = new FormAsignatura();
            this.formConsultas = new FormConsultas();
        }

        //Abre la ventana de inertar-Alumno
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.formAlumno.ShowDialog();
        }

        //Abre la ventana de insertar-Profesores
        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.formProfesor.ShowDialog();
        }

        //Abre la ventana de insertar-Asignaturas
        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            this.formAsignatura.ShowDialog();
        }

        //Abre la ventana de consultas-Datos
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.formConsultas.ShowDialog();
        }

        //Cierra nuestra ventana-Programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
