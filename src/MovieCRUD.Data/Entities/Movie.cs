using MovieCRUD.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MovieCRUD.Data
{
    public class Movie : IEntity
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