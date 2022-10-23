using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class AdvertManager : IAdvertService
    {
        private readonly IAdvertDAL advertDAL;

        public AdvertManager(IAdvertDAL advertDAL)
        {
            this.advertDAL = advertDAL;
        }

        public IResult Add(Advert entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Advert> Get(Expression<Func<Advert, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Advert>> GetAll(Expression<Func<Advert, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Advert> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Advert entity)
        {
            throw new NotImplementedException();
        }
    }
}
