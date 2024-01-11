using System;
using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace API.Mapping
{
	public class ProductMapping : Profile
	{
		public ProductMapping()
		{
			CreateMap<Product, ResultProductDto>().ReverseMap();
			CreateMap<Product, CreateProductDto>().ReverseMap();
			CreateMap<Product, GetProductDto>().ReverseMap();
			CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
	}
}

