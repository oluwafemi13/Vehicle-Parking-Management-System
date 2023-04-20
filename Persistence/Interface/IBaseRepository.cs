using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        
        Task<T> GetById(int id);
        Task<T> Get(Expression<Func<T, bool>> predicate=null);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAll();
        void AddAsync(T item);
        void Delete(int id);
        void DeleteRange(int start, int end, int count);
        void DeleteRange(IEnumerable<T> items);
        void Update(T item);
    }
}
