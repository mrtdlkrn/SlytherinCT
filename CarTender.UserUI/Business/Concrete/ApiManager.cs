using Business.Abstract;
using Common.Abstract;
using Entity.DTO;
using Entity.DTO.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApiManager:IApiManager
    {
        private readonly IBaseAPIService _baseAPIService;

        public ApiManager(IBaseAPIService baseAPIService)
        {
            _baseAPIService = baseAPIService;
        }

        public Task<DTO> Get<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class
        {
            return _baseAPIService.GET<DTO>(tokenDTO, requestUrl);
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

        public Task<DTO> Get<DTO, FilterDTO>(TokenDTO tokenDTO, string requestUrl, FilterDTO dto) where DTO : class where FilterDTO : class
        {
            return _baseAPIService.GET<DTO, FilterDTO>(tokenDTO, requestUrl, dto);
        }

        public Task<bool> Delete(TokenDTO tokenDTO, string requestUrl)
        {
            return _baseAPIService.DELETE(tokenDTO, requestUrl);
        }
    }
}
