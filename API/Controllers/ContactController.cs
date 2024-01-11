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
    public class ContactController : ControllerBase
    {
        private readonly IContactService  _contactService ;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var val = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(val);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto   createContactDto)
        {
            var val = new Contact()
            {
                FooterDescription = createContactDto.FooterDescription,
                Location = createContactDto.Location,
                Mail = createContactDto.Mail,
                Phone = createContactDto.Phone
            };
            _contactService.TAdd(val);
            return Ok("İletişim Bilgisi Eklendi!");
        }
        [HttpPut]
        public IActionResult UpdateContact( UpdateContactDto  updateContactDto)
        {
            var val = new Contact()
            {
                FooterDescription = updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                Phone = updateContactDto.Phone,
                ID_Contact = updateContactDto.ID_Contact

            };
            _contactService.TUpdate(val);

            return Ok("İtişim Bilgisi Güncellendi!");

        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var val = _contactService.TGetByID(id);
            _contactService.TDelete(val);
            return Ok("İletişim Bilgisi Silindi!");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var val = _contactService.TGetByID(id);
            return Ok(val);
        }
    }

}

