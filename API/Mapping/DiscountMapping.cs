using System;
using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace API.Mapping
{
	public class DiscountMapping : Profile
	{
		public DiscountMapping()
		{
			CreateMap<Discount, ResultDiscountDto>().ReverseMap();
			CreateMap<Discount, CreateDiscountDto>().ReverseMap();
			CreateMap<Discount, GetDiscountDto>().ReverseMap();
			CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        }
	}
}

