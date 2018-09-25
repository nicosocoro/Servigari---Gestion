using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Configuration;
using Bussines.Entities;

namespace Database
{
    public class RecordAdapter : ManejadorArchivo
    {
        protected DataSet ds;
        protected DataTable Ingresos;

        public RecordAdapter()
        {
            this.Ingresos = this.GetIngresos();
        }

        public DataTable GetIngresos()
        {
            try
            {
                this.ds = new DataSet();

                string appSettings = ConfigurationManager.AppSettings["connectionIngresos"];
                this.ds.ReadXml(appSettings);
            }

            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }

            return this.ds.Tables["ingreso"];
        }

        public DataTable GetGastos()
        {
            this.ds = new DataSet();

            try
            {
                string appSettings = ConfigurationManager.AppSettings["connectionGastos"];
                this.ds.ReadXml(appSettings);
            }

            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }

            return this.ds.Tables["gasto"];
        }
                
        public int CalcularTotalMonto(int pMonth, string pYear, string pTipo, string pPath)
        {
            string appSettings = ConfigurationManager.AppSettings["defaultPath"] + pPath;
            int result = 0;

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            foreach (XmlNode node in doc.DocumentElement)
            {
                DateTime date = DateTime.Parse(node.ChildNodes[3].InnerText);
                int month = date.Month;
                string year = date.Year.ToString();

                int value = Convert.ToInt32(node.ChildNodes[2].InnerText);

                string desc = node.ChildNodes[4].InnerText;

                #region Validaciones
                if (pMonth == 0 && pYear == "Todo" && pTipo == "Todo")
                {
                    result += Convert.ToInt32(node.ChildNodes[2].InnerText);
                }

                else if (pMonth == 0 && pYear == "Todo" && pTipo != "Todo")
                {
                    if (pTipo == desc)
                    {
                        result += value;
                    }
                }

                else if (pMonth == 0 && pYear != "Todo" && pTipo == "Todo")
                {
                    if (pYear == year)
                    {
                        result += value;
                    }
                }

                else if (pMonth == 0 && pYear != "Todo" && pTipo != "Todo")
                {
                    if (pTipo == desc && pYear == year)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear == "Todo" && pTipo == "Todo")
                {
                    if (month == pMonth)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear == "Todo" && pTipo != "Todo")
                {
                    if (pMonth == month && pTipo == desc)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear != "Todo" && pTipo == "Todo")
                {
                    if (pMonth == month && pYear == year)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear != "Todo" && pTipo != "Todo")
                {
                    if (month == pMonth && pTipo == desc)
                    {
                        result += value;
                    }
                }

                #endregion
            }

            return result;
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


    }
}
