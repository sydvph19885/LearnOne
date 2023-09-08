using Data.Entity;
using Data.Reponsitory;
using Data.Reponsitory.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.impl
{
    public class WardsService : IWardsService
    {
        private readonly IWardsReponsitory _wardsReponsitory;

        public WardsService(IWardsReponsitory wardsReponsitory)
        {
            _wardsReponsitory = wardsReponsitory;
        }
        public void Create(Wards wards)
        {
            _wardsReponsitory.Create(wards);
        }

        public void Delete(int id)
        {
            var ward = _wardsReponsitory.GetById(id);
            if (ward != null)
            {
                _wardsReponsitory.Delete(id);
            }
        }

        public List<Wards> GetAll()
        {
            return _wardsReponsitory.GetAll();
        }

        public Wards GetById(int id)
        {
            var ward = _wardsReponsitory.GetById(id);
            if (ward == null)
            {
                return null;
            }
            return ward;
        }

        public List<Wards> search(string? name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return _wardsReponsitory.search(name);
            }
            return GetAll();
        }

        public void Update(Wards wards)
        {
            _wardsReponsitory.Update(wards);
        }
    }
}
