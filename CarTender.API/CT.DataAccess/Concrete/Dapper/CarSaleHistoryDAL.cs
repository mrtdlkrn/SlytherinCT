using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.DataAccess.Concrete.Dapper
{
    public class CarSaleHistoryDAL : ICarSaleHistoryDAL
    {
        public void Add(CarSaleHistory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarSaleHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarSaleHistory>> GetAllAsync(Expression<Func<CarSaleHistory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<CarSaleHistory> GetAsync(Expression<Func<CarSaleHistory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(CarSaleHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
