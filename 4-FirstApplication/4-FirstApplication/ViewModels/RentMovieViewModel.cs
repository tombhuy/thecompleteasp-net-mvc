using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _4_FirstApplication.Models;

namespace _4_FirstApplication.ViewModels
{
    public class RentMovieViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}