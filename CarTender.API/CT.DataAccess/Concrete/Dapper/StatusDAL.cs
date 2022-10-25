using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace CT.DataAccess.Concrete.Dapper
{
    public class StatusDAL : IStatusDAL
    {
        private readonly CarTenderDbContext _context;

        public StatusDAL(CarTenderDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ListStatusDTO>> GetListStatusesByType(string code)
        {
            var getStatusByTpye = "select StatusName from [Status] where Code = @code";

            var parametres = new DynamicParameters();

            parametres.Add("code", code, DbType.String);

            using (var conn = _context.CreateConnection())
            {
                var restatus = await conn.QueryAsync<ListStatusDTO>(getStatusByTpye,parametres);

                return restatus.ToList();
            }
        }
    }
}
