using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using online_edu.Entity.Entities;

namespace online_edu.DataAccess.Context
{
	public class online_eduContext:DbContext
	{
        public online_eduContext(DbContextOptions options):base(options) 
        {
            
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategorys { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategorys { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
