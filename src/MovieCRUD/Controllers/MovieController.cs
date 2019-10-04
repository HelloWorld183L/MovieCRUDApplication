using MovieCRUD.Data;
using MovieCRUD.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCRUD.Controllers
{
    public class MovieController : Controller
    {
        private SqlData _data;

        public MovieController()
        {
            _data = new SqlData();
        }

        public ActionResult List()
        {
            var movies = _data.GetAll();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            _data.Create(movie);
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            var movie = _data.Get(id);
            return View(movie);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_data.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Movie editedMovie)
        {
            _data.Edit(editedMovie);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_data.Get(id));
        }

        [HttpPost]
        public ActionResult Delete(Movie movie)
        {
            _data.Delete(movie);
            return RedirectToAction("List");
        }
    }
}