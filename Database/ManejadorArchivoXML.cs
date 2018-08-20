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

namespace Database
{
    public class ManejadorArchivoXML : ManejadorArchivo
    {
        protected DataSet ds;

        const string connIngresos = "connectionIngresos";
        const string connGastos = "connectionGastos";
        const string connTipos = "connectionTipos";

        public override DataTable GetIngresos()
        {
            this.ds = new DataSet();

            try
            {
                string appSettings = ConfigurationManager.AppSettings["connectionIngresos"];
                this.ds.ReadXml(appSettings);
            }

            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }

            return this.ds.Tables["ingreso"];
        }

        public override DataTable GetGastos()
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

        public override int GetLastID(string path)
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

        public int CalcularTotalMonto(int pMonth, string pYear, string pDescripcion, string pPath)
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
                if (pMonth == 0 && pYear == "Todo" && pDescripcion == "Todo")
                {
                    result += Convert.ToInt32(node.ChildNodes[2].InnerText);
                }

                else if (pMonth == 0 && pYear == "Todo" && pDescripcion != "Todo")
                {
                    if (pDescripcion == desc)
                    {
                        result += value;
                    }
                }

                else if (pMonth == 0 && pYear != "Todo" && pDescripcion == "Todo")
                {
                    if (pDescripcion == desc)
                    {
                        result += value;
                    }
                }

                else if (pMonth == 0 && pYear != "Todo" && pDescripcion != "Todo")
                {
                    if (pDescripcion == desc && pYear == year)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear == "Todo" && pDescripcion == "Todo")
                {
                    if (month == pMonth)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear == "Todo" && pDescripcion != "Todo")
                {
                    if (pMonth == month && pDescripcion == desc)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear != "Todo" && pDescripcion == "Todo")
                {
                    if (pMonth == month && pDescripcion == desc)
                    {
                        result += value;
                    }
                }

                else if (pMonth != 0 && pYear != "Todo" && pDescripcion != "Todo")
                {
                    if (month == pMonth && pDescripcion == desc)
                    {
                        result += value;
                    }
                }

                #endregion
            }

            return result;
        }
    }
}