using Entity.DTO;
using Entity.DTO.Auth;
using System.Threading.Tasks;

namespace Common.Abstract
{
    public interface IBaseAPIService
    {

        Task<ResponseDTO<T>> GET<T>(TokenDTO tokenDTO, string requestUrl) where T : class;

        Task<ResponseDTO<T>> GET<T, FilterDTO>(TokenDTO tokenDTO, string requestUrl, FilterDTO dto) where T : class where FilterDTO : class;

        Task<ResponseDTO<T>> POST<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class;

        Task<ResponseDTO<T>> LOGIN<T>(T dto) where T : class;

        Task<ResponseDTO<T>> PUT<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class;

        Task<ResponseDTO<T>> DELETE<T>(TokenDTO tokenDTO, string requestUrl) where T : class;

    }
}
