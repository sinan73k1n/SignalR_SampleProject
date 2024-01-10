using System;
namespace DtoLayer.AboutDto
{
	public class GetContactDto
    {
        public int ID_Contact { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? FooterDescription { get; set; }
    }
}

