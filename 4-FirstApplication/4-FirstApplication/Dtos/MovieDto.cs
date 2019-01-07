using _4_FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4_FirstApplication.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //Ngày phát hành
        [Required]
        public DateTime ReleaseDate { get; set; }

        //Ngày thêm vào
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

    }
}