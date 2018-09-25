using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Xml;

namespace Database.Clientes
{
    public class ClientesAdapter : Adapter
    {
        protected DataSet ds;
        protected DataTable Cliente;

        public string GetLastID()
        {
            DataTable dtClientes = GetClientes();
            int id = 0;
            foreach (DataRow dr in dtClientes.Rows)
            {
                int idCliente = Int32.Parse(dr["ID"].ToString());
                if (idCliente > id)
                {
                    id = idCliente;
                }
            }

            return (id + 1).ToString();
        }

        public DataTable GetClientes()
        {
            try
            {
                this.ds = new DataSet();

                string appSettings = ConfigurationManager.AppSettings["connectionClientes"];
                this.ds.ReadXml(appSettings);
            }

            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }

            return this.ds.Tables["cliente"];
        }

        #region METODOS SAVE
        public void Add(ClientesEntity oCliente)
        {
            try
            {
                string appSettings = ConfigurationManager.AppSettings["connectionClientes"];


                oCliente.ID = GetLastID();
                oCliente.FechaAlta = DateTime.Now.ToString();

                XmlDocument doc = new XmlDocument();
                doc.Load(appSettings);

                XmlNode Cliente = doc.CreateElement("cliente"); //<ingreso>...nodos internos...</ingreso>

                //son los nodos internos de <ingreso></ingreso>
                XmlNode ID = doc.CreateElement("ID");
                XmlNode nombre = doc.CreateElement("Nombre");
                XmlNode apellido = doc.CreateElement("Apellido");
                XmlNode telefonoFijo = doc.CreateElement("TelefonoFijo");
                XmlNode telefonoCelular = doc.CreateElement("TelefonoCelular");
                XmlNode telefonoAlternativo = doc.CreateElement("TelefonoAlternativo");
                XmlNode direccion = doc.CreateElement("Direccion");
                XmlNode comentarios = doc.CreateElement("Comentarios");
                XmlNode fechaAlta = doc.CreateElement("FechaAlta");

                ID.InnerText = oCliente.ID.ToString();
                nombre.InnerText = oCliente.Nombre;
                apellido.InnerText = oCliente.Apellido;
                telefonoFijo.InnerText = oCliente.TelefonoFijo;
                telefonoCelular.InnerText = oCliente.TelefonoCelular;
                telefonoAlternativo.InnerText = oCliente.TelefonoAlternativo;
                direccion.InnerText = oCliente.Direccion;
                comentarios.InnerText = oCliente.Comentarios;
                fechaAlta.InnerText = oCliente.FechaAlta.ToString();

                Cliente.AppendChild(ID);
                Cliente.AppendChild(nombre);
                Cliente.AppendChild(apellido);
                Cliente.AppendChild(telefonoFijo);
                Cliente.AppendChild(telefonoCelular);
                Cliente.AppendChild(telefonoAlternativo);
                Cliente.AppendChild(comentarios);
                Cliente.AppendChild(fechaAlta);

                doc.DocumentElement.AppendChild(Cliente);

                doc.Save(appSettings);
            }
            catch (Exception e)
            {
                throw new Exception("Se ha ocurrido un error: " + e.Message);
            }
        }

        public void Modify(ClientesEntity oCliente)
        {
            string appSettings = ConfigurationManager.AppSettings["connectionClientes"];

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            foreach (XmlNode xNode in doc.SelectNodes("clientes/cliente"))
            {
                if (xNode.SelectSingleNode("ID").InnerText == oCliente.ID)
                {
                    xNode.SelectSingleNode("Nombre").InnerText = oCliente.Nombre;
                    xNode.SelectSingleNode("Apellido").InnerText = oCliente.Apellido; 
                    xNode.SelectSingleNode("TelefonoFijo").InnerText = oCliente.TelefonoFijo;
                    xNode.SelectSingleNode("TelefonoCelular").InnerText = oCliente.TelefonoCelular;
                    xNode.SelectSingleNode("TelefonoAlternativo").InnerText = oCliente.TelefonoAlternativo;
                    xNode.SelectSingleNode("Direccion").InnerText = oCliente.Direccion;
                    xNode.SelectSingleNode("Comentarios").InnerText = oCliente.Comentarios;

                    doc.Save(appSettings);
                    break;
                }
            }
        }

        public void Delete(string oID)
        {
            string appSettings = ConfigurationManager.AppSettings["connectionClientes"];

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettings);

            foreach (XmlNode xNode in doc.SelectNodes("clientes/cliente"))
            {
                if (xNode.SelectSingleNode("ID").InnerText == oID)
                {
                    xNode.ParentNode.RemoveChild(xNode);
                }

                doc.Save(appSettings);
            }
        }
        #endregion
    }
}
