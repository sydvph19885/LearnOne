using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Provinces
    {
        public int ID { get; set; }
        public string Provinces_Name { get; set; }
        public virtual ICollection<Districs> Districs { get; set; }
    }
}
