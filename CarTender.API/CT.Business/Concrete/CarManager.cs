using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDAL carDAL;

        public CarManager(ICarDAL carDAL)
        {
            this.carDAL = carDAL;
        }

        public IResult Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
