﻿using System;
using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace API.Mapping
{
	public class BookingMapping : Profile
	{
		public BookingMapping()
		{
			CreateMap<Booking, ResultBookingDto>().ReverseMap();
			CreateMap<Booking, CreateBookingDto>().ReverseMap();
			CreateMap<Booking, GetBookingDto>().ReverseMap();
			CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
	}
}

