using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoForm
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }

        private void bnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Radio-button ALumno
        private void rbAlumnos_CheckedChanged(object sender, EventArgs e)
        {
            cbDn_iId.Items.Clear();
            cbDn_iId.Text = "DNI Alumnos";

            StreamReader ficheroAlumnos = null;

            try{
                ficheroAlumnos = File.OpenText("Alumnos.txt");
                String linea = ficheroAlumnos.ReadLine();  

                while (linea != null){
                    String[] camposLinea = linea.Split('-');
                    cbDn_iId.Items.Add(camposLinea[0]);
                    linea = ficheroAlumnos.ReadLine();      
                }
                ficheroAlumnos.Close();
                

            }catch(FileNotFoundException ex){
                MessageBox.Show(ex.Message, "Error-Fichero no encontrado");
            
            }catch(Exception ex){
                MessageBox.Show(ex.Message, "Error");

            }finally{
                if (ficheroAlumnos != null){
                    ficheroAlumnos.Close();
                }

            }
        }

        //RadioButton - Asignaturas
        private void rbAsignaturas_CheckedChanged(object sender, EventArgs e)
        {
            cbDn_iId.Items.Clear();
            cbDn_iId.Text = "ID Asignaturas";

            StreamReader ficheroAsign = null;

            try{
                ficheroAsign = File.OpenText("Asignaturas.txt");
                String linea = ficheroAsign.ReadLine();

                while (linea != null){
                    String[] camposLinea = linea.Split('-');
                    cbDn_iId.Items.Add(camposLinea[0]);
                    //Ver asignaturas por nombre
                    //cbDn_iId.Items.Add(camposLinea[1]);
                    linea = ficheroAsign.ReadLine();
                }
                ficheroAsign.Close();

            }catch (FileNotFoundException ex){
                MessageBox.Show(ex.Message, "Error-Fichero no encontrado");

            }catch (Exception ex){
                MessageBox.Show(ex.Message, "Error");

            }finally {
                if(ficheroAsign != null)
                {
                    ficheroAsign.Close();
                }
            }
        }

        //Radio-Button - Profesores
        private void rbProfesores_CheckedChanged(object sender, EventArgs e)
        {
            cbDn_iId.Items.Clear();
            cbDn_iId.Text = "DNI Profesores";

            StreamReader ficheroProfesores;

            try{
                ficheroProfesores = File.OpenText("Profesores.txt");
                String linea = ficheroProfesores.ReadLine();

                while (linea != null){
                    String[] camposLinea = linea.Split('-');
                    cbDn_iId.Items.Add(camposLinea[0]);
                    linea = ficheroProfesores.ReadLine();
                }

                ficheroProfesores.Close();

            }catch (FileNotFoundException ex){
                MessageBox.Show(ex.Message, "Error-Fichero no encontrado");

            }catch (Exception ex){
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Método que al clickear en uno de nuestros campos nos muestra los datos en las labels
        // del ComboBox de la derecha
        private void cbDn_iId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            borrarCampos();
            StreamReader fichero = null;

            //Rb-Alumno
            if (rbAlumnos.Checked)
            {
                String dniSelec = (String)cbDn_iId.SelectedItem;

                try
                {
                    fichero = File.OpenText("Alumnos.txt");
                    String linea = fichero.ReadLine();

                    while (linea != null){

                        String[] camposLinea = linea.Split('-');

                        if (dniSelec == camposLinea[0]){
                            for (int i = 0; i < camposLinea.Length; i++){

                                switch (i){
                                    case 0:
                                        resultado1.Text = camposLinea[i];
                                        break;

                                    case 1:
                                        resultado2.Text = camposLinea[i];
                                        break;

                                    case 2:
                                        resultado3.Text = camposLinea[i];
                                        break;

                                    case 3:
                                        resultado4.Text = camposLinea[i];
                                        break;

                                    case 4:
                                        resultado5.Text = camposLinea[i];
                                        break;
                                }
                            }
                            //Rellenar labels
                            campo1.Text = "DNI";
                            campo2.Text = "Nombre";
                            campo3.Text = "Fecha";
                            campo4.Text = "Dirección";
                            campo5.Text = "Teléfono";
                        }
                        linea = fichero.ReadLine();
                    }

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Error-Fichero no encontrado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");

                }finally{
                    if (fichero != null){
                        fichero.Close();
                    }

                }
                //RB-Profesor Seleccionado
            }else if (rbProfesores.Checked){
                String dniSelec = (String)cbDn_iId.SelectedItem;

                try
                {
                    fichero = File.OpenText("Profesores.txt");
                    String linea = fichero.ReadLine();

                    while (linea != null)
                    {
                        String[] camposLinea = linea.Split('-');

                        if (dniSelec == camposLinea[0])
                        {
                            for (int i = 0; i < camposLinea.Length; i++)
                            {

                                switch (i)
                                {
                                    case 0:
                                        resultado1.Text = camposLinea[i];
                                        break;

                                    case 1:
                                        resultado2.Text = camposLinea[i];
                                        break;

                                    case 2:
                                        resultado3.Text = camposLinea[i];
                                        break;

                                    case 3:
                                        resultado4.Text = camposLinea[i];
                                        break;

                                    case 4:
                                        resultado5.Text = camposLinea[i];
                                        break;
                                }
                            }
                            //Rellenar labels
                            campo1.Text = "DNI";
                            campo2.Text = "Nombre";
                            campo3.Text = "Dirección";
                            campo4.Text = "Teléfono";
                            campo5.Text = "Estudios";
                        }
                        linea = fichero.ReadLine();
                    }

                }catch (FileNotFoundException ex){
                    MessageBox.Show(ex.Message, "Error-Fichero no encontrado");

                }catch (Exception ex){
                    MessageBox.Show(ex.Message, "Error");

                }
                finally {
                    if (fichero != null){
                        fichero.Close();
                    }
                }

            } else{
                String idSelec = (String)cbDn_iId.SelectedItem;

                try{
                    fichero = File.OpenText("Asignaturas.txt");
                    String linea = fichero.ReadLine();

                    while (linea != null)
                    {
                        //Guardo solo una línea, no todas
                        String[] camposLinea = linea.Split('-');

                        if (idSelec == camposLinea[0]){
                            for (int i = 0; i < camposLinea.Length; i++){

                                switch (i){
                                    case 0:
                                        resultado1.Text = camposLinea[i];
                                        break;

                                    case 1:
                                        resultado2.Text = camposLinea[i];
                                        break;

                                    case 2:
                                        resultado3.Text = camposLinea[i];
                                        break;

                                    case 3:
                                        resultado4.Text = camposLinea[i];
                                        break;
                                }
                            }
                            //Rellenar labels
                            campo1.Text = "ID";
                            campo2.Text = "Nombre";
                            campo3.Text = "Departamento";
                            campo4.Text = "Horas";
                        }
                        linea = fichero.ReadLine();
                    }

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Error-Fichero no encontrado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");

                }
                finally
                {
                    if (fichero != null)
                    {
                        fichero.Close();
                    }
                }
            }
        }

        //Método que nos borra el contenido de todas las labels del comboBox
        // Para así que no se supriman algunos datos como Profesores - Asignatura
        //al tener diferente número de campos
        private void borrarCampos()
        {
            campo1.Text = "";
            campo2.Text = "";
            campo3.Text = "";
            campo4.Text = "";
            campo5.Text = "";

            resultado1.Text = "";
            resultado2.Text = "";
            resultado3.Text = "";
            resultado4.Text = "";
            resultado5.Text = "";

        }
    }
}
