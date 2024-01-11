using System;
using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace API.Mapping
{
	public class ContactMapping : Profile
	{
		public ContactMapping()
		{
			CreateMap<Contact, ResultContactDto>().ReverseMap();
			CreateMap<Contact, CreateContactDto>().ReverseMap();
			CreateMap<Contact, GetContactDto>().ReverseMap();
			CreateMap<Contact, UpdateContactDto>().ReverseMap();
        }
	}
}

