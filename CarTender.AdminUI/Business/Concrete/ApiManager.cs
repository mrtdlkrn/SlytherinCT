using Business.Abstract;
using Common.Abstract;
using Core.Aspects.Autofac.Exception;
using Core.Aspects.Autofac.Logging;
using Core.Logging.Log4Net.Loggers;
using Entity.DTO;
using Entity.DTO.Auth;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //[ExceptionLogAspect(typeof(FileLogger))]
    //[LogAspect(typeof(FileLogger))]

    public class ApiManager : IApiService
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

        public Task<ResponseDTO<T>> Login<T>(T dto) where T : class
        {
            return _baseAPIService.LOGIN(dto);
        }

        public Task<ResponseDTO<T>> Post<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class
        {
            return _baseAPIService.POST(tokenDTO, requestUrl, dto);
        }

        public Task<ResponseDTO<T>> Put<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class
        {
            return _baseAPIService.PUT(tokenDTO, requestUrl, dto);
        }
    }
}
