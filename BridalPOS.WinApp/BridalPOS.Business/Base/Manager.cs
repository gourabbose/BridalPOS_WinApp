using BridalPOS.DataAccess.Interfaces.Base;
using BridalPOS.Utilities;
using BridalPOS.Utilities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Business.Base
{
    public class Manager<T> : BridalPOS.Business.Interfaces.Base.IManager<T> where T : Models.Base.ModelBase
    {
        protected IRepository<T> _repo;

        public Manager(IRepository<T> Repository):base()
    {
        _repo = Repository;
    }

        public Utilities.DTO.ServiceResult<T> GetById(int id)
        {
            try
            {
                return new ServiceResult<T> { State = OperationState.Success, Data = _repo.GetById(id) };
            }
            catch (Exception ex)
            {
                return new ServiceResult<T> { State = OperationState.Failure, Exception = ex.Message };
            }
        }

        public Utilities.DTO.SaveResult Add(T entity)
        {
            try
            {
                _repo.Add(entity);
                return new SaveResult {Id=entity.Id,State=OperationState.Success };
            }
            catch (Exception ex)
            {
                return new SaveResult { Exception = ex.Message, State = OperationState.Failure };
            }
        }

        public Utilities.DTO.SaveResult AddRange(IEnumerable<T> entities)
        {
            try
            {
                _repo.AddRange(entities);
                return new SaveResult { State = OperationState.Success };
            }
            catch (Exception ex)
            {
                return new SaveResult { Exception = ex.Message, State = OperationState.Failure };
            }
        }

        public Utilities.OperationState Delete(T entity)
        {
            try
            {
                _repo.Delete(entity);
                return OperationState.Success;
            }
            catch (Exception ex)
            {
                return OperationState.Failure;
            }
        }

        public Utilities.OperationState Delete(int id)
        {
            try
            {
                _repo.Delete(id);
                return OperationState.Success;
            }
            catch (Exception ex)
            {
                return OperationState.Failure;
            }
        }

        public Utilities.OperationState Update(T entity)
        {
            try
            {
                _repo.Update(entity);
                return OperationState.Success;
            }
            catch (Exception ex)
            {
                return OperationState.Failure;
            }
        }

        public Utilities.DTO.ServiceResultList<T> GetAll()
        {
            try
            {
                return new ServiceResultList<T> { Data = _repo.RunExpr.ToList(), State = OperationState.Success };
            }
            catch (Exception ex)
            {
                return new ServiceResultList<T> { State = OperationState.Failure, Exception = ex.Message };
            }
        }
    }
}
