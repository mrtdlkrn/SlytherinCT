using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CT.DataAccess.Concrete.Dapper
{
    public class CarStatusHistoryDAL : ICarStatusHistoryDAL
    {
        private readonly CarTenderDbContext _context;

        public CarStatusHistoryDAL(CarTenderDbContext context)
        {
            _context = context;
        }

       
    }
}
