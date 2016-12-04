using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class BlogRepository : DAL.IBlogRepository
    {
        Dictionary<Guid, Blog> blogs = new Dictionary<Guid, Blog>();

        public IEnumerable<Blog> Get()
        {
            return blogs.Values.OrderBy(blog => blog.Created);
        }

        public Blog GetById(Guid BlogId)
        {
            return blogs[BlogId];
        }

        public Blog Add(Blog blog)
        {
            blog.BlogId = Guid.NewGuid();
            blogs[blog.BlogId] = blog;
            return blog;
        }

        public bool Delete(Guid BlogId)
        {
            return blogs.Remove(BlogId);
        }

        public bool Update(Blog blog)
        {
            bool update = blogs.ContainsKey(blog.BlogId);
            blogs[blog.BlogId] = blog;
            return update;
        }
    }
}