using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.Car;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.DataAccess.Concrete.Dapper
{
    public class CarDAL : ICarDAL
    {
        private readonly CarTenderDbContext _context;

        public CarDAL(CarTenderDbContext context)
        {
            _context = context;
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllAsync(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetAsync(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ListCarDTO>> GetListCarDetail()
        {
            var getYear = "SELECT [Year] FROM Car GROUP BY [Year] HAVING COUNT(ID) >1;" + "select CarDetailValueName from CarDetailValue" + "select [Name] from BrandModel";

            using (var conn = _context.CreateConnection())
            {
                var restatus = await conn.QueryAsync<ListCarDTO>(getYear);

                return restatus.ToList();
            }
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
