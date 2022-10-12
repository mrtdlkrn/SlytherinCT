using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMappingService
    {
        public T GetModel<T>(IFormCollection formCollection) where T : class;

        public object GetModelByName(string modelName);

        public object GetModelListByName(string modelName);
    }
}
