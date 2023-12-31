﻿using Administravite_Units.Helper;
using AutoMapper;
using Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Service;
using Service.Service.impl;
using ViewModels.Models;
using ViewModels.Models.Wards;

namespace Administravite_Units.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardsController : ControllerBase
    {
        private readonly IWardsService _wardsService;
        private readonly IMapper _mapper;

        public WardsController(IWardsService wardsService, IMapper mapper)
        {
            _wardsService = wardsService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get(int? pages = 1, int? pageSize = 5)
        {
            var wards = _wardsService.GetAll();
            var wardsModel = _mapper.Map<List<WardsViewModel>>(wards);
            var result = new Pagination<WardsViewModel>(wardsModel, (int)pages, (int)pageSize);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var ward = _wardsService.GetById(id);
            var wardModel = _mapper.Map<WardsViewModel>(ward);
            return Ok(wardModel);
        }
        [HttpPost]
        public IActionResult Create(CreateWards createWards)
        {
            var ward = _mapper.Map<Wards>(createWards);
            _wardsService.Create(ward);
            return Ok("Add thành công");
        }
        [HttpPut]
        public IActionResult Update(UpdateWards updateWards)
        {
            var ward = _mapper.Map<Wards>(updateWards);
            _wardsService.Update(ward);
            return Ok("Update thành công");
        }
        [HttpGet("search")]
        public IActionResult search(string? name)
        {
            var wards = _wardsService.search(name);
            var wardsModels = _mapper.Map<List<WardsViewModel>>(wards);
            return Ok(wardsModels);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _wardsService.Delete(id);
            return Ok("Xóa thanh công");
        }
    }
}
