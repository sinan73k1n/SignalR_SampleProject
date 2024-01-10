using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Category
	{
        [Key]
        public int ID_Category { get; set; }
		public string? Name { get; set; }
		public bool Status { get; set; }
    }
}

