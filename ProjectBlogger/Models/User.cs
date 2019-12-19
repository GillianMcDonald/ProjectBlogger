using System;
using System.Collections.Generic;

namespace ProjectBlogger.Models
{
    public class User
    {
        //primary key by default
        public int UserID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        //this is a navigation property.  It holds other entities that are related to this entity.  
        //the Blog property of User holds all of the Blog entities that are related to the User.
        //as there can be multiple blogs per user the property is defined as ICollection.  EF core creates a HashSet collection by default. 
        public ICollection<MyBlogs> MyBlogs { get; set; }

       
    }
}
