using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.Entities;
using Database.Clientes;

namespace Bussiness.Logic.Clientes
{
    public class ClienteLogic : LogicBase
    {
        private ClientesAdapter _cliAdapter;
        public ClientesAdapter ClienteAdapter
        {
            get
            {
                if (_cliAdapter == null)
                    _cliAdapter = new ClientesAdapter();

                return _cliAdapter;
            }

            set
            {
                _cliAdapter = value;
            }
        }

        public ClientesEntity GetCliente_ID(string oID)
        {
            ClientesEntity cli = new ClientesEntity();
            DataTable dtClientes = ClienteAdapter.GetAllClientes();

            foreach (DataRow dr in dtClientes.Rows)
            {
                if (dr["ID"].ToString() == oID)
                {
                    cli.ID = oID;
                    cli.Nombre = dr[1].ToString();
                    cli.Apellido = dr[2].ToString();
                    cli.TelefonoFijo = dr[3].ToString();
                    cli.TelefonoCelular = dr[4].ToString();
                    cli.TelefonoAlternativo = dr[5].ToString();
                    cli.Direccion = dr[6].ToString();
                    cli.Comentarios = dr[7].ToString();
                    cli.FechaAlta = dr[8].ToString();

                    return cli;
                }
            }

            throw new Exception("No existe ningún cliente registrado con el ID " + oID);
        }

        public DataTable GetClientes()
        {
            return ClienteAdapter.GetClientes();
        }

        public string GetLastID()
        {
            return ClienteAdapter.GetLastID();
        }

        #region METODOS SAVE
        public void Save(ClientesEntity oCliente, Utiles.AccionEnum.TipoAccion tipoAccion)
        {
            switch (tipoAccion)
            {
                case Utiles.AccionEnum.TipoAccion.Add:
                    this.Add(oCliente);
                    break;

                case Utiles.AccionEnum.TipoAccion.Modify:
                    this.Modify(oCliente);
                    break;

                case Utiles.AccionEnum.TipoAccion.Delete:
                    this.Delete(oCliente.ID);
                    break;

                default:
                    throw new Exception("Error en acceso para recuperar datos de la base de datos. Contacte con sistemas.");

            }
        }

        public void Save(string oID)
        {
            Delete(oID);
        }

        private void Add(ClientesEntity oCliente)
        {
            ClienteAdapter.Add(oCliente);
        }

        private void Modify(ClientesEntity oCliente)
        {
            ClienteAdapter.Modify(oCliente);
        }

        private void Delete(string oID)
        {
            ClienteAdapter.Delete(oID);
        }
        #endregion
    }
}
