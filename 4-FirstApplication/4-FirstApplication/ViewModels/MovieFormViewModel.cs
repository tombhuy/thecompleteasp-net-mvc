using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _4_FirstApplication.Models;

namespace _4_FirstApplication.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}