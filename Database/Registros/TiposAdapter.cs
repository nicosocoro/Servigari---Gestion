using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using Bussines.Entities;
using System.Configuration;

namespace Database.Registros
{
    public class TiposAdapter : ManejadorArchivo
    {
        public List<string> GetTipos()
        {
            List<string> listTipos = new List<string>();

            try
            {
                string appSettings = ConfigurationManager.AppSettings["connectionTipos"];

                XmlDocument doc = new XmlDocument();
                doc.Load(appSettings);

                foreach (XmlNode node in doc.DocumentElement)
                {
                    listTipos.Add(node.ChildNodes[0].InnerText);
                }
            }

            catch (Exception ex)
            {
                Exception excepcion = new Exception("Error al recuperar tipos: " + ex);
                throw excepcion;
            }

            return listTipos;
        }

        public void NuevoTipo(string pDescripcion)
        {
            string appSettings = ConfigurationManager.AppSettings["connectionTipos"];

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            XmlNode Tipo = doc.CreateElement("Tipo");

            XmlNode Descripcion = doc.CreateElement("Descripcion");

            //se asignan los valores dentro de las etiquetas
            Descripcion.InnerText = pDescripcion;

            //se anidan los nodos dentro de tipo
            Tipo.AppendChild(Descripcion);

            //se anida el nodo <Tipo></Tipo> dentro del documento
            doc.DocumentElement.AppendChild(Tipo);

            doc.Save(appSettings);
        }

        public void BorrarTipo(string pDescripcion)
        {
            string appSettings = ConfigurationManager.AppSettings["connectionTipos"];

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            foreach (XmlNode xNode in doc.SelectNodes("Tipos/Tipo"))
            {
                if (xNode.SelectSingleNode("Descripcion").InnerText == pDescripcion)
                {
                    xNode.ParentNode.RemoveChild(xNode);
                }

                doc.Save(appSettings);
            }
        }
    }
}
