using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class SocialMedia
	{
        [Key]
        public int ID_SocialMedia { get; set; }
		public string? Title { get; set; }
		public string? URL	 { get; set; }
		public string? Icon { get; set; }
    }
}

