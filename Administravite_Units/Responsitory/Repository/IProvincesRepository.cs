using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public interface IProvincesRepository
    {
        List<Provinces> GetAll();

        Provinces GetById(int id);

        void Update(Provinces provinces);

        void Delete(int id);


    }
}
