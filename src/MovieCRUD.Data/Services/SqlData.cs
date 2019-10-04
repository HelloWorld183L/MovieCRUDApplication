using MovieCRUD.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;

namespace MovieCRUD.Data.Services
{
    public class SqlData
    {
        private MovieDbContext _context;

        public SqlData()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            _context = new MovieDbContext(connectionString);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies;
        }

        public Movie Get(int id)
        {
            return _context.Movies.FirstOrDefault(movie => movie.Id == id);
        }

        public void Create(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void Edit(Movie editedMovie)
        {
            _context.Entry(editedMovie).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}