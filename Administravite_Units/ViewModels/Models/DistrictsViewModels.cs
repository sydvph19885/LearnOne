﻿using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Models
{
    public class DistrictsViewModels
    {
        public int ID { get; set; }
        public string Districs_Name { get; set; }
        public int? Provinces_ID { get; set; }

        public virtual ICollection<WardsViewModel> Wards { get; set; }
    }
}
