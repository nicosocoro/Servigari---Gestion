using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Entities
{
    public class MontoEntities
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string ID_Cliente { get; set; }
        public TipoMonto TipoMonto { get; set; }

        public MontoEntities()
        {

        }

        public MontoEntities(TipoMonto pTipoMonto)
        {
            TipoMonto = pTipoMonto;
        }

        public MontoEntities(int pID, string pDescripcion, string Monto, DateTime pFecha, TipoMonto pTipoMonto)
        {
            this.ID = pID;
            this.Descripcion = pDescripcion;
            this.Fecha = pFecha;
            this.TipoMonto = pTipoMonto;
        }
    }

    public enum TipoMonto
    {
        Ingreso,
        Gasto
    }
}
