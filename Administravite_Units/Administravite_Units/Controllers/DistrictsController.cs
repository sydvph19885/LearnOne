﻿using Administravite_Units.Helper;
using AutoMapper;
using Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Service;
using System.Linq;
using ViewModels.Models;
using ViewModels.Models.Districs;

namespace Administravite_Units.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly IDistrictsService _districtsService;
        private readonly IMapper _mapper;

        //private readonly IMapper _mapper;

        public DistrictsController(IDistrictsService districtsService, IMapper mapper)
        {
            _districtsService = districtsService;
            _mapper = mapper;
        }
        [HttpGet]
        public Pagination<DistrictsViewModels> GetAll(int? pages = 1,int? pageSize =5)
        {
            var districts = _districtsService.GetAll();
            var districtsModel = _mapper.Map<List<DistrictsViewModels>>(districts);
            var result = new Pagination<DistrictsViewModels>(districtsModel,(int)pages,(int)pageSize);
            return result;
        }
        [HttpGet("{id}")]
        public DistrictsViewModels GetById(int id)
        {
            var district = _districtsService.GetById(id);
            var districtsModel = _mapper.Map<DistrictsViewModels>(district);
            return districtsModel;
        }
        [HttpPost]
        public IActionResult Create(CreateDistric districCreate)
        {
            var districtCreate = _mapper.Map<Districs>(districCreate);
            _districtsService.Create(districtCreate);
            return Ok("Add thanh cong");
        }
        [HttpPut]
        public IActionResult Update(UpdateDistric districUpdate)
        {
            var districtUpdate = _mapper.Map<Districs>(districUpdate);
            _districtsService.Update(districtUpdate);
            return Ok("Update thanh cong");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var districs = _districtsService.GetById(id);
            if (districs != null)
            {
                _districtsService.Delete(id);
                return Ok("Xoa thanh cong");
            }
            return NotFound();
        }
        [HttpGet("search")]
        public IActionResult search(string? name)
        {
            var search = _districtsService.search(name);
            var districtsModel = _mapper.Map<List<DistrictsViewModels>>(search);
            return Ok(districtsModel);
        }
    }
}
