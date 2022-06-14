using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]  //not allow null
        [StringLength(255)]
        public string Name { get; set; }
        public GenreDto Genre { get; set; }

        //[Display(Name = "Genre")]
        [Required]
        public Byte GenreId { get; set; }

        //[Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        //[Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        //[Display(Name = "Number In Stock")]
        //[Range(1, 20)]
        public Byte NumberInStock { get; set; }
    }
}