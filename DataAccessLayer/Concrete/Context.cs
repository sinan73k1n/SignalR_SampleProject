using System;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	public class Context:DbContext
	{
        string conStr = "server=89.252.180.91\\MSSQLSERVER2012;database= SignalR-Sample-Project;uid=ssoftwar_SignalR-Sample-Project;pwd=Vzqv12?49";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conStr);
        }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<Booking>?  Bookings { get; set; }
        public DbSet<Category>?  Categories { get; set; }
        public DbSet<Contact>?  Contacts { get; set; }
        public DbSet<Discount>?  Discounts { get; set; }
        public DbSet<Feature>?  Features { get; set; }
        public DbSet<Product>?  Products { get; set; }
        public DbSet<SocialMedia>?  SocialMedias { get; set; }
        public DbSet<Testimonial>?  Testimonials { get; set; }
    }
}

