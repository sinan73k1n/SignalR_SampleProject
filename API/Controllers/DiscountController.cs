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
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService  _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var val = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(val);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto )
        {
            var val = new Discount()
            {
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                ImageURL = createDiscountDto.ImageURL,
                Title = createDiscountDto.Title
            };
            _discountService.TAdd(val);
            return Ok("İndirim Eklendi!");
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var val = new Discount()
            {
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                ImageURL = updateDiscountDto.ImageURL,
                Title = updateDiscountDto.Title,
                ID_Discount = updateDiscountDto.ID_Discount

            };
            _discountService.TUpdate(val);

            return Ok("İndirim Güncellendi!");

        }

        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var val = _discountService.TGetByID(id);
            _discountService.TDelete(val);
            return Ok("İndirim Silindi!");
        }

        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var val = _discountService.TGetByID(id);
            return Ok(val);
        }
    }

}
}

