using System;
namespace DtoLayer.AboutDto
{
	public class GetDiscountDto
    {
        public int ID_Discount { get; set; }
        public string? Title { get; set; }
        public string? Amount { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
    }
}

