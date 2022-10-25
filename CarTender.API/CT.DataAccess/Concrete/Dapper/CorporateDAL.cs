using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.DTOs.Corporate;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace CT.DataAccess.Concrete.Dapper
{
    public class CorporateDAL : ICorporateDAL
    {
        private readonly CarTenderDbContext _context;

        public CorporateDAL(CarTenderDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ListCorporateDTO>> GetListAllCorporate()
        {
            var getAllCorporate = "select CorporateName from Corporate";

            using (var conn = _context.CreateConnection())
            {
                var reCorporate = await conn.QueryAsync<ListCorporateDTO>(getAllCorporate);

                return reCorporate.ToList();
            }
        }
    }

}

