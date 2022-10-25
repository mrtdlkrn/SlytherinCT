using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class CorporateManager : ICorporateService
    {
        private readonly ICorporateDAL corporateDAL;

        public CorporateManager(ICorporateDAL corporateDAL)
        {
            this.corporateDAL = corporateDAL;
        }

        public IResult Add(Corporate entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Corporate> Get(Expression<Func<Corporate, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Corporate>> GetAll(Expression<Func<Corporate, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Corporate> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Corporate entity)
        {
            throw new NotImplementedException();
        }
    }
}
