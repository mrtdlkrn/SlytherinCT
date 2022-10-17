using Business.Abstract;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ApiRoutes : IApiRoutes
    {
        public IDictionary<string, string> GetApiRoutes(string ControllerName)
        {
            IDictionary<string, string> routes = new Dictionary<string, string>();
            string json = "";
            try
            {
                json = System.IO.File.ReadAllText(@"\CT.UserUI\ApiRoutes.json");
                dynamic jsonObj = JsonConvert.DeserializeObject<dynamic>(json);
                var Controllers = jsonObj.ApiRoutes;
                foreach (var Controller in Controllers)
                {
                    if (Controller.ControllerName.ToString() == ControllerName)
                    {
                        var actions = Controller.Actions;
                        foreach (var action in actions)
                        {
                            routes.Add(action.Name.ToString(), action.Value.ToString());
                        }
                    }
                }
                return routes;
            }
            catch
            {
                return null;
            }
        }
    }
}
