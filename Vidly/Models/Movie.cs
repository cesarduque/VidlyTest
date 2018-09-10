using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Required]
        public int NumberInStock { get; set; }
        
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

    }
}