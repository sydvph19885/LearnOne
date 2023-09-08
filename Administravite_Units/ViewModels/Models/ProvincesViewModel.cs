using Data.Entity;
using ViewModels.Models;

namespace Administravite_Units.ViewModel
{
    public class ProvincesViewModel
    {
        public int ID { get; set; }
        public string Provinces_Name { get; set; }

        public virtual ICollection<DistrictsViewModels> Districs { get; set; }

    }
    public class Paging
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int totalPages { get; set; }

        public List<ProvincesViewModel> provincesList { get; set; } = new List<ProvincesViewModel>();

    }
}
