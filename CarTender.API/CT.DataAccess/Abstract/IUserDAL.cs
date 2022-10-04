using CarTender.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CarTender.DataAccess.Abstract
{
    public interface IUserDAL
    {
        List<User> GetAll(Expression<Func<User, bool>> filter = null);
        User Get(Expression<Func<User, bool>> filter);
        bool Add(User entity);
        bool Update(User entity);
        bool Delete(User entity);
    }
}
