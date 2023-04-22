using DataAccess.Data;
using DataAccess.Persistence.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Repository
{
    public class BaseRepository<T>: IBaseRepository<T> where T : class
    {
        private readonly DatabaseContext _db;

        public BaseRepository(DatabaseContext db)
        {
            _db = db;
        }

        public void AddAsync(T item)
        {
             _db.Entry(item).State = EntityState.Added;
            //_db.SaveChanges();
            
        }

        public void Delete(int id)
        {
            _db.Entry(id).State = EntityState.Deleted;
        }

        public void DeleteRange(int start, int end, int count)
        {
            if(start == 0)
            {
                start++;
            }
            for(int i=start; i<end; i++)
            {
                _db.Entry(i).State = EntityState.Deleted;
                count--;
            }
            
        }

        public void DeleteRange(IEnumerable<T> items)
        {
            _db.Set<T>().RemoveRange(items);
            //_db.Entry(items).State = EntityState.Deleted;
        }

        public async Task<T> GetById(int id)
        {
           return await _db.Set<T>().FindAsync(id);
        }

        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _db.Set<T>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return await query.FirstOrDefaultAsync();
            
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

       
        public void Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }
    }
}
