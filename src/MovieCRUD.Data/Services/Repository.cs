using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MovieCRUD.Data.Interfaces;
using MovieCRUD.Data.Models;

namespace MovieCRUD.Data.Services
{
    public class Repository<T> : IRepository<T> where T: class, IEntity
    {
        private readonly DbSet<T> _set;
        private readonly GeneralDbContext _context;

        public Repository(GeneralDbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        public IEnumerable<T> Get() => _set;

        public T Get(int id) => _set.FirstOrDefault(e =>  e.Id == id);
        
        public void Create(T entity)
        {
            _set.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public void Edit(T editedEntity)
        {
            _context.Entry(editedEntity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}