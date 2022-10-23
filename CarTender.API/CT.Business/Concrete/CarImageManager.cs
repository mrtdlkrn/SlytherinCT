using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDAL carImageDAL;

        public CarImageManager(ICarImageDAL carImageDAL)
        {
            this.carImageDAL = carImageDAL;
        }

        public IResult Add(CarImage entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Get(Expression<Func<CarImage, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<CarImage>> GetAll(Expression<Func<CarImage, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
