using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class StatusManager : IStatusService
    {
        private readonly IStatusDAL statusDAL;

        public StatusManager(IStatusDAL statusDAL)
        {
            this.statusDAL = statusDAL;
        }

        public IResult Add(Status entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Status> Get(Expression<Func<Status, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Status>> GetAll(Expression<Func<Status, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Status> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Status entity)
        {
            throw new NotImplementedException();
        }
    }
}
