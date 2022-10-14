using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IApiRoutes
    {
        public IDictionary<string, string> GetApiRoutes(string ControllerName);
    }
}
