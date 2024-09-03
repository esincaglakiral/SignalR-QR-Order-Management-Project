using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        private readonly SignalRContext _context;
        public EfTestimonialDal(SignalRContext context) : base(context)
        {
            _context = context;
        }

        public void ActivateTestimonial(int id)
        {
            var testimonial = _context.Testimonials.FirstOrDefault(t => t.TestimonialID == id);
            if (testimonial != null)
            {
                testimonial.Status = true;
                _context.SaveChanges();
            }
        }

        public void DeActivateTestimonial(int id)
        {
            var testimonial = _context.Testimonials.FirstOrDefault(t => t.TestimonialID == id);
            if (testimonial != null)
            {
                testimonial.Status = false;
                _context.SaveChanges();
            }
        }
    }
}
