﻿using Administravite_Units.Helper;
using Administravite_Units.ViewModel;
using AutoMapper;
using Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Service;
using System.Linq;
using ViewModels.Models;
using ViewModels.Models.Provinces;

namespace Administravite_Units.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : ControllerBase
    {
        private IProvincesService _provincesService;
        private readonly IMapper _mapper;

        public ProvincesController(IProvincesService provincesService, IMapper mapper)
        {
            _provincesService = provincesService;
            _mapper = mapper;
        }


        [HttpGet]
        public Pagination<ProvincesViewModel> GetAll(int? pages = 1,int? pageSize=5)
        {
            var provinces = _provincesService.GetAll();
            var mapper = _mapper.Map<List<ProvincesViewModel>>(provinces);
            var paging = new Pagination<ProvincesViewModel>(mapper, (int)pages,(int)pageSize);
            return paging;

        }
        [HttpGet("{id}")]
        public ActionResult<ProvincesViewModel> GetById(int id)
        {
            var provinces = _provincesService.GetById(id);
            return _mapper.Map<ProvincesViewModel>(provinces);
        }

        [HttpGet("search")]
        public List<ProvincesViewModel> search(string? name)
        {
            var search = _provincesService.search(name);
            var provincesViewModels = _mapper.Map<List<ProvincesViewModel>>(search);
            int count = search.Count();
            return provincesViewModels.ToList();
        }

        [HttpPost]
        public IActionResult Post(CreateProvinces createModel)
        {
            var province = _mapper.Map<Provinces>(createModel);
            _provincesService.Create(province);
            return Ok("Add thành công");
        }

        [HttpPut("{id}")]
        public IActionResult Pust(int id, UpdateProvinces updateModel)
        {
            if (id == updateModel.ID)
            {
                var province = _mapper.Map<Provinces>(updateModel);
                _provincesService.Update(id, province);
                return Ok("Update thành công");
            }
            return BadRequest();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var provinces = _provincesService.GetById(id);
            if (provinces != null)
            {
                _provincesService.Delete(id);
                return Ok("Xoa thành công");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("Search-By-Districts")]
        public IActionResult searchByDistrictName(string? name)
        {
            var search = _provincesService.searchByDistrict(name);
            var provinces = _mapper.Map<List<ProvincesViewModel>>(search);
            return Ok(provinces);
        }
    }
}
