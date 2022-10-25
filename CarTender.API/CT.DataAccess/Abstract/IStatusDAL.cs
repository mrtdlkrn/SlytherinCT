using CarTender.Core.Utilities;
using CT.DataAccess.Abstract.Base;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.DataAccess.Abstract
{
    public interface IStatusDAL
    {
        Task<IEnumerable<ListStatusDTO>> GetListStatusesByType(string code);
    }
}
