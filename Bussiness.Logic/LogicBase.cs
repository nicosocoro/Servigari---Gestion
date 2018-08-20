using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Bussines.Entities;
using System.Data;

namespace Bussiness.Logic
{
    public class LogicBase
    {
        public ManejadorArchivoXML _Manejador { get; set; }
        public ManejadorArchivoXML Manejador
        {
            get
            {
                if(_Manejador == null)
                {
                    _Manejador = new ManejadorArchivoXML();
                }

                return _Manejador;
            }
        }

    }
}
