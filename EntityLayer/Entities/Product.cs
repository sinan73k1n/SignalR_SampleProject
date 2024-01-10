﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Product
	{
        [Key]
        public int ID_Product { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public string? ImageURL { get; set; }
		public bool Status { get; set; }
	}
}
