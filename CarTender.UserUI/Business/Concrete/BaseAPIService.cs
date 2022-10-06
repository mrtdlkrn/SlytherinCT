using Business.Abstract;
using Entity.DTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaseAPIService : IBaseAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly string connectionString;

        public BaseAPIService()
        {
            _httpClient = new HttpClient();
            connectionString = ConfigurationManager.AppSettings["ApiAddress"];
        }

        #region GET
        public async Task<DTO> GET<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");
            var response = await _httpClient.GetAsync((connectionString + requestUrl));
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<DTO>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }

        public async Task<DTO> GET<DTO>(TokenDTO tokenDTO, string requestUrl,DTO filter) where DTO : class
        {
            //DTO filter, UI dan gelecek filtrelemeleri alacak DTO
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");
            var response = await _httpClient.GetAsync((connectionString + requestUrl + filter));
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<DTO>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }

        public async Task<DTO> GET<DTO>(string requestUrl) where DTO : class
        {
            var response = await _httpClient.GetAsync((connectionString + requestUrl));
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<DTO>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region POST
        public async Task<bool> POST<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync((connectionString + requestUrl), serializedDto);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "success" ? true : false;
            }
            return false;
        }

        public async Task<string> POST<DTO>(string requestUrl, DTO dto) where DTO : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync((connectionString + requestUrl), serializedDto);
            if (response.IsSuccessStatusCode)
            {
                //return response.Content.ReadAsStringAsync().Result == "success" ? " : false;
                return "";
            }
            return "";
        }
        #endregion

        #region PUT
        public async Task<bool> PUT<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PutAsync((connectionString + requestUrl), serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "success" ? true : false;
            }
            return false;
        }

        public async Task<bool> PUT<DTO>(string requestUrl, DTO dto) where DTO : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PutAsync((connectionString + requestUrl), serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "success" ? true : false;
            }
            return false;
        }

        #endregion

        #region DELETE

        public async Task<bool> DELETE(TokenDTO tokenDTO, string requestUrl, object id)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            var response = await _httpClient.DeleteAsync((connectionString + requestUrl));

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "success" ? true : false;
            }

            return false;
        }

        /// <summary>
        /// Calls delete action in http client without token
        /// </summary>
        /// <param name="requestUrl"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DELETE(string requestUrl)
        {
            var response = await _httpClient.DeleteAsync((connectionString + requestUrl));

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "success" ? true : false;
            }

            return false;
        }
        #endregion
    }
}
