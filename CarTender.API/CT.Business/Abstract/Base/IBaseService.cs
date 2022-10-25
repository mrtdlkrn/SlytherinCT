using CarTender.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Abstract.Base
{
    public interface IBaseService<T>
    {
        IDataResult<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null);
        IDataResult<T> Get(Expression<Func<T, bool>> filter = null);
        IDataResult<T> GetById(object id);
        IResult Add(T entity);   
        IResult Update(T entity);
        IResult Delete(object id);
    }
}
