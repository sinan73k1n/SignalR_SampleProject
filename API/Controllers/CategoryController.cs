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
    public class CategoryController : ControllerBase
    {
      private readonly  ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var val = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
           return Ok(val);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var val = new Category()
            {
                Name = createCategoryDto.Name,
                Status = createCategoryDto.Status
            };
            _categoryService.TAdd(val);
            return Ok("Kategori Eklendi!");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto  updateCategoryDto)
        {
            var val = new Category()
            {
                Name = updateCategoryDto.Name,
                Status = updateCategoryDto.Status,
                 ID_Category=updateCategoryDto.ID_Category
               
            };
            _categoryService.TUpdate(val);

            return Ok("Kategori Güncellendi!");

        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var val = _categoryService.TGetByID(id);
            _categoryService.TDelete(val);
            return Ok("Kategori Silindi!");
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var val = _categoryService.TGetByID(id);
            return Ok(val);
        }
    }
}
