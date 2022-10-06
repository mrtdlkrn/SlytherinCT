using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBaseAPIService
    {
        Task<DTO> GET<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class;
        Task<bool> POST<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;
        Task<string> POST<DTO>(string requestUrl, DTO dto) where DTO : class;
        Task<bool> PUT<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;
        Task<bool> DELETE(TokenDTO tokenDTO, string requestUrl, object id);
    }
}
