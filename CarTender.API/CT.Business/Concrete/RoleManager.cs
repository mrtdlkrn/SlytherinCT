using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDAL roleDAL;

        public RoleManager(IRoleDAL roleDAL)
        {
            this.roleDAL = roleDAL;
        }

        public IResult Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Role> Get(Expression<Func<Role, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Role>> GetAll(Expression<Func<Role, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Role> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
