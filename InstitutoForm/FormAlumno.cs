using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InstitutoForm
{
    public partial class FormAlumno : Form
    {
        public FormAlumno()
        {
            InitializeComponent();
        }

        //Nos guaradará los datos en el archivo 'alumnos.txt'
        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (tbDniAlumno.Text.Length > 0 && tbNombreAlumno.Text.Length > 0 &&
                tbTelefonoAlumno.Text.Length > 0 && tbDireccionAlumno.Text.Length > 0)
            {
                String tlfAlumno = tbTelefonoAlumno.Text;
                Boolean dniCorrecto = RegexUtils.validarDni(tbDniAlumno.Text);
                Boolean tlfCorrecto = RegexUtils.validarTelefono(tlfAlumno);

                if (dniCorrecto && tlfCorrecto)
                {
                    StreamWriter fichero;
                    String nombreFichero = "Alumnos.txt";
                    String fecha = dtpFechaAlumno.Value.Date.ToShortDateString();
                    String datosAlumno = tbDniAlumno.Text + "-" + tbNombreAlumno.Text + "-" + fecha
                       + "-" + tbDireccionAlumno.Text + "-" + tbTelefonoAlumno.Text;

                    if (File.Exists(nombreFichero))
                    {
                        fichero = File.AppendText(nombreFichero);
                        fichero.WriteLine(datosAlumno);
                        fichero.Close();

                    }
                    else
                    {
                        fichero = File.CreateText(nombreFichero);
                        fichero.WriteLine(datosAlumno);
                        fichero.Close();
                    }
                    //Limpiar campos
                    borrarCampos();
                }else if (!dniCorrecto && tlfCorrecto){
                    MessageBox.Show("Debe ingresar un formato válido para el DNI.");

                }else if (dniCorrecto && !tlfCorrecto){
                    MessageBox.Show("Debe ingresar un número telefónico de 9 dígitos.");

                }else{
                    MessageBox.Show("Debe ingresar un formato válido para el DNI e ingresar un número telefónico de 9 dígitos.");
                }

            }else{ MessageBox.Show("Debe rellenar todos los campos");}
        }


        //Botón que borra-Limpia todos los campos-TextBox
        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            borrarCampos();
        }


        //Boton-Atras: Nos cierra la ventana que nos preguntará si queremos guardar los cambios 
        // si tenemos algo escrito
        private void bnAtras_Click(object sender, EventArgs e)
        {
            if (tbDniAlumno.Text.Length > 0 || tbNombreAlumno.Text.Length > 0 ||
                tbTelefonoAlumno.Text.Length > 0 || tbDireccionAlumno.Text.Length > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "ERROR", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    borrarCampos();
                    this.Close();
                }
            }
            else { this.Close(); }

        }

        //Metodo privado que nos borra los campos
        //Se llamará tanto en el método atrás que nos dará la opción 
        //y en el evento del botón borrar
        private void borrarCampos()
        {
            tbDniAlumno.Clear();
            tbNombreAlumno.Clear();
            tbTelefonoAlumno.Clear();
            tbDireccionAlumno.Clear();
        }
    }
}
