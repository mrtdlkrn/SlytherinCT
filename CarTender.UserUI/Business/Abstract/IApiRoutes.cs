using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IApiRoutes
    {
        IDictionary<string, string> GetApiRoutes(string ControllerName);
    }
}
