using Entity.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MappingService
    {
        public T GetModel<T>(IFormCollection formCollection) where T : class
        {
            T model = (T)Activator.CreateInstance(typeof(T));

            Type modelType = typeof(T);

            foreach (PropertyInfo propertyInfo in modelType.GetProperties())
            {
                var mykey = propertyInfo.Name;
                try
                {
                    var value = formCollection["MyModel." + mykey];
                    Type propType = propertyInfo.PropertyType;
                    //var sonuc2 = Mapping.TryParse < (propertyInfo.PropertyType.GetEnumUnderlyingType()) > (formCollection.ToString(), out model);
                    if (!propertyInfo.PropertyType.IsPrimitive && propertyInfo.PropertyType != typeof(string))
                    {
                        var x = new AddUserDTO() { Name = "sdfaadfs", Surname = "asdffasd" };
                        //propertyInfo.SetValue(Convert.ChangeType(x.GetType(), propertyInfo.PropertyType),x);
                        propertyInfo.SetValue(model, x);
                        //propertyInfo.SetValue(x,propertyInfo.GetValue().);
                    }
                    propertyInfo.SetValue(model, Convert.ChangeType(value.ToString(), propertyInfo.PropertyType));
                }
                catch
                {
                    continue;
                }

            }

            return model;
        }
    }
}
