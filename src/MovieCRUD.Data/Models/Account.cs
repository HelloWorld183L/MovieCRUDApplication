using MovieCRUD.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MovieCRUD.Data.Models
{
    public class Account : IEntity
    {
        [Required]
        public int Username { get; set; }
        [Required]
        public int Password { get; set; }
        public int Id { get; set; }
    }
}