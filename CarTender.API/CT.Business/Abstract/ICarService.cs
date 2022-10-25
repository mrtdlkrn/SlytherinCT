using CarTender.Core.Utilities;
using CT.Business.Abstract.Base;
using CT.Entities.Car;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.Business.Abstract
{
    public interface ICarService : IBaseService<Car>
    {
        Task<IDataResult<IEnumerable<ListCarDTO>>> GetListCarDetail();
    }
}
