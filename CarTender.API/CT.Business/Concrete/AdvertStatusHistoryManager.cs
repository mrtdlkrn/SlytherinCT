using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class AdvertStatusHistoryManager : IAdvertStatusHistoryService
    {
        private readonly IAdverStatusHistoryDAL adverStatusHistoryDAL;

        public AdvertStatusHistoryManager(IAdverStatusHistoryDAL adverStatusHistoryDAL)
        {
            this.adverStatusHistoryDAL = adverStatusHistoryDAL;
        }

        public IResult Add(AdvertStatusHistory entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AdvertStatusHistory> Get(Expression<Func<AdvertStatusHistory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<AdvertStatusHistory>> GetAll(Expression<Func<AdvertStatusHistory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AdvertStatusHistory> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AdvertStatusHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
