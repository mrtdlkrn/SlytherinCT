using CarTender.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CarTender.DataAccess.Concrete.Dapper
{
    public class UserDAL : IUserDAL
    {
        public bool Add(User entity)
        {
            return true;
        }

        public bool Delete(User entity)
        {
            return true;
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return null;
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return null;
        }

        public bool Update(User entity)
        {
            return true;
        }
    }
}
