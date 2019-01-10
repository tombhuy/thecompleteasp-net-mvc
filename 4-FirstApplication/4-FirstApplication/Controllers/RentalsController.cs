using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _4_FirstApplication.ViewModels;

namespace _4_FirstApplication.Controllers
{
    public class RentalsController : Controller
    {
        // GET: RentMovie

        public ActionResult New(RentMovieViewModel rentMovieViewModel)
        {
            return View();
        }
    }
}