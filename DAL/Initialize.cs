using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Initialize : BlogRepository
    {
        public Initialize()
        {
            Add(new Blog
            {
                Name = "Admin",
                Creator = "veljkovic.nenad@gmail.com",
                BlogBody = "Sample body text",
                Created = DateTime.Now,
                Active = true
            });
        }
    }
}