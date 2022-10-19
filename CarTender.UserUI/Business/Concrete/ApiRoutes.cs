using Business.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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
                json = new StreamReader(AppContext.BaseDirectory + "ApiRoutes.json").ReadToEnd();
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
