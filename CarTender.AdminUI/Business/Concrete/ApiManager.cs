using Business.Abstract;
using Common.Abstract;
using Common.Concrete;
using Entity.DTO;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApiManager : IApiService
    {
        private readonly IBaseAPIService _baseAPIService;

        public ApiManager(IBaseAPIService baseAPIService)
        {
            _baseAPIService = baseAPIService;
        }

        public Task<bool> Delete(TokenDTO tokenDTO, string requestUrl)
        {
           return  _baseAPIService.DELETE(tokenDTO, requestUrl);
        }

        public Task<DTO> Get<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class
        {
            return _baseAPIService.GET<DTO>(tokenDTO,requestUrl);
        }

        public Task<bool> Post<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class
        {
            return _baseAPIService.POST(tokenDTO, requestUrl, dto);
        }

        public Task<string> Post<DTO>(string requestUrl, DTO dto) where DTO : class
        {
            return _baseAPIService.POST(requestUrl, dto);
        }

        public Task<bool> Put<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class
        {
            return _baseAPIService.PUT(tokenDTO, requestUrl, dto); 
        }
    }
}
