using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Entities
{
    public class RecordEntity
    {
        public int ID_Record { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int ID_Record_Type { get; set; }
        public int ID_Type { get; set; }
    }
}
