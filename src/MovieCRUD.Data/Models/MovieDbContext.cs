using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCRUD.Data.Models
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        private readonly string _connectionString;

        public MovieDbContext(string connectionString) : base()
        {
            _connectionString = connectionString;
        }
    }
}
