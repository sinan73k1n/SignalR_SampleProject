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
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService  _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var val = _mapper.Map<List<ResultDiscountDto>>(_socialMediaService.TGetListAll());
            return Ok(val);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto  createSocialMediaDto)
        {
            var val = new SocialMedia()
            {
                Icon = createSocialMediaDto.Icon,
                Title = createSocialMediaDto.Title,
                URL = createSocialMediaDto.URL
            };
            _socialMediaService.TAdd(val);
            return Ok("Sosyal Medya Eklendi!");
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateSocialMediaDto  updateSocialMediaDto)
        {
            var val = new SocialMedia()
            {
                Icon = updateSocialMediaDto.Icon,
                Title = updateSocialMediaDto.Title,
                URL = updateSocialMediaDto.URL,
                ID_SocialMedia = updateSocialMediaDto.ID_SocialMedia

            };
            _socialMediaService.TUpdate(val);

            return Ok("Sosyal Medya Güncellendi!");

        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var val = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(val);
            return Ok("Sosyal Medya Silindi!");
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var val = _socialMediaService.TGetByID(id);
            return Ok(val);
        }
    }
}


