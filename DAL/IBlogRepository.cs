using System;
namespace DAL
{
    public interface IBlogRepository
    {
        Blog Add(Blog blog);
        bool Delete(Guid BlogId);
        System.Collections.Generic.IEnumerable<Blog> Get();
        Blog GetById(Guid BlogId);
        bool Update(Blog blog);
    }
}
