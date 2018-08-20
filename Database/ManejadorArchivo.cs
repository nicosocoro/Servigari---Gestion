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
        protected DataTable Ingresos;

        public ManejadorArchivo()
        {
            this.Ingresos = this.GetIngresos();
        }

        public virtual DataTable GetIngresos()
        {
            return new DataTable();
        }

        public virtual DataTable GetGastos()
        {
            return new DataTable();
        }

        public virtual int GetLastID(string subPath2)
        {
            return new int();
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

        public void AdNuedRowIngresos(MontoEntities montoEntity, string filePath)
        {
            string appSettings = ConfigurationManager.AppSettings[filePath];

            string subPath = "";
            string subPath2 = "";

            switch (montoEntity.TipoMonto)
            {
                case TipoMonto.Ingreso:
                    subPath = "ingreso";
                    subPath2 = "Ingresos.xml";
                    break;

                case TipoMonto.Gasto:
                    subPath = "gasto";
                    subPath2 = "Gastos.xml";
                    break;
            }

            montoEntity.ID = GetLastID(subPath2);
            montoEntity.Fecha = DateTime.Now;

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            XmlNode Ingreso = doc.CreateElement(subPath); //<ingreso>...nodos internos...</ingreso>

            //son los nodos internos de <ingreso></ingreso>
            XmlNode ID = doc.CreateElement("ID");
            XmlNode descripcion = doc.CreateElement("Descripcion");
            XmlNode monto = doc.CreateElement("Monto");
            XmlNode fecha = doc.CreateElement("Fecha");
            XmlNode tipo = doc.CreateElement("Tipo");

            //se asignan los valores dentro de las etiquetas
            //por ejemplo, <ID>***</ID> --> toma el valor ***montoEntity.ID.ToString();
            ID.InnerText = montoEntity.ID.ToString();
            descripcion.InnerText = montoEntity.Descripcion;
            monto.InnerText = montoEntity.Monto;
            fecha.InnerText = montoEntity.Fecha.ToString();
            tipo.InnerText = montoEntity.Tipo;

            //se anidan los nodos dentro de ingreso
            Ingreso.AppendChild(ID);
            Ingreso.AppendChild(descripcion);
            Ingreso.AppendChild(monto);
            Ingreso.AppendChild(fecha);
            Ingreso.AppendChild(tipo);

            //se anida el nodo <ingreso></ingreso> dentro del documento
            doc.DocumentElement.AppendChild(Ingreso);

            doc.Save(appSettings);
        }

        public void DeleteRow(int pIDEntity, string filePath, string subPath)
        {
            string appSettings = ConfigurationManager.AppSettings[filePath];

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            foreach (XmlNode xNode in doc.SelectNodes(subPath))
            {
                if (xNode.SelectSingleNode("ID").InnerText == pIDEntity.ToString())
                {
                    xNode.ParentNode.RemoveChild(xNode);
                }

                doc.Save(appSettings);
            }
        }

        public void ModifyRow(MontoEntities montoEntity, string filePath, string subPath)
        {
            string appSettings = ConfigurationManager.AppSettings[filePath];

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            foreach (XmlNode xNode in doc.SelectNodes(subPath))
            {
                if (xNode.SelectSingleNode("ID").InnerText == montoEntity.ID.ToString())
                {
                    xNode.SelectSingleNode("Descripcion").InnerText = montoEntity.Descripcion;
                    xNode.SelectSingleNode("Monto").InnerText = montoEntity.Monto;
                    //xNode.SelectSingleNode("Fecha").InnerText = DateTime.Now.ToString();
                    xNode.SelectSingleNode("Tipo").InnerText = montoEntity.Tipo;

                    doc.Save(appSettings);
                    break;
                }
            }
        }

        public void CheckNodeTipo()
        {
            string path = "";
            string subpath = "";

            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        path = "connectionIngresos";
                        subpath = "ingreso";
                        break;
                    case 1:
                        path = "connectionGastos";
                        subpath = "gasto";
                        break;
                    default:
                        break;
                }

                string appSettings = ConfigurationManager.AppSettings[path];

                XmlDocument doc = new XmlDocument();
                doc.Load(appSettings);

                foreach(XmlNode node in doc.SelectNodes("registros/" + subpath))
                {
                    if(node.SelectSingleNode("Tipo") == null)
                    {
                        XmlNode Tipo = doc.CreateElement("Tipo");
                        Tipo.InnerText = "SIN ASIGNAR";

                        node.AppendChild(Tipo);

                        doc.Save(appSettings);
                    }
                }

            }
        }
    }
}
