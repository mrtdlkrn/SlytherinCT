using Business.Abstract;
using Entity.DTO;
using Entity.DTO.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Business.Concrete
{
    public class MappingService : IMappingService
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
                    var value = formCollection[mykey];
                    Type propType = propertyInfo.PropertyType;
                    //var sonuc2 = Mapping.TryParse < (propertyInfo.PropertyType.GetEnumUnderlyingType()) > (formCollection.ToString(), out model);
                    if (!propertyInfo.PropertyType.IsPrimitive && propertyInfo.PropertyType != typeof(string))
                    {
                        var x = new AddUserDTO() { Name = "sdfaadfs", Surname = "asdffasd" };
                        propertyInfo.SetValue(model, x);
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

        public object GetModelByName(string modelName)
        {
            ///<summary>
            /// Burada .net'in assembly kodlarindan veri tipleri arasindan tip adi bizim httpget ile aldigimiz model adina esit olan ilk tipin type bilgisini alir
            /// Boylece gonderdigimiz modelName bilgisine gore veri tipini elde etmis oluruz.
            /// </summary>
            Type myModelType = System.AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).First(x => x.Name == modelName);


            return Activator.CreateInstance(myModelType);
        }

        public object GetModelListByName(string modelName)
        {
            object model = GetModelByName(modelName);
            Type modelType = model.GetType();

            ///<summary>
            /// Oluşturduğumuz model tipimizi listeye referans olarak veremedğimizden dolayı makegenerictype ile modelimizle bağlantılı bir liste
            /// tipi oluşturmuş oluruz.
            /// </summary>
            Type customListType = typeof(List<>).MakeGenericType(modelType);

            ///<summary>
            ///List<GelenModelTipi> şeklinde bir liste instance'ı oluşturuyoruz
            ///</summary>
            object list = Activator.CreateInstance(customListType);
            //var asdf = (IList)Activator.CreateInstance(customListType, model);
            return list;
        }
    }
}
