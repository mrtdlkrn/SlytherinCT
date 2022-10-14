using Entity.DTO;
using System.Threading.Tasks;

namespace Common.Abstract
{
    public interface IBaseAPIService
    {

        Task<DTO> GET<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class;


        Task<DTO> GET<DTO, FilterDTO>(TokenDTO tokenDTO, string requestUrl, FilterDTO dto) where DTO : class where FilterDTO : class;


        Task<bool> POST<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;


        Task<string> POST<DTO>(string requestUrl, DTO dto) where DTO : class;


        Task<bool> PUT<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;


        Task<bool> DELETE(TokenDTO tokenDTO, string requestUrl);
    }
}
