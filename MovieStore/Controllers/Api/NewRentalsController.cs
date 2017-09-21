using MovieStore.Models;
using MovieStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieStore.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //以下是防御的写法
        //CustomerID如果invalid呢
        //没有MoiveID呢
        //一个或多个MoveId无效呢
        //movie是否存在
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            try
            {
                //判断参数中集合的数量
                if (newRental.MovieIds.Count == 0)
                    return BadRequest("no movie ids have been given");


                //判断参数中用户是否存在
                //获取用户
                var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CusotmerId);

                if (customer == null)
                    return BadRequest("customer id is not valid");

                //如果参数中集合数量和获取到的集合数量有关系，需要比较一下
                //获取所有电影
                var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

                if (movies.Count != newRental.MovieIds.Count)
                    return BadRequest("one or more movieids are invalid");

                foreach (var movie in movies)
                {
                    //判断值的边界值
                    if (movie.NumberAvailable == 0)
                        return BadRequest("movie is not available");

                    movie.NumberAvailable--;

                    var rental = new Rental
                    {
                        Customer = customer,
                        Movie = movie,
                        DateRented = DateTime.Now
                    };

                    _context.Rentals.Add(rental);
                }

                _context.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region 乐观写法

        //以下是乐观写法
        //[HttpPost]
        //public IHttpActionResult OptimisticCreate(NewRentalDto newRentalDto)
        //{
        //    var customer = _context.Customers.Single(c => c.Id == newRentalDto.CusotmerId);
        //    var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

        //    foreach (var movie in movies)
        //    {
        //        if (movie.NumberAvailable == 0)
        //            return BadRequest("movie is not available");
        //        movie.NumberAvailable--;

        //        var rental = new Rental
        //        {
        //            Customer = customer,
        //            Movie = movie,
        //            DateRented = DateTime.Now
        //        };

        //        _context.Rentals.Add(rental);
        //    }

        //    _context.SaveChanges();

        //    return Ok();

        //} 
        #endregion
    }
}
