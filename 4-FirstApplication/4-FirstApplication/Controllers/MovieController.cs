using _4_FirstApplication.Models;
using  System.Data.Entity;
using _4_FirstApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_FirstApplication.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
                _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shark"
            };

            var customers = new List<Customer>
            {
                new Customer {Name="huy" },
                new Customer {Name="hoang" }
            };

            var randomMovieViewModel = new RandomMovieViewModel
            {
                _movie=movie,
                _customers=customers
            };

            return View(randomMovieViewModel);
        }



        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");


            return View("ReadOnlyList");
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).Where(m => m.Id == id).SingleOrDefault();
            if (movie == null)
                return HttpNotFound();
            return View("Details", movie);
        }



        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            ViewBag.Title = "New Movie";
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie
                {
                    ReleaseDate = DateTime.Now
                },
                Genres = genres
            };


            return View("MovieForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            else
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
                ViewBag.Title = "Edit Movie";
                return View("MovieForm", viewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }              
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock  = movie.NumberInStock;
                movieInDb.NumberAvailable = movie.NumberAvailable;

            }

            _context.SaveChanges();
            return RedirectToAction("Index","Movie");
        }



        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));
        //}


        //[Route("movie/release/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int month,int year)
        //{
        //    return Content(String.Format("{0}/{1}", month, year));
        //}
    }
}