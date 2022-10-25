using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class AdvertManager : IAdvertService
    {
        private readonly IAdvertDAL advertDAL;

        public AdvertManager(IAdvertDAL advertDAL)
        {
            this.advertDAL = advertDAL;
        }

        public IResult Add(Advert entity)
        {
            // todo: Get içerisine geçerli arama filtresi girilecek.
            var advertResult = Get();

            if (advertResult.Success) return new ErrorResult("İlan zaten kayıtlı.",404);

            try
            {
                advertDAL.Add(entity);
            }
            catch (Exception)
            {
                return new ErrorResult("İlanı kayıt ederken bir hata oluştu.", 404);                
            }

            return new SuccessResult("İlan başarılı bir şekilde kayıt edildi.", 200);
        }

        public IResult Delete(object id)
        {
            var advertResult = GetById(id);

            if (!advertResult.Success) return new ErrorResult(advertResult.Message, advertResult.StatusCode);

            try
            {
                advertDAL.Delete(advertResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("İlanı silerken bir hata oluştu.", 404);
            }
            return new SuccessResult("İlan başarılı bir şekilde silindi.", 200);
        }

        public IDataResult<Advert> Get(Expression<Func<Advert, bool>> filter = null)
        {
            var advertResult = advertDAL.GetAsync(filter);

            if (advertResult.Result == null) return new ErrorDataResult<Advert>("İlan bulunamadı.", 404);
            return new SuccessDataResult<Advert>(advertResult.Result, "İlan getirildi.", 200);
        }

        public IDataResult<IEnumerable<Advert>> GetAll(Expression<Func<Advert, bool>> filter = null)
        {
            var advertResult = advertDAL.GetAllAsync(filter);

            if (advertResult.Result == null) return new ErrorDataResult<IEnumerable<Advert>>("Listelenecek ilan bulunamadı.", 404);
            return new SuccessDataResult<IEnumerable<Advert>>(advertResult.Result, "İlanlar listelendi.", 200);
        }

        public IDataResult<Advert> GetById(object id)
        {
            var advertResult = advertDAL.GetAsync(x => x.ID == (int)id);

            if (advertResult.Result == null) return new ErrorDataResult<Advert>("İlan bulunamadı.", 404);
            return new SuccessDataResult<Advert>(advertResult.Result, "İlan getirildi.", 200);
        }

        public IResult Update(Advert entity)
        {            
            var advertResult = GetById(entity.ID);
            if (!advertResult.Success) return new ErrorResult(advertResult.Message, advertResult.StatusCode);

            try
            {
                advertDAL.Update(advertResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("İlan güncellenirken bir hata oluştu.", 404);
            }

            return new SuccessResult("İlan başarılı bir şekilde güncellendi.", 200);
        }
    }
}
