using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles
{
    public class Calendario
    {
        public static List<string> GetMeses()
        {
            List<string> listMeses = new List<string>
            {
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            };

            return listMeses;
        }

        public static List<string> GetAños()
        {
            List<string> listAños = new List<string>();            

            for(int a = DateTime.Today.Year; a >= 2017; a--)
            {
                listAños.Add(a.ToString());
            }

            return listAños;
        }
    }
}
