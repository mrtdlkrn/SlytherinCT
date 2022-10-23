using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class AuthorizationManager : IAuthorizationService
    {
        private readonly IAuthorizationDAL authorizationDAL;

        public AuthorizationManager(IAuthorizationDAL authorizationDAL)
        {
            this.authorizationDAL = authorizationDAL;
        }

        public IResult Add(Authorization entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Authorization> Get(Expression<Func<Authorization, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Authorization>> GetAll(Expression<Func<Authorization, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Authorization> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Authorization entity)
        {
            throw new NotImplementedException();
        }
    }
}
