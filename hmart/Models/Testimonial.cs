﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 200)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Position { get; set; }

        [Required]
        [StringLength(maximumLength: 600)]
        public string Desc { get; set; }

        public int Order { get; set; }
    }
}
