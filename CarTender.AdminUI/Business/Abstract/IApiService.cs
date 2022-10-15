using Entity.DTO.Auth;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApiService
    {
        /// <summary>
        /// This action makes GET request to the given request url. Used to get datas.
        /// </summary>
        /// <typeparam name="DTO">Type of model to be get.</typeparam>
        /// <param name="tokenDTO">
        /// A model with JWT token key and expire date.
        /// </param>
        /// <param name="requestUrl">
        /// Request path for API endpoint.<br/>
        /// For example: Get(token,"ControllerName/Action")
        /// </param>
        /// <returns>This aciton returns data of the type you specify.</returns>
        Task<DTO> Get<DTO>(TokenDTO tokenDTO, string requestUrl) where DTO : class;
        /// <summary>
        /// This action makes GET request to the given request url. Used to get datas with filters.
        /// </summary>
        /// <typeparam name="DTO">Return type</typeparam>
        /// <typeparam name="FilterDTO">Type of filter.</typeparam>
        /// <param name="tokenDTO">
        /// A model with JWT token key and expire date.
        /// </param>
        /// <param name="requestUrl">
        /// Request path for API endpoint.<br/>
        /// For example: Get(token,"ControllerName/Action")
        /// </param>
        /// <param name="dto">A model to filter datas.</param>
        /// <returns>This aciton returns filtered datas.</returns>
        Task<DTO> GET<DTO, FilterDTO>(TokenDTO tokenDTO, string requestUrl, FilterDTO dto) where DTO : class where FilterDTO : class;
        /// <summary>
        /// This action makes POST request to the given request url. Used to create datas.
        /// </summary>
        /// <typeparam name="DTO">Type of model to be create.</typeparam>
        /// <param name="tokenDTO">
        /// A model with JWT token key and expire date.
        /// </param>
        /// <param name="requestUrl">
        /// Request path for API endpoint.<br/>
        /// For example: "ControllerName/Action"
        /// </param>
        /// <param name="dto">
        ///  A model you want to send.
        /// </param>
        /// <returns>This aciton returns true if operation is success.</returns>
        Task<bool> Post<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;
        /// <summary>
        /// This action makes POST request to the given request url. Used to get Token from API. 
        /// </summary>
        /// <typeparam name="DTO">Type of model to be create.</typeparam>
        /// <param name="requestUrl">
        /// Request path for API endpoint.<br/>
        /// For example: "ControllerName/Action"
        /// </param>
        /// <param name="dto">
        ///  A model you want to send.
        /// </param>
        /// <returns>This aciton returns JWT token key if operation is success.</returns>
        Task<string> Post<DTO>(string requestUrl, DTO dto) where DTO : class;
        /// <summary>
        /// This action makes PUT request to the given request url. Used to update datas.
        /// </summary>
        /// <typeparam name="DTO">Type of model to be update.</typeparam>
        /// <param name="tokenDTO">
        /// A model with JWT token key and expire date.      
        /// </param>
        /// <param name="requestUrl">
        /// Request path for API endpoint.<br/>
        /// For example: "ControllerName/Action"
        /// </param>
        /// <param name="dto">
        /// A model you want to send.        
        /// </param>
        /// <returns>This aciton returns true if operation is success.</returns>
        Task<bool> Put<DTO>(TokenDTO tokenDTO, string requestUrl, DTO dto) where DTO : class;
        /// <summary>
        /// This action makes DELETE request to the given request url. Used to delete datas.
        /// </summary>
        /// <param name="tokenDTO">
        /// A model with JWT token key and expire date.      
        /// </param>
        /// <param name="requestUrl">
        /// Request path for API endpoint.<br/>
        /// For example: "ControllerName/Action"
        /// </param>
        /// <returns>This aciton returns true if operation is success.</returns>
        Task<bool> Delete(TokenDTO tokenDTO, string requestUrl);
        void Test(string test);
    }
}
