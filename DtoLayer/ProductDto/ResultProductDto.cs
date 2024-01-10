using System;
namespace DtoLayer.AboutDto
{
	public class ResultProductDto
    {
        public int ID_Product { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }
        public bool Status { get; set; }
    }
}

