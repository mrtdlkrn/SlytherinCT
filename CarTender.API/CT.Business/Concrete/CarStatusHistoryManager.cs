using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.DTOs.Status;
using CT.Entities.DTOs.Town;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.Business.Concrete
{
    public class CarStatusHistoryManager : ICarStatusHistoryService
    {
        private readonly ICarStatusHistoryDAL carStatusHistoryDAL;

        public CarStatusHistoryManager(ICarStatusHistoryDAL carStatusHistoryDAL)
        {
            this.carStatusHistoryDAL = carStatusHistoryDAL;
        }

        public IResult Add(CarStatusHistory entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarStatusHistory> Get(Expression<Func<CarStatusHistory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<CarStatusHistory>> GetAll(Expression<Func<CarStatusHistory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public IDataResult<CarStatusHistory> GetById(object id)
        {
            throw new NotImplementedException();
        }
        public IResult Update(CarStatusHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
