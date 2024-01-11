using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BussinessLayer.Abstract;
using DtoLayer.AboutDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService  _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var val = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(val);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var val = new Feature()
            {
                Descripton1 = createFeatureDto.Descripton1,
                Descripton2 = createFeatureDto.Descripton2,
                Descripton3 = createFeatureDto.Descripton3,
                Title1 = createFeatureDto.Title1,
                Title2 = createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3
            };
            _featureService.TAdd(val);
            return Ok("Öne Çıkan Bilgisi Eklendi!");
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var val = new Feature()
            {
                Descripton1 = updateFeatureDto.Descripton1,
                Descripton2 = updateFeatureDto.Descripton2,
                Descripton3 = updateFeatureDto.Descripton3,
                Title1 = updateFeatureDto.Title1,
                Title2 = updateFeatureDto.Title2,
                Title3 = updateFeatureDto.Title3,
                 ID_Feature= updateFeatureDto.ID_Feature

            };
            _featureService.TUpdate(val);

            return Ok("Öne Çıkan Bilgisi Güncellendi!");

        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var val = _featureService.TGetByID(id);
            _featureService.TDelete(val);
            return Ok("Öne Çıkan Bilgisi Silindi!");
        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var val = _featureService.TGetByID(id);
            return Ok(val);
        }
    }
}

