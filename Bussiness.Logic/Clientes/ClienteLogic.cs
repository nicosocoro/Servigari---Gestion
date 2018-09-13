using System;
using System.Collections.Generic;
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
        }

        //public ClientesEntity GetCliente(int ID)
        //{

        //}

        //public void Save()

        public int GetLastID()
        {
            return 1;
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

        public void Add(ClientesEntity oCliente)
        {
            ClienteAdapter.Add(oCliente);
        }

        public void Modify(ClientesEntity oCliente)
        {
            ClienteAdapter.Modify(oCliente);
        }

        public void Delete(int oID)
        {
            ClienteAdapter.Delete(oID);
        }
        #endregion
    }
}
