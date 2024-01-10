using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Contact
	{
        [Key]
        public int  ID_Contact { get; set; }
		public string?	  Location { get; set; }
		public string?	  Phone { get; set; }
		public string?	  Mail { get; set; }
		public string?	  FooterDescription { get; set; }
    }
}

