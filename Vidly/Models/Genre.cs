using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Id { get; set; }
    }
}