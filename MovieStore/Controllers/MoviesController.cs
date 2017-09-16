using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content($"pageIndex={pageIndex},sortBy={sortBy}");
        }

        public ActionResult Random()
        {
            var movie = new Movie { Name="darren"};
            return View(movie);
        }

        //movies/edit/1
        //movies/edit?id=1
        //movies/edit?movieId=1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //http://localhost:49690/movies/released/2015/4
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}