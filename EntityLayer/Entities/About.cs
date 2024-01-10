using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class About
	{
		[Key]
		public int ID_About { get; set; }
		public string? ImageURL { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
    }
}

