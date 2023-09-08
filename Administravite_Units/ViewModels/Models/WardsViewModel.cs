using Administravite_Units.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Models
{
    public class WardsViewModel
    {
        public int ID { get; set; }
        public string Wards_Name { get; set; }
        public int? Districs_ID { get; set; }
    }
    public class Paging
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int totalPages { get; set; }

        public List<ProvincesViewModel> provincesList { get; set; } = new List<ProvincesViewModel>();

    }
}
