﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Models.Districs
{
    public class UpdateDistric
    {
        public int ID { get; set; }
        public string Districs_Name { get; set; }
        public int? Provinces_ID { get; set; }
    }
}
