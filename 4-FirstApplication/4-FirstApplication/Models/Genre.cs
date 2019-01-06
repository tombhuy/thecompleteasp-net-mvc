﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4_FirstApplication.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}