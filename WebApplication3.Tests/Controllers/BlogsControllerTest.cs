using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3;
using WebApplication3.Controllers;
using DAL;

namespace WebApplication3.Tests.Controllers
{
    [TestClass]
    public class BlogsControllerTest
    {
        [TestMethod]
        public void Get_All_Blogs()
        {
            BlogsController controller = new BlogsController(new Initialize());
            ViewResult blogs = controller.Index() as ViewResult;
            Assert.IsNotNull(blogs);
        }

        [TestMethod]
        public void Get_Blog_By_Id()
        {
            var data = new Initialize();
            BlogsController controller = new BlogsController(data);
            ViewResult blog = controller.Details(data.Get().First().BlogId) as ViewResult;
            Assert.IsNotNull(blog);
        }
    }
}
