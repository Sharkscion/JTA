using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Status
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual string Color { get; set; }
    }
}
