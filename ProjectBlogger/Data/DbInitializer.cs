using System;
using ProjectBlogger.Data;
using ProjectBlogger.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBlogger.Data
{
    public class DbInitializer
    {
        public static void Initialize(BloggerContext context)
        {
            context.Database.EnsureCreated();

            ////Look for any MyBlogs(plural).
            //if (context.MyBlogss.Any())
            //    {
            //        return;   // DB has been seeded
            //    }

            ////this hasn't worked for some reason! 

            //var myBlogss = new MyBlogs[]
            //{
            //    new MyBlogs{
            //        BlogName = "How to Code",
            //        Description = "This is the short Description",
            //        ActualBlog  = "This will be the Blog content",
            //        ImageUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
            //        ThumbUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
            //        BlogOfTheWeek = true,
            //        UserID = 2
            //        },
            //     new MyBlogs{
            //        BlogName = "How NOT to Code",
            //        Description = "This is the short Description",
            //        ActualBlog = "This will be the Blog content",
            //        ImageUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
            //        ThumbUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
            //        BlogOfTheWeek = false,
            //        UserID = 2
            //        },
            //     new MyBlogs{
            //        BlogName = "Do you know how to Code?",
            //        Description = "This is the short Description",
            //        ActualBlog = "This will be the Blog content",
            //        ImageUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
            //        ThumbUrl = "https://cdn.wearecodenation.com/app/uploads/Dan.jpg",
            //        BlogOfTheWeek = false,
            //        UserID = 2
            //        },
            //};

            //foreach (MyBlogs b in myBlogss)
            //{
            //    context.MyBlogss.Add(b);
            //}
            //context.SaveChanges();


            //var users = new User[]
            //{
            //    new User{
            //    FirstName = "Jody",
            //    LastName = "Richardson",
            //    UserName = "JDog",
            //    Email = "Jody@Jody.com",
            //    Password = "JodyMcJoderson"
            //    },
            //    new User{
            //    FirstName = "Heather",
            //    LastName = "Smith",
            //    UserName = "HDog",
            //    Email = "Heather@Heather.com",
            //    Password = "HeatherMcHeatherson"
            //    },
            //     new User{
            //    FirstName = "Hammad",
            //    LastName = "Ali",
            //    UserName = "HADog",
            //    Email = "Hammad@Hammad.com",
            //    Password = "HammadMcHammerson"
            //    },
            //};
            //foreach (User u in users)
            //{
            //    context.Users.Add(u);
            //}
            //context.SaveChanges();
        }
    }
}
