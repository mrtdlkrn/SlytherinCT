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

        public Task<ResponseDTO<T>> Delete<T>(string token, string requestUrl) where T : class
        {
            return _baseAPIService.DELETE<T>(token, requestUrl);
        }

        public Task<ResponseDTO<T>> ForgotPassword<T>(T dto) where T : class
        {
            return _baseAPIService.FORGOTPASSWORD(dto);
        }

        public Task<ResponseDTO<T>> Get<T>(string token, string requestUrl) where T : class
        {
            return _baseAPIService.GET<T>(token, requestUrl);
        }

        public Task<ResponseDTO<T>> Get<T, FilterDTO>(string token, string requestUrl, FilterDTO dto)
            where T : class
            where FilterDTO : class
        {
            return _baseAPIService.GET<T, FilterDTO>(token, requestUrl, dto);
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

        public Task<ResponseDTO<T>> Post<T>(string token, string requestUrl, T dto) where T : class
        {
            return _baseAPIService.POST(token, requestUrl, dto);
        }

        public Task<ResponseDTO<T>> Put<T>(string token, string requestUrl, T dto) where T : class
        {
            return _baseAPIService.PUT(token, requestUrl, dto);
        }

        public Task<ResponseDTO<T>> Register<T>(T dto) where T : class
        {
            return _baseAPIService.REGISTER(dto);
        }
    }
}
