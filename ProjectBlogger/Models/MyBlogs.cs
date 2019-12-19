using System;


namespace ProjectBlogger.Models
{
    public class MyBlogs
    {
        //primary key by default 
        public int MyBlogsID { get; set; }

        public string BlogName { get; set; }

        public string Description { get; set; }

        public string ActualBlog { get; set; }

        public string ImageUrl { get; set; }

        public string ThumbUrl { get; set; }

        public bool BlogOfTheWeek { get; set; }

        //this is a foreign key 
        public int UserID { get; set; }

        //this is the corresponding navigation property for the UserID(foreign key)
        //A blog is associated with one User entity so the property contains a singe User entity
        public User User { get; set; }

    }
}
