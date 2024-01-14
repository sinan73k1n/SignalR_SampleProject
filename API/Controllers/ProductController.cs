using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BussinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DtoLayer.AboutDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var val = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(val);
        }
        [HttpGet("GetProductListWithCategory")]
        public IActionResult GetProductListWithCategory()
        {
            var context = new Context();
            var val = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategoryDto
            {
                CategoryName = y.Category == null ? "Değer Yok" : y.Category.Name,
                Name = y.Name,
                Description = y.Description,
                ID_Product = y.ID_Product,
                ImageURL = y.ImageURL,
                Price = y.Price,
                Status = y.Status

            });
            return Ok(val.ToList());
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            var val = new Product()
            {
                Description = createProductDto.Description,
                ImageURL = createProductDto.ImageURL,
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                Status = createProductDto.Status
            };
            _productService.TAdd(val);
            return Ok("Ürün Eklendi!");
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto )
        {
            var val = new Product()
            {
                Description = updateProductDto.Description,
                ImageURL = updateProductDto.ImageURL,
                Name = updateProductDto.Name,
                Price = updateProductDto.Price,
                Status = updateProductDto.Status,
                ID_Product = updateProductDto.ID_Product

            };
            _productService.TUpdate(val);

            return Ok("Ürün Güncellendi!");

        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var val = _productService.TGetByID(id);
            _productService.TDelete(val);
            return Ok("Ürün Silindi!");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var val = _productService.TGetByID(id);
            return Ok(val);
        }
    }
}

