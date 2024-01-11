using System;
using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace API.Mapping
{
	public class TestimonialMapping : Profile
	{
		public TestimonialMapping()
		{
			CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
	}
}

