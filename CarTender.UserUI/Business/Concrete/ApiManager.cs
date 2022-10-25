using Business.Abstract;
using Common.Abstract;
using Entity.DTO;
using Entity.DTO.Auth;
using Entity.Error;
using System;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApiManager : IApiManager
    {
        private readonly IBaseAPIService _baseAPIService;

        public ApiManager(IBaseAPIService baseAPIService)
        {
            _baseAPIService = baseAPIService;
        }

        public Task<ResponseDTO<T>> Delete<T>(TokenDTO tokenDTO, string requestUrl) where T : class
        {
            return _baseAPIService.DELETE<T>(tokenDTO, requestUrl);
        }

        public Task<ResponseDTO<T>> ForgotPassword<T>(T dto) where T : class
        {
            return _baseAPIService.FORGOTPASSWORD(dto);
        }

        public Task<ResponseDTO<T>> Get<T>(TokenDTO tokenDTO, string requestUrl) where T : class
        {
            return _baseAPIService.GET<T>(tokenDTO, requestUrl);
        }

        public Task<ResponseDTO<T>> Get<T, FilterDTO>(TokenDTO tokenDTO, string requestUrl, FilterDTO dto)
            where T : class
            where FilterDTO : class
        {
            return _baseAPIService.GET<T, FilterDTO>(tokenDTO, requestUrl, dto);
        }

        public async Task<ResponseDTO<TokenDTO>> Login<T>(T dto) where T : class
        {
            try
            {
                return await _baseAPIService.LOGIN(dto);
            }
            catch (Exception)
            {
          
                return new ResponseDTO<TokenDTO>() { Data = null, Message = "API ile bağlantıda bir sorun oluştu.", StatusCode = 404, Success = false }; ;
            }
        }

        public Task<ResponseDTO<T>> Post<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class
        {
            return _baseAPIService.POST(tokenDTO, requestUrl, dto);
        }

        public Task<ResponseDTO<T>> Put<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class
        {
            return _baseAPIService.PUT(tokenDTO, requestUrl, dto);
        }

        public Task<ResponseDTO<T>> Register<T>(T dto) where T : class
        {
            return _baseAPIService.REGISTER(dto);
        }
    }
}
