using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectBlogger.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ProjectBlogger.Data
{
    //public class BloggerContext : DbContext THIS IS THE ORIGINAL CLASS STARTER WHICH WORKED 
        public class BloggerContext : IdentityDbContext<IdentityUser>
    {
        public BloggerContext (DbContextOptions<BloggerContext> options)
            : base(options)
        {
        }

        public DbSet<MyBlogs> MyBlogss { get; set; } //terrible pluralization of MyBlogs which was already plural 
        public DbSet<User> TheUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MyBlogs>().ToTable("MyBlogs");
            modelBuilder.Entity<User>().ToTable("User");


            //seed Users
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 2,
                FirstName = "Jody",
                LastName = "Richardson",
                UserName = "JDog",
                Email = "Jody@Jody.com",
                Password = "JodyMcJoderson"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 3,
                FirstName = "Heather",
                LastName = "Smith",
                UserName = "HDog",
                Email = "Heather@Heather.com",
                Password = "HeatherMcHeatherson"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 4,
                FirstName = "Hammad",
                LastName = "Ali",
                UserName = "HADog",
                Email = "Hammad@Hammad.com",
                Password = "HammadMcHammerson"
            });

            //seed Blogs

            modelBuilder.Entity<MyBlogs>().HasData(new MyBlogs
            {
                MyBlogsID = 10,
                BlogName = "How to Code",
                Description = "This is the short Description",
                ActualBlog = "This will be the Blog content",
                ImageUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
                ThumbUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
                BlogOfTheWeek = true,
                UserID = 2
            });
            modelBuilder.Entity<MyBlogs>().HasData(new MyBlogs
            {
                MyBlogsID = 11,
                BlogName = "How NOT to Code",
                Description = "This is the short Description",
                ActualBlog = "This will be the Blog content",
                ImageUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
                ThumbUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
                BlogOfTheWeek = false,
                UserID = 2
            });
            modelBuilder.Entity<MyBlogs>().HasData(new MyBlogs
            {
                MyBlogsID = 12,
                BlogName = "Do you know how to Code?",
                Description = "This is the short Description",
                ActualBlog = "This will be the Blog content",
                ImageUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
                ThumbUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
                BlogOfTheWeek = false,
                UserID = 2
            });


        }


        }
        //public DbSet<ProjectBlogger.Models.MyBlogs> MyBlogs { get; set; }
    }

