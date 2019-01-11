using _4_FirstApplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _4_FirstApplication.Models;

namespace _4_FirstApplication.Controllers.api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
                _context=new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //Huy viết

            //var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            //if (customer == null)
            //    return BadRequest();

            //foreach (var movieid in newRental.MovieIds)
            //{
            //    Movie movie = new Movie();
            //    movie = _context.Movies.SingleOrDefault(m=>m.Id==movieid);
            //    if (movie == null)
            //        return BadRequest();

            //    var newRent = new Rental
            //    {
            //        Customer = customer,
            //        Movie = movie,
            //        DateRented = DateTime.Now
            //    };
            //    _context.Rentals.Add(newRent);
            //}
            //_context.SaveChanges();

            //return Ok();


            //-Thầy viết
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            //IsDelinquentOnPayment

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
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
    }
}
