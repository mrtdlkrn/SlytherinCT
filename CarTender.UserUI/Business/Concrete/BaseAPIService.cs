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

        /// <summary>
        /// Get action method using User's Token
        /// </summary>
        /// <typeparam name="DTO">A class</typeparam>
        /// <param name="tokenDTO">User's Token</param>
        /// <param name="requestUrl">Request URL</param>
        /// <returns></returns>
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

        /// <summary>
        /// Get action method  using User's Token with filtered information 
        /// </summary>
        /// <typeparam name="DTO">A class</typeparam>
        /// <param name="tokenDTO">User's Token</param>
        /// <param name="requestUrl">Request URL</param>
        /// <param name="filter">Can be a class to filter a list</param>
        /// <returns></returns>
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

        /// <summary>
        /// Get action method without using a token
        /// </summary>
        /// <typeparam name="DTO">A class</typeparam>
        /// <param name="requestUrl">Request URL</param>
        /// <returns></returns>
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

        /// <summary>
        /// Post action method using User's Token
        /// </summary>
        /// <typeparam name="DTO">A class</typeparam>
        /// <param name="tokenDTO">User's Token</param>
        /// <param name="requestUrl">Request URL</param>
        /// <param name="dto">A class</param>
        /// <returns></returns>
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

        /// <summary>
        /// Post action method without using a token
        /// </summary>
        /// <typeparam name="DTO">A class</typeparam>
        /// <param name="requestUrl">Request URL</param>
        /// <param name="dto">A class</param>
        /// <returns></returns>
        public async Task<string> POST<DTO>(string requestUrl, DTO dto) where DTO : class
        {
            var serializedDto = new StringContent(JsonConvert.SerializeObject(dto));
            serializedDto.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync((connectionString + requestUrl), serializedDto);
            if (response.IsSuccessStatusCode)
            {
                //return response.Content.ReadAsStringAsync().Result == "success" ? " : false;
                var resposeControl = response.Content.ReadAsStringAsync().Result;
                return "";
            }
            return "";
        }
        #endregion

        #region PUT

        /// <summary>
        /// Put action method using User's Token
        /// </summary>
        /// <typeparam name="DTO">A class</typeparam>
        /// <param name="tokenDTO">User's Token</param>
        /// <param name="requestUrl">Request URL</param>
        /// <param name="dto">A class</param>
        /// <returns></returns>
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

        /// <summary>
        /// Put action method without using a token
        /// </summary>
        /// <typeparam name="DTO">A class</typeparam>
        /// <param name="requestUrl">Request URL</param>
        /// <param name="dto">A class</param>
        /// <returns></returns>
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

        /// <summary>
        /// Delete action method using User's Token
        /// </summary>
        /// <param name="tokenDTO">User's Token</param>
        /// <param name="requestUrl">Request URL</param>
        /// <param name="id">Deleted Object's ID</param>
        /// <returns></returns>
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
        /// Delete action method without using a token
        /// </summary>
        /// <param name="requestUrl">Request URL</param>
        /// <param name="id">Deleted Object's ID</param>
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
