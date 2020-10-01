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
    public partial class FormAsignatura : Form
    {
        public FormAsignatura()
        {
            InitializeComponent();
        }

        //Botón atrás
        private void bnAtras_Click(object sender, EventArgs e)
        {
            if (tbIDAsignatura.Text.Length > 0 || tbNombreAsignatura.Text.Length > 0 ||
               tbDepartamentoAsig.Text.Length > 0 || tbhorasSemanalesAsig.Text.Length > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "ERROR", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    borrarCamposAsignaturas();
                    this.Close();
                }
            }
            else { this.Close(); }
        }

        //Botón guaradar Asignaturas en un fichero.txt
        private void btnGuardarProfesor_Click(object sender, EventArgs e)
        {
            if (tbIDAsignatura.Text.Length > 0 && tbNombreAsignatura.Text.Length > 0 &&
               tbDepartamentoAsig.Text.Length > 0 && tbhorasSemanalesAsig.Text.Length > 0)
            {
                Boolean noExisteErrorId = RegexUtils.validarIdAsignatura(tbIDAsignatura.Text);
                Boolean noExisteErrorHoras = RegexUtils.validarHorasAsig(tbhorasSemanalesAsig.Text);

                if (noExisteErrorId && noExisteErrorHoras){

                    StreamWriter ficheroAsig;
                    String nombreFicheroAsig = "Asignaturas.txt";
                    String datosAsignaturas = tbIDAsignatura.Text + "-" + tbNombreAsignatura.Text + "-"
                        + tbDepartamentoAsig.Text + "-" + tbhorasSemanalesAsig.Text;

                    if (File.Exists(nombreFicheroAsig)){
                        ficheroAsig = File.AppendText(nombreFicheroAsig);
                        ficheroAsig.WriteLine(datosAsignaturas);
                        ficheroAsig.Close();

                    }else{
                        ficheroAsig = File.CreateText(nombreFicheroAsig);
                        ficheroAsig.WriteLine(datosAsignaturas);
                        ficheroAsig.Close();
                    }
                    //Limpiar campos
                    borrarCamposAsignaturas();

                }else if (!noExisteErrorId && noExisteErrorHoras){
                    MessageBox.Show("Debe insertar un ID numérico.");
                }
                else if (noExisteErrorId && !noExisteErrorHoras){
                    MessageBox.Show("Debe insertar un número de horas en dígitos numéricos (sólo dos).");
                }
                else{
                    MessageBox.Show("Debe insertar un ID numérico y Debe insertar un número de horas en dígitos numéricos (sólo dos).");
                }

            } else { MessageBox.Show("Debe rellenar todos los campos"); }
        }

        //Método que nos limpia-borrar todos los campos de la asigantura
        private void btnBorrarProfesor_Click(object sender, EventArgs e)
        {
            borrarCamposAsignaturas();
        }


        //Método privado que nos limpia-borra todos los campos
        private void borrarCamposAsignaturas()
        {
            tbIDAsignatura.Clear();
            tbNombreAsignatura.Clear();
            tbDepartamentoAsig.Clear();
            tbhorasSemanalesAsig.Clear();
        }
    }
}
