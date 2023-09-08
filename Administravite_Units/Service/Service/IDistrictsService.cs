using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Service.Service
{
    public interface IDistrictsService
    {
        List<Districs> GetAll();

        Districs GetById(int id);

        Districs Update(Districs districs);

        void Delete(int id);
        Districs Create(Districs districs);

        List<Districs> search(string? name);

    }
}
