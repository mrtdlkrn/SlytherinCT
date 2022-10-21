using CT.DataAccess.Abstract.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.DataAccess.Concrete.Dapper.Base
{
    public class DapperRepository<TEntity, TContext> : IBaseRepository<TEntity> 
        where TEntity : class, new()
        //where TContext : DbContext, new() // dapper'a uygun kısıtlama yapılacak

    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
