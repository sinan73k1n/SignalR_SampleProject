﻿using System;
using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace API.Mapping
{
	public class SocialMediaMapping : Profile
	{
		public SocialMediaMapping()
		{
			CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
			CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
			CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
			CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        }
	}
}

