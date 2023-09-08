using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Districs
    {
        public int ID { get; set; }
        public string Districs_Name { get; set; }
        public int? Provinces_ID { get; set; }
        [ForeignKey(nameof(Provinces_ID))]
        public virtual Provinces Provinces { get; set; }
        public virtual ICollection<Wards> Wards { get; set; }
    }
}
