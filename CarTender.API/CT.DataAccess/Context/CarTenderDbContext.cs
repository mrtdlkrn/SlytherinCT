using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace CT.DataAccess.Context
{
    public class CarTenderDbContext 
    {
        private readonly IConfiguration configuration;

        public CarTenderDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection CreateConnection() => new SqlConnection(configuration.GetConnectionString("SqlConnection"));
    }
}
