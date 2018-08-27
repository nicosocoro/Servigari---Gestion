using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using Bussines.Entities;
using System.Configuration;

namespace Database
{
    public class ManejadorArchivo
    {
        const string connIngresos = "connectionIngresos";
        const string connGastos = "connectionGastos";
        const string connTipos = "connectionTipos";

        public int GetLastID(string path)
        {
            string appSettings = ConfigurationManager.AppSettings["defaultPath"] + path;
            int ID = 0;

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            foreach (XmlNode node in doc.DocumentElement)
            {
                int idNode = int.Parse(node.ChildNodes[0].InnerText);
                if (idNode > ID)
                {
                    ID = idNode;
                }
            }

            return (ID + 1);
        }
    }
}
