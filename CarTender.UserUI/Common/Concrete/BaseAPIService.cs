using Common.Abstract;
using Entity.DTO.Auth;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.Concrete
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
            return null;
        }

        public async Task<DTO> GET<DTO, FilterDTO>(TokenDTO tokenDTO, string requestUrl, FilterDTO dto)
            where DTO : class
            where FilterDTO : class
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.GetAsync((connectionString + requestUrl));
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<DTO>(await response.Content.ReadAsStringAsync());
            }
            return null;
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
                return response.Content.ReadAsStringAsync().Result.ToString();
            }
            return null;
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

        #endregion

        #region DELETE

        public async Task<bool> DELETE(TokenDTO tokenDTO, string requestUrl)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

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
