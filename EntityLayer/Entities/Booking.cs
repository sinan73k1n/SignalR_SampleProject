﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Booking
	{
		[Key]
		public int ID_Booking { get; set; }
		public string?	 Name { get; set; }
		public string? Phone { get; set; }
		public string? Mail { get; set; }
		public int PersonCount { get; set; }
		public DateTime Date { get; set; }
    }
}

