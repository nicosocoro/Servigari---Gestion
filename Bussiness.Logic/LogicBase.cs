using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.Entities;
using System.Data;
using Database;
using Database.Clientes;
using Database.Registros;

namespace Bussiness.Logic
{
    public class LogicBase
    {
        public RecordAdapter _RecordManejador { get; set; }
        public RecordAdapter RecordManejador
        {
            get
            {
                if(_RecordManejador == null)
                {
                    _RecordManejador = new RecordAdapter();
                }

                return _RecordManejador;
            }
        }

        public TiposAdapter _TiposManejador { get; set; }
        public TiposAdapter TiposManejador
        {
            get
            {
                if (_TiposManejador == null)
                {
                    _TiposManejador = new TiposAdapter();
                }

                return _TiposManejador;
            }
        }

        
    }
}
