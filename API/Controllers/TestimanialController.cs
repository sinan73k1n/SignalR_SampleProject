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
    public class TestimanialController : ControllerBase
    {
        private readonly ITestimonialService  _testimonialService;
        private readonly IMapper _mapper;

        public TestimanialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var val = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(val);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var val = new Testimonial()
            {
                Comment = createTestimonialDto.Comment,
                ImageURL = createTestimonialDto.ImageURL,
                Name = createTestimonialDto.Name,
                Status = createTestimonialDto.Status,
                Title = createTestimonialDto.Title
            };
            _testimonialService.TAdd(val);
            return Ok("Müşteri Yorum Bilgisi Eklendi!");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var val = new Testimonial()
            {
                Comment = updateTestimonialDto.Comment,
                ImageURL = updateTestimonialDto.ImageURL,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title,
                 ID_Testimonial=updateTestimonialDto.ID_Testimonial

            };
            _testimonialService.TUpdate(val);

            return Ok("Müşteri Yorum Bilgisi Güncellendi!");

        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var val = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(val);
            return Ok("Müşteri Yorum Bilgisi Silindi!");
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var val = _testimonialService.TGetByID(id);
            return Ok(val);
        }
    }
}

