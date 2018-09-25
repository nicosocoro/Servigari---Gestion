using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Entities
{
    public class ClientesEntity
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoAlternativo { get; set; }
        public string Direccion { get; set; }
        public string Comentarios { get; set; }
        public string FechaAlta { get; set; }
    }
}
