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
using System.Text.RegularExpressions;

namespace InstitutoForm
{
    public partial class FormProfesor : Form
    {
        public FormProfesor()
        {
            InitializeComponent();
        }


        //Nos guardará los datos de un profesor en un archivo 'Profesores.txt'
        private void btnGuardarProfesor_Click_1(object sender, EventArgs e)
        {
            if (tbDniProfesor.Text.Length > 0 && tbNombreProfesor.Text.Length > 0 &&
               tbDireccionProfesor.Text.Length > 0 && tbTelefonoProfesor.Text.Length > 0 && tbEstudiosProfesor.Text.Length > 0)
            {
               
                Boolean noExisteErrorDni = RegexUtils.validarDni(tbDniProfesor.Text);
                Boolean noExisteErrorTelefono = RegexUtils.validarTelefono(tbTelefonoProfesor.Text);

                if (noExisteErrorTelefono && noExisteErrorDni)
                {
                    StreamWriter ficheroProfes;
                    String nombreFicheroProfesores = "Profesores.txt";
                    String datosProfesor = tbDniProfesor.Text + "-" + tbNombreProfesor.Text + "-" + tbDireccionProfesor.Text
                       + "-" + tbTelefonoProfesor.Text + "-" + tbEstudiosProfesor.Text;

                    if (File.Exists(nombreFicheroProfesores))
                    {
                        ficheroProfes = File.AppendText(nombreFicheroProfesores);
                        ficheroProfes.WriteLine(datosProfesor);
                        ficheroProfes.Close();

                    }
                    else
                    {
                        ficheroProfes = File.CreateText(nombreFicheroProfesores);
                        ficheroProfes.WriteLine(datosProfesor);
                        ficheroProfes.Close();
                    }

                    //Limpiar campos
                    borrarCamposProfesor();

                } else if(!noExisteErrorTelefono && noExisteErrorDni){
                    MessageBox.Show("Compruebe que el teléfono tenga 9 dígitos");

                }
                else if (noExisteErrorTelefono && !noExisteErrorDni){
                    MessageBox.Show("Compruebe que el DNI tenga el formato adecuado");

                }else{
                    MessageBox.Show("Compruebe que el teléfono tenga 9 dígitos y el DNI tenga el formato adecuado");
                }

            }
            else { MessageBox.Show("Debe rellenar todos los campos"); }
        }

        //Nos borrará-Limpiará todos los campos
        private void btnBorrarProfesor_Click(object sender, EventArgs e)
        {
            borrarCamposProfesor();
        }

        //Boton-Atras: Nos cierra la ventana sin guardar los cambios
        private void bnAtras_Click(object sender, EventArgs e)
        {
            if (tbDniProfesor.Text.Length > 0 || tbNombreProfesor.Text.Length > 0 ||
               tbDireccionProfesor.Text.Length > 0 || tbTelefonoProfesor.Text.Length > 0 || tbEstudiosProfesor.Text.Length >0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "ERROR", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    borrarCamposProfesor();
                    this.Close();
                }
            }
            else { this.Close(); }
        }

        //Método privado que nos borrará los campos
        private void borrarCamposProfesor()
        {
            tbDniProfesor.Clear();
            tbNombreProfesor.Clear();
            tbDireccionProfesor.Clear();
            tbTelefonoProfesor.Clear();
            tbEstudiosProfesor.Clear();
        }
    }
}
