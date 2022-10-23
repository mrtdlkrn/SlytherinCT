using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class TownManager : ITownService
    {
        private readonly ITownDAL townDAL;

        public TownManager(ITownDAL townDAL)
        {
            this.townDAL = townDAL;
        }

        public IResult Add(Town entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Town> Get(Expression<Func<Town, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Town>> GetAll(Expression<Func<Town, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Town> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Town entity)
        {
            throw new NotImplementedException();
        }
    }
}
