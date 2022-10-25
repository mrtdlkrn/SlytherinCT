using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.DTOs.Town;
using CT.Entities.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.DataAccess.Concrete.Dapper
{
    //public class TownDAL : DapperRepository<Town, CarTenderDbContext>, ITownDAL
    public class TownDAL : ITownDAL
    {
        private readonly CarTenderDbContext _context;

        public TownDAL(CarTenderDbContext context)
        {
            this._context = context;
        }

        public void Add(Town entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Town entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ListTownDTO>> GetAllAsync(Expression<Func<Town, bool>> filter = null)
        {
            var getTownsQuery = "select TownName,CityName from Town t join City c on t.CityID = c.ID ";

            IEnumerable<ListTownDTO> results = null;

            using (var connection = _context.CreateConnection())
            {
                results = await connection.QueryAsync<ListTownDTO>(getTownsQuery);
            }

            return results.ToList();
        }

        public Task<Town> GetAsync(Expression<Func<Town, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Town entity)
        {
            throw new NotImplementedException();
        }
    }
}
