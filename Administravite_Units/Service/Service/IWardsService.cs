using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IWardsService
    {
        List<Wards> GetAll();
        Wards GetById(int id);
        void Create(Wards wards);
        void Update(Wards wards);
        List<Wards> search(string? name);

        void Delete(int id);
    }
}
