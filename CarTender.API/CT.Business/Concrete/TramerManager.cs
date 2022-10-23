using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class TramerManager : ITramerService
    {
        private readonly ITramerDAL tramerDAL;

        public TramerManager(ITramerDAL tramerDAL)
        {
            this.tramerDAL = tramerDAL;
        }

        public IResult Add(Tramer entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Tramer> Get(Expression<Func<Tramer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Tramer>> GetAll(Expression<Func<Tramer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Tramer> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Tramer entity)
        {
            throw new NotImplementedException();
        }
    }
}
