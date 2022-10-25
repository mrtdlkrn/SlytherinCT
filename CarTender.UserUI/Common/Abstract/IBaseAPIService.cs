using Entity.DTO;
using Entity.DTO.Auth;
using System.Threading.Tasks;

namespace Common.Abstract
{
    public interface IBaseAPIService
    {
        Task<ResponseDTO<T>> GET<T>(string token, string requestUrl) where T : class;

        Task<ResponseDTO<T>> GET<T, FilterDTO>(string token, string requestUrl, FilterDTO dto) where T : class where FilterDTO : class;

        Task<ResponseDTO<T>> POST<T>(string token, string requestUrl, T dto) where T : class;

        Task<ResponseDTO<TokenDTO>> LOGIN<T>(T dto) where T : class;

        Task<ResponseDTO<T>> PUT<T>(string token, string requestUrl, T dto) where T : class;

        Task<ResponseDTO<T>> DELETE<T>(string token, string requestUrl) where T : class;

        Task<ResponseDTO<T>> REGISTER<T>(T dto) where T : class;

        Task<ResponseDTO<T>> FORGOTPASSWORD<T>(T dto) where T : class;
    }
}
