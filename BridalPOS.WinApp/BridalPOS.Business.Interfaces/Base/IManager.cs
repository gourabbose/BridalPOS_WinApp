using BridalPOS.Utilities;
using BridalPOS.Utilities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Business.Interfaces.Base
{
    public interface IManager<T> where T : Models.Base.ModelBase
    {
        ServiceResult<T> GetById(int id);
        SaveResult Add(T entity);
        SaveResult AddRange(IEnumerable<T> entities);
        OperationState Delete(T entity);
        OperationState Delete(int id);
        OperationState Update(T entity);
        ServiceResultList<T> GetAll();
    }
}

