using System;
using System.Collections.Generic;


namespace ProjectBlogger.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
    }
}
