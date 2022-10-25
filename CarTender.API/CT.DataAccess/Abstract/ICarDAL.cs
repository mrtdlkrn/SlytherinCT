using CT.DataAccess.Abstract.Base;
using CT.Entities.Car;
using CT.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.DataAccess.Abstract
{
    public interface ICarDAL : IBaseRepository<Car>
    {
        Task<IEnumerable<ListCarDTO>> GetListCarDetail();
    }
}
