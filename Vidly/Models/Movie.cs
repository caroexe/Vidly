using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date when added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20,ErrorMessage = "Number in Stock has to be between 1 and 20")]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }
    }
}