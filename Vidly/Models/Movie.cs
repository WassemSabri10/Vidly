using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]  //not allow null
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }

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

        public byte NumberAvailable { get; set; }

    }
}