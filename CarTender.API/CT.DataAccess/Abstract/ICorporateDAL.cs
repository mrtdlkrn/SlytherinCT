using CT.DataAccess.Abstract.Base;
using CT.Entities.DTOs.Corporate;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.DataAccess.Abstract
{
    public interface ICorporateDAL 
    {
        Task<IEnumerable<ListCorporateDTO>> GetListAllCorporate();
    }
}
