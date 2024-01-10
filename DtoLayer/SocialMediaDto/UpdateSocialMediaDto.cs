using System;
namespace DtoLayer.AboutDto
{
	public class UpdateSocialMediaDto
    {
        public int ID_SocialMedia { get; set; }
        public string? Title { get; set; }
        public string? URL { get; set; }
        public string? Icon { get; set; }
    }
}

