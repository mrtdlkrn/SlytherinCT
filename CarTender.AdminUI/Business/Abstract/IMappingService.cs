using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IMappingService
    {
        public T GetModel<T>(IFormCollection formCollection) where T : class;

        public object GetModelByName(string modelName);

        public object GetModelListByName(string modelName);
    }
}
