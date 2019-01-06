using _4_FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _4_FirstApplication.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie _movie { get; set; }
        public List<Customer> _customers { get; set; }
    }
}