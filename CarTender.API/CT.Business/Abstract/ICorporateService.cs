using CarTender.Core.Utilities;
using CT.Business.Abstract.Base;
using CT.Entities.DTOs.Corporate;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.Business.Abstract
{
    public interface ICorporateService : IBaseService<Corporate>
    {
        Task<IDataResult<IEnumerable<ListCorporateDTO>>> GetListAllCorporate();
    }
}
