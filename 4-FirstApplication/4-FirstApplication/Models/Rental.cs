using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4_FirstApplication.Models
{
    public class Rental
    {
        //Code tự nghĩ
        //[Required]
        //public int CustomerId { get; set; }

        //[Required]
        //public int MovieId { get; set; }

        //[Required]
        //public DateTime DateRented { get; set; }

        //[Required]
        //public DateTime DateReturned { get; set; }


        //public Customer Customer { get; set; }
        //public Movie Movie { get; set; }

        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }


        

    }
}