using Administravite_Units.ViewModel;
using Data.Entity;
using Data.Reponsitory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models.Provinces;

namespace Service.Service.impl
{
    public class ProvincesService : IProvincesService
    {
        private IProvincesReponsitory _provincesReponsitory;
        public ProvincesService(IProvincesReponsitory provincesReponsitory)
        {
            _provincesReponsitory = provincesReponsitory;
        }


        public Provinces Create(Provinces provinces)
        {
            _provincesReponsitory.Create(provinces);
            return provinces;
        }

        public void Delete(int id)
        {
            _provincesReponsitory.Delete(id);
        }

        public List<Provinces> GetAll()
        {
            return _provincesReponsitory.GetAll();
        }

        public Provinces GetById(int id)
        {
            return _provincesReponsitory.GetById(id);


        }

        public List<Provinces> search(string? name)
        {
            if (!string.IsNullOrEmpty(name))
            {
              return _provincesReponsitory.search(name);
            }
            return GetAll();
        }

        public void Update(int id, Provinces provinces)
        {

            _provincesReponsitory.Update(provinces);
        }
    }
}
