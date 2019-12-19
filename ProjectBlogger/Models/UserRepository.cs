using ProjectBlogger.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectBlogger.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly BloggerContext _bloggerContext;

        public UserRepository(BloggerContext bloggerContext)
        {
            _bloggerContext = bloggerContext;
        }

        public IEnumerable<User> AllUsers => _bloggerContext.TheUsers;

        public User GetBlogByUserId(int userId)
        {
            return _bloggerContext.TheUsers.FirstOrDefault(u => u.UserID == userId);
        }

    }
}
