using CarTender.Business.Abstract;
using CarTender.Core.Utilities;
using CarTender.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CarTender.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDAL userDAL;

        public UserManager(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public IResult Add(User entity)
        {
            var userCheckResult = IsUserExist(entity.Email);

            if (userCheckResult.Success) return new ErrorResult(userCheckResult.Message, userCheckResult.StatusCode);

            try
            {
                userDAL.Add(entity);
            }
            catch (Exception)
            {
                return new ErrorResult(entity.Username + " kullanıcısını kayıt ederken bir hata oluştu.", 404);
            }

            return new SuccessResult(entity.Username + " kullanıcısı başarılı bir şekilde kayıt edildi.", 200);
        }

        public IResult Delete(object id)
        {
            var userCheckResult = GetById(id);
            if (!userCheckResult.Success) return new ErrorResult(userCheckResult.Message, userCheckResult.StatusCode);

            try
            {
                userDAL.Delete(userCheckResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult(userCheckResult.Data.Username + " kullanıcısını silerken bir hata oluştu.", 404);                
            }

            return new SuccessResult(userCheckResult.Data.Username + " kullanıcısı başarılı bir şekilde silindi.", 200);
        }

        public IDataResult<User> Get(Expression<Func<User, bool>> filter = null)
        {
            var userResult = userDAL.GetAsync(filter);

            if (userResult.Result == null) return new ErrorDataResult<User>("Kullanıcı bulunamadı.", 404);
            return new SuccessDataResult<User>(userResult.Result, "Kullanıcı getirildi.", 200);
        }

        public IDataResult<IEnumerable<User>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            // todo: kullanıcı listesi boş ise boş liste mi döndüreceğiz, hata mesajı mı döndüreceğiz?
            var usersResult = userDAL.GetAllAsync(filter);

            if (usersResult.Result == null) return new ErrorDataResult<IEnumerable<User>>("Listelenecek kullanıcı bulunamadı.",404);
            return new SuccessDataResult<IEnumerable<User>>(usersResult.Result,"Kullanıcılar listelendi.",200);
        }

        public IDataResult<User> GetById(object id)
        {
            var userResult = userDAL.GetAsync(u => u.Id == (int)id);

            if (userResult.Result == null) return new ErrorDataResult<User>((int)id+ " ID'li kullanıcı bulunamadı.",404);
            return new SuccessDataResult<User>(userResult.Result, (int)id + " ID'li kullanıcı getirildi.", 200);
        }

        public IDataResult<User> GetByUserName(string userName)
        {
            var userResult = userDAL.GetAsync(u => u.Username == userName);

            if (userResult.Result == null) return new ErrorDataResult<User>(userName + " kullanıcısı bulunamadı.", 404);
            return new SuccessDataResult<User>(userResult.Result,userName+ " kullanıcısı getirildi.", 200);
        }

        public IResult IsUserExist(string email)
        {
            var checkResult = userDAL.GetAsync(u => u.Email == email);

            if (checkResult.Result == null) return new ErrorResult(email + " kullanıcısı bulunamadı.", 404);
            return new SuccessResult(email + " kullanıcısı mevcut.", 200);
        }

        public IResult Update(User entity)
        {
            var userCheckResult = GetById(entity.Id);
            if (!userCheckResult.Success) return new ErrorResult(userCheckResult.Message, userCheckResult.StatusCode);

            try
            {
                userDAL.Update(userCheckResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult(userCheckResult.Data.Username + " kullanıcısını güncellenirken bir hata oluştu.", 404);
            }

            return new SuccessResult(userCheckResult.Data.Username + " kullanıcısı başarılı bir şekilde güncellendi.", 200);
        }
    }
}
