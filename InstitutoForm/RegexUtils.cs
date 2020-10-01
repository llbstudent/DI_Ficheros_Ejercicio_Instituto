using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InstitutoForm
{
    class RegexUtils
    {
        //Método público que nos comprueba si el formato del teléfono está bien establecido
        public static Boolean validarTelefono(String telefono)
        {
            String regexTlf = "[0-9]{9}";
            Regex expresionRegular = new Regex(regexTlf);
            return expresionRegular.IsMatch(telefono);
        }


        //Método público que nos compriba que el formato del DNI es correcto
        public static Boolean validarDni(String dni)
        {
            String regexDni = "[0-9]{8}[a-zA-Z]$";
            Regex expresionReg = new Regex(regexDni);
            return expresionReg.IsMatch(dni);
        }

        //Método público que nos comprueba si el ID de nuestras asignaturas es un valor numérico
        public static Boolean validarIdAsignatura(String id)
        {
            String regexId = "^[0-9]*$";
            Regex expresionReg = new Regex(regexId);
            return expresionReg.IsMatch(id);
        }

        //Método público que nos comprueba el formato de las horas de las asignaturas
        // Estas horas sólo podrán tener 2 dígitos  
        public static Boolean validarHorasAsig(String horas)
        {
            String regexHoras = "^[0-9]{1,2}[:.,-]?$";
            Regex expresionReg = new Regex(regexHoras);
            return expresionReg.IsMatch(horas);
        }
    }
}
