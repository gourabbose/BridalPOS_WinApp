using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.DataAccess.Interfaces.Base
{
    public interface IRepository<T> where T : Models.Base.ModelBase
    {
        T GetById(int id);
        T Add(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(int id);
        void Update(T entity);
        IQueryable<T> RunExpr { get; }
    }
}
