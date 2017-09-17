using MovieStore.Models;
using MovieStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStore.Controllers
{
    public class MoviesController : Controller
    {
        #region 练习
        //// GET: Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content($"pageIndex={pageIndex},sortBy={sortBy}");
        //}

        //public ActionResult Random()
        //{
        //    var movie = new Movie { Name="darren"};

        //    var customers = new List<Customer> {
        //        new Customer {Name="customer1" },
        //        new Customer {Name="customer2" }
        //    };

        //    var viewModel = new RandomMovieViewModel {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    //等同于
        //    //var viewReslut = new ViewResult();
        //    //viewReslut.ViewData.Model = movie;

        //    return View(viewModel);
        //}

        ////movies/edit/1
        ////movies/edit?id=1
        ////movies/edit?movieId=1
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        ////http://localhost:49690/movies/released/2015/4
        ////constrains: min, max, minlength, maxlength, int, float, guid
        //// google: ASP.NET MVC Attribute ROute Constraints
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //} 
        #endregion
        
       public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie> {
                new Movie {Id=1,Name="战狼2" },
                new Movie {Id=2,Name="战狼1" }
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie { Name = "darren" };
            var customers = new List<Customer> {
                new Customer {Name="Customer1" },
                new Customer {Name="Customer2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

    }
}