using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Testimonial
	{
        [Key]
        public int ID_Testimonial { get; set; }
		public string? Name	 { get; set; }
		public string? Title	 { get; set; }
		public string? Comment	 { get; set; }
		public string? ImageURL	 { get; set; }
		public bool Status	 { get; set; }
    }
}

