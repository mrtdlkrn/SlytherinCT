using CT.DataAccess.Abstract.Base;
using CT.Entities.DTOs.Town;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.DataAccess.Abstract
{
    //public interface ITownDAL : IBaseRepository<Town>
    public interface ITownDAL 
    {
        Task<IEnumerable<ListTownDTO>> GetAllAsync(Expression<Func<Town, bool>> filter = null);
    }
}
