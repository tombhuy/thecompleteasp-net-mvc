using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4_FirstApplication.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }


        //Ngày phát hành
        [Required]
        public DateTime ReleaseDate { get; set; }


        //Ngày thêm vào
        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        [Required]
        [Range(0, 20)]
        public int NumberAvailable { get; set; }


        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        




    }
}