using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles
{
    public class Validaciones
    {
        public static string ValidarCampos(string pDescripcion, string pMonto)
        {
            string error = "";

            if(pDescripcion.Length == 0)
            {
                error += "Debe completar el campo Descripción\n";
            }

            if(pMonto.Length == 0)
            {
                error += "Debe ingresar un monto";
            }

            else
            {
                error += IsInteger(pMonto);
            }                

            return error;
        }

        public static string ValidarTipo(string pDescripcion)
        {
            string error = "";

            if(pDescripcion.Length == 0)
            {
                error += "Debe completar la descripción\n";
            }            

            return error;
        }

        public static string IsInteger(string pString)
        {
            /*Takes char by char from the external string "pString" and compares
             * them with interger numbers from 0 to 9.
             * If some char it's equals to a number between 0 and 9, ends the second loop
             * and increases in 1 the counter i.
             * If a char doesn't match with j in any time of the loop, it means that is not a number 
             * and returns "error" as "Enter an integer number" to the main program which
             * called this method.
             */
            string error = "";
            
            for(int i = 0; i < pString.Length; i++)
            {
                for(int j = 0; j <= 9; j++)
                {
                    if(pString[i].ToString() == j.ToString())
                    {
                        break;
                    }

                    else if(j == 9 && pString[i].ToString() != j.ToString())
                    {
                        error = "Ingrese un valor numérico entero";
                        return error;
                    }
                }
            }

            return error;
        }
    }
}
