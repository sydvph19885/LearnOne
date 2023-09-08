using Administravite_Units.ViewModel;
using Data.Entity;
using Data.Reponsitory;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models.Provinces;

namespace Service.Service
{
    public interface IProvincesService
    {
        List<Provinces> GetAll();

        Provinces GetById(int id);

        //ProvincesViewModel Create(ProvincesViewModel provincesViewModel);
        Provinces Create(Provinces provinces);
        void Update(int id, Provinces provinces);

        void Delete(int id);
        List<Provinces> search(string? name);
        List<Provinces> searchByDistrict(string? name);

    }
}
