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
    public class Iniciador: LogicBase
    {
        public void CheckNodeTipo()
        {
            Manejador.CheckNodeTipo();   
        }
    }
}
