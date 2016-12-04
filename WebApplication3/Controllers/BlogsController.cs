using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class BlogsController : Controller
    {
        private IBlogRepository repository;

        public BlogsController(IBlogRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View(this.repository.Get());
        }

        public ActionResult Details(Guid id)
        {
            return View(repository.GetById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog collection)
        {
            try
            {
                repository.Add(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(Guid id)
        {

            return View(repository.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Blog collection)
        {
            try
            {
                repository.Update(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {
            return View(repository.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteOk(Guid id)
        {
            try
            {
                repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
