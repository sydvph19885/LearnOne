using Administravite_Units.ViewModel;
using AutoMapper;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;
using ViewModels.Models.Districs;
using ViewModels.Models.Provinces;
using ViewModels.Models.Wards;

namespace Service.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Provinces, ProvincesViewModel>().ReverseMap();
            CreateMap<CreateProvinces, Provinces>();
            CreateMap<UpdateProvinces, Provinces >();
            CreateMap<Districs, DistrictsViewModels>().ReverseMap();
            CreateMap<CreateDistric, Districs>();
            CreateMap<UpdateDistric, Districs>();
            CreateMap<WardsViewModel,Wards>().ReverseMap();
            CreateMap<CreateWards, Wards>();
            CreateMap<UpdateWards, Wards>();
        }
    }
}
