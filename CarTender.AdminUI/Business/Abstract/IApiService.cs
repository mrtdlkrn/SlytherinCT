using Entity.DTO;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApiService
    {
        Task<DTO> Get<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class;
        Task<bool> Post<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;
        Task<string> Post<DTO>(string requestUrl, DTO dto) where DTO : class;
        Task<bool> Put<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;       
        Task<bool> Delete(TokenDTO tokenDTO, string requestUrl);
    }
}
