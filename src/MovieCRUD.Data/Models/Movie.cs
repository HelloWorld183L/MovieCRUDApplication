using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCRUD.Data
{
    public class Movie
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public Rating Rating { get; set; }
        public int Id { get; set; }
    }
}