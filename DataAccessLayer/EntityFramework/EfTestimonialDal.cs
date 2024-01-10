using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestimonialDa : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDa(Context context) : base(context)
        {
        }
    }
}

