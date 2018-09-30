using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles
{
    public class Calendario
    {
        public static DataTable GetMeses_DT()
        {
            DataTable dt = new DataTable();
                       
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Mes", typeof(string));

            var list = GetMeses();
            int i = 1;

            foreach(string str in list)
            {
                dt.Rows.Add(i.ToString(), str);
                i++;
            }

            return dt;
        }

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
