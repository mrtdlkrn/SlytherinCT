using Common.Abstract;
using Entity.DTO;
using Entity.DTO.Auth;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Common.Concrete
{
    public class BaseAPIService : IBaseAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly string apiAddress;

        public BaseAPIService()
        {
            _httpClient = new HttpClient();
            apiAddress = ConfigurationManager.AppSettings["ApiAddress"];
        }

        #region GET

        // todo: her zaman ayni sekilde veri donmez. Bazen list, basen class, bazen string vb. doner. Burası duzeltilecek.

        public async Task<ResponseDTO<T>> GET<T>(string token, string requestUrl) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", tokenDTO.Token);

            string serviceUrl = apiAddress + requestUrl;
            var response = await _httpClient.GetAsync(serviceUrl);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<ResponseDTO<T>> GET<T, FilterDTO>(string token, string requestUrl, FilterDTO dto)
            where T : class
            where FilterDTO : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            // todo: verilen filter dto request'e eklecenek.
            string serviceUrl = apiAddress + requestUrl;
            var response = await _httpClient.PostAsync(serviceUrl, serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        #endregion

        #region POST

        public async Task<ResponseDTO<T>> POST<T>(string token, string requestUrl, T dto) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            string serviceUrl = apiAddress + requestUrl;
            var response = await _httpClient.PostAsync(serviceUrl, serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        #endregion

        #region PUT

        public async Task<ResponseDTO<T>> PUT<T>(string token, string requestUrl, T dto) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            string serviceUrl = apiAddress + requestUrl;
            var response = await _httpClient.PutAsync(serviceUrl, serializedDto);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        #endregion

        #region DELETE

        public async Task<ResponseDTO<T>> DELETE<T>(string token, string requestUrl) where T : class
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            string serviceUrl = apiAddress + requestUrl;
            var response = await _httpClient.DeleteAsync(serviceUrl);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseDTO<T>>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        #endregion

        #region LOGIN

        // todo: burası direkt sabit olarak logindto alsa daha güzel olmaz mı?
        public async Task<ResponseDTO<TokenDTO>> LOGIN<T>(T dto) where T : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            string serviceUrl = apiAddress + "api/Auth/Login";
            var response = await _httpClient.PostAsync(serviceUrl, serializedDto);

            //if (response.IsSuccessStatusCode)
            //{
            //}
            return JsonConvert.DeserializeObject<ResponseDTO<TokenDTO>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<ResponseDTO<T>> REGISTER<T>(T dto) where T : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            string serviceUrl = apiAddress + "auth/register";
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
            string serviceUrl = apiAddress + "auth/register";
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
