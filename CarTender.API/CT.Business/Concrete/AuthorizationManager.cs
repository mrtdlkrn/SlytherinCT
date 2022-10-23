using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class AuthorizationManager : IAuthorizationService
    {
        private readonly IAuthorizationDAL authorizationDAL;

        public AuthorizationManager(IAuthorizationDAL authorizationDAL)
        {
            this.authorizationDAL = authorizationDAL;
        }

        public IResult Add(Authorization entity)
        {
            var authorizationResult = Get();

            if (authorizationResult.Success) return new ErrorResult("Yetki zaten kayıtlı.", 404);

            try
            {
                authorizationDAL.Add(entity);
            }
            catch (Exception)
            {
                return new ErrorResult("Yetki kayıt edilirken bir hata oluştu.", 404);
            }

            return new SuccessResult("Yetki başarılı bir şekilde kayıt edildi.", 200);
        }

        public IResult Delete(object id)
        {
            var authorizationResult = GetById(id);

            if (!authorizationResult.Success) return new ErrorResult(authorizationResult.Message, authorizationResult.StatusCode);

            try
            {
                authorizationDAL.Delete(authorizationResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("Yetki silinirken bir hata oluştu.", 404);
            }
            return new SuccessResult("Yetki başarılı bir şekilde silindi.", 200);
        }

        public IDataResult<Authorization> Get(Expression<Func<Authorization, bool>> filter = null)
        {
            var authorizationResult = authorizationDAL.GetAsync(filter);

            if (authorizationResult.Result == null) return new ErrorDataResult<Authorization>("Yeti bulunamadı.", 404);
            return new SuccessDataResult<Authorization>(authorizationResult.Result, "Yetki getirildi.", 200);
        }

        public IDataResult<IEnumerable<Authorization>> GetAll(Expression<Func<Authorization, bool>> filter = null)
        {
            var authorizationResult = authorizationDAL.GetAllAsync(filter);

            if (authorizationResult.Result == null) return new ErrorDataResult<IEnumerable<Authorization>>("Listelenecek yetki bulunamadı.", 404);
            return new SuccessDataResult<IEnumerable<Authorization>>(authorizationResult.Result, "Yetkiler listelendi.", 200);
        }

        public IDataResult<Authorization> GetById(object id)
        {
            var authorizationResult = authorizationDAL.GetAsync(x => x.ID == (int)id);

            if (authorizationResult.Result == null) return new ErrorDataResult<Authorization("Yetki bulunamadı.", 404);
            return new SuccessDataResult<Authorization>(authorizationResult.Result, "Yetki getirildi.", 200);
        }

        public IResult Update(Authorization entity)
        {
            var authorizationResult = GetById(entity.ID);
            if (!authorizationResult.Success) return new ErrorResult(authorizationResult.Message, authorizationResult.StatusCode);

            try
            {
                authorizationDAL.Update(authorizationResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("Yetki güncellenirken bir hata oluştu.", 404);
            }

            return new SuccessResult("Yetki başarılı bir şekilde güncellendi.", 200);
        }
    }
}
