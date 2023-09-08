
using Data.Entity;
using Data.Reponsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Service.Service.impl
{
    public class DistrictsService : IDistrictsService
    {
        private IDistrictsReponsitory districtsReponsitory;

        public DistrictsService(IDistrictsReponsitory districtsReponsitory)
        {
            this.districtsReponsitory = districtsReponsitory;
        }

        public Districs Create(Districs districs)
        {
            districtsReponsitory.Create(districs);
            return districs;
        }

        public void Delete(int id)
        {
            districtsReponsitory.Delete(id);
        }

        public List<Districs> GetAll()
        {
            return districtsReponsitory.GetAll();
        }

        public Districs GetById(int id)
        {
            var distric = districtsReponsitory.GetById(id);
            if (distric != null)
            {
                return distric;
            }
            return null;
        }

        public List<Districs> search(string? name)
        {
            if(!string.IsNullOrEmpty(name))
            {
               var listDistricts = districtsReponsitory.search(name);
                return listDistricts;
            }
            return GetAll();
        }

        public Districs Update(Districs districs)
        {
            districtsReponsitory.Update(districs);
            return districs;
        }
    }
}
