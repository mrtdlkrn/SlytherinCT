using CarTender.Core.Utilities;
using CT.Entities.DTOs.Town;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.Business.Abstract
{
    public interface ITownService
    {
        Task<IDataResult<IEnumerable<ListTownDTO>>> GetAll(Expression<Func<Town, bool>> filter = null);
    }
}
