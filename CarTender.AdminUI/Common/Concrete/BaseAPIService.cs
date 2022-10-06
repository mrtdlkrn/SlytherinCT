using Common.Abstract;
using Entity.DTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.Concrete
{
    public class BaseAPIService : IAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public BaseAPIService(HttpClient httpClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        #region GET

        // todo: her zaman ayni sekilde veri donmez. Bazen list, basen class, bazen string vb. doner. Burası duzeltilecek.

        public async Task<DTO> GET<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");
            string serviceUrl = _configuration.GetValue<string>("ApiAddress");
            var response = await _httpClient.GetAsync((serviceUrl + requestUrl));

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
            string serviceUrl = _configuration.GetValue<string>("ApiAddress");
            var response = await _httpClient.PostAsync((serviceUrl + requestUrl), serializedDto);

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
            string serviceUrl = _configuration.GetValue<string>("ApiAddress");
            var response = await _httpClient.PostAsync((serviceUrl + requestUrl), serializedDto);

            if (response.IsSuccessStatusCode)
            {
                //return response.Content.ReadAsStringAsync().Result == "success" ? " : false;
                return "";
            }
            return "";
        }

        public async Task<bool> PUT<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            string serviceUrl = _configuration.GetValue<string>("ApiAddress");
            var response = await _httpClient.PutAsync((serviceUrl + requestUrl), serializedDto);

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

            // todo: url bu şekilde mi alınmalı? Yoksa id parametresi de verilmiş şekilde mi alınmalı?

            // url = user/delete?id=5
            //var response = await _httpClient.DeleteAsync(requestUrl);

            // url = user
            string serviceUrl = _configuration.GetValue<string>("ApiAddress");
            var response = await _httpClient.DeleteAsync((serviceUrl + requestUrl));

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == "success" ? true : false;
            }

            return false;
        }

        #endregion
    }
}
