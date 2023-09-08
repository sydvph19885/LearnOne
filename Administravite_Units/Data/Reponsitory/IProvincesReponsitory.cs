using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Reponsitory
{
    public interface IProvincesReponsitory
    {
        List<Provinces> GetAll();

        Provinces GetById(int id);

        Provinces Create(Provinces provinces);
        void Update(Provinces provinces);

        void Delete(int id);

        List<Provinces> search(string name);

        List<Provinces> searchByDistrict(string? name);
    }
}
