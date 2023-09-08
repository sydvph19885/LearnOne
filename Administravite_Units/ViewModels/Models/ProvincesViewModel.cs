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
}
