using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class CommissionManager : ICommissionService
    {
        private readonly ICommissionDAL commissionDAL;

        public CommissionManager(ICommissionDAL commissionDAL)
        {
            this.commissionDAL = commissionDAL;
        }

        public IResult Add(Commission entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Commission> Get(Expression<Func<Commission, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Commission>> GetAll(Expression<Func<Commission, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Commission> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Commission entity)
        {
            throw new NotImplementedException();
        }
    }
}
