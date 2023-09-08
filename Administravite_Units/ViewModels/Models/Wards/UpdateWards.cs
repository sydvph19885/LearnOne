using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Models.Wards
{
    public class UpdateWards
    {
        public int ID { get; set; }
        public string Wards_Name { get; set; }
        public int? Districs_ID { get; set; }
    }
}
