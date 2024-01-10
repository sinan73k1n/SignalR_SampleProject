using System;
namespace DtoLayer.AboutDto
{
	public class ResultBookingDto
    {
        public int ID_Booking { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}

