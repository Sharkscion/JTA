using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Supplier : Person
    {
        public virtual int TIN { get; set; }
        public virtual Terms Terms { get; set; }
        public virtual Status Status { get; set; }
        public virtual string Note { get; set; }

        public virtual IList<Document> Documents { get; set; }

        public Supplier()
        {
            Documents = new List<Document>();
        }

      
    }
}
