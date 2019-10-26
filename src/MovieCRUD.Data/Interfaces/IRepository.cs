using System.Collections.Generic;

namespace MovieCRUD.Data.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Create(T entity);
        void Delete(T entity);
        void Edit(T editedEntity);
    }
}