using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class CarSaleHistoryManager : ICarSaleHistoryService
    {
        private readonly ICarSaleHistoryDAL carSaleHistoryDAL;

        public CarSaleHistoryManager(ICarSaleHistoryDAL carSaleHistoryDAL)
        {
            this.carSaleHistoryDAL = carSaleHistoryDAL;
        }

        public IResult Add(CarSaleHistory entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarSaleHistory> Get(Expression<Func<CarSaleHistory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<CarSaleHistory>> GetAll(Expression<Func<CarSaleHistory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarSaleHistory> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarSaleHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
