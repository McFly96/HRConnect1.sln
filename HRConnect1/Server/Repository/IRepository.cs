using HRConnect1.Server.Data;
using HRConnect1.Shared.Models;

namespace HRConnect1.Server.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }

}
