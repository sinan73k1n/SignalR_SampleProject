using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Feature
	{
        [Key]
        public int ID_Feature { get; set; }
		public string? Title1 { get; set; }
		public string? Descripton1 { get; set; }
		public string? Title2 { get; set; }
		public string? Descripton2 { get; set; }
		public string? Title3 { get; set; }
		public string? Descripton3 { get; set; }
    }
}

