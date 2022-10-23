using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class BidManager : IBidService
    {
        private readonly IBidDAL bidDAL;

        public BidManager(IBidDAL bidDAL)
        {
            this.bidDAL = bidDAL;
        }

        public IResult Add(Bid entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Bid> Get(Expression<Func<Bid, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Bid>> GetAll(Expression<Func<Bid, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Bid> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Bid entity)
        {
            throw new NotImplementedException();
        }
    }
}
