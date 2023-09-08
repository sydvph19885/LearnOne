using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Wards
    {
        public int ID { get; set; }
        public string Wards_Name { get; set; }
        public int? Districs_ID { get; set; }
        [ForeignKey(nameof(Districs_ID))]
        public  virtual Districs Districs { get; set; }
    }
}
