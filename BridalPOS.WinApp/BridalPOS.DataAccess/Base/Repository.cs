using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.DataAccess.Base
{
    public class Repository<T> : DataAccess.Interfaces.Base.IRepository<T> where T : Models.Base.ModelBase, new()
    {
        private BridalPOSContext _context;
        private System.Data.Entity.DbSet<T> _dbSet;
        
        public Repository()
            : base()
        {
            _context = new BridalPOSContext();
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> RunExpr
        {
            get
            {
                var _dbSet = _context.Set(typeof(T));
                return _dbSet as IQueryable<T>;
            }
        }

        public T GetById(int id)
        {
            return (T)_dbSet.Find(112);
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
            _context.SaveChanges();
            return entities;
        }

        public void Delete(T entity)
        {
            //entity.IsDeleted = true;
            _context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            _dbSet.Attach(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = new T { Id = id };
            _context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            _dbSet.Attach(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _dbSet.Attach(entity);
            _context.SaveChanges();
        }

        public void Dispose(bool isDisposing)
        {
            _context.Dispose();
        }
    }
}
