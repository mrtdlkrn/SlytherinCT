using Common.Abstract;
using Entity.DTO;
using Entity.DTO.Auth;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Common.Concrete
{
    public class BaseAPIService : IBaseAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public BaseAPIService(HttpClient httpClient, IConfiguration configuration = null)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        #region GET

        // todo: her zaman ayni sekilde veri donmez. Bazen list, basen class, bazen string vb. doner. Burası duzeltilecek.

        public async Task<ResponseDTO<T>> GET<T>(TokenDTO tokenDTO, string requestUrl) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", tokenDTO.Token);

            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + requestUrl;
            var response = await _httpClient.GetAsync(serviceUrl);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        
        public async Task<ResponseDTO<T>> GET<T, FilterDTO>(TokenDTO tokenDTO, string requestUrl, FilterDTO dto)
            where T : class
            where FilterDTO : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            // todo: verilen filter dto request'e eklecenek.
            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + requestUrl;
            var response = await _httpClient.GetAsync(serviceUrl);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        #endregion

        #region POST

        public async Task<ResponseDTO<T>> POST<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + requestUrl;
            var response = await _httpClient.PostAsync(serviceUrl, serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
      
        #endregion

        #region PUT

        public async Task<ResponseDTO<T>> PUT<T>(TokenDTO tokenDTO, string requestUrl, T dto) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            
            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + requestUrl;
            var response = await _httpClient.PutAsync(serviceUrl, serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        #endregion

        #region DELETE

        public async Task<ResponseDTO<T>> DELETE<T>(TokenDTO tokenDTO, string requestUrl) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenDTO.Token}");

            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + requestUrl;
            var response = await _httpClient.DeleteAsync(serviceUrl);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        #endregion

        #region LOGIN
        public async Task<ResponseDTO<T>> LOGIN<T>(T dto) where T : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + "auth/login";
            var response = await _httpClient.PostAsync(serviceUrl, serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<ResponseDTO<T>> REGISTER<T>(T dto) where T : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + "auth/register";
            var response = await _httpClient.PostAsync(serviceUrl, serializedDto);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<ResponseDTO<T>> FORGOTPASSWORD<T>(T dto) where T : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //todo resigster yerine api de controller içinde smtp yapılacak.
            string serviceUrl = _configuration.GetValue<string>("ApiAddress") + "auth/register";
            var response = await _httpClient.PostAsync(serviceUrl, serializedDto);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        #endregion
    }
}
