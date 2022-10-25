using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class AdvertStatusHistoryManager : IAdvertStatusHistoryService
    {
        private readonly IAdverStatusHistoryDAL adverStatusHistoryDAL;

        public AdvertStatusHistoryManager(IAdverStatusHistoryDAL adverStatusHistoryDAL)
        {
            this.adverStatusHistoryDAL = adverStatusHistoryDAL;
        }

        public IResult Add(AdvertStatusHistory entity)
        {
            var advertStatusHistoryCheckResult = Get();

            if (advertStatusHistoryCheckResult.Success) return new ErrorResult("İlan statü geçmişi zaten kayıtlı.", 404);

            try
            {
                adverStatusHistoryDAL.Add(entity);
            }
            catch (Exception)
            {
                return new ErrorResult("İlan statü geçmişi kayıt edilirken bir hata oluştu.", 404);
            }

            return new SuccessResult("İlan statü geçmişi başarılı bir şekilde kayıt edildi.", 200);
        }

        public IResult Delete(object id)
        {
            var advertStatusHistoryCheckResult = GetById(id);

            if (!advertStatusHistoryCheckResult.Success) return new ErrorResult(advertStatusHistoryCheckResult.Message, advertStatusHistoryCheckResult.StatusCode);

            try
            {
                adverStatusHistoryDAL.Delete(advertStatusHistoryCheckResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("İlan statü geçmişi silinirken bir hata oluştu.", 404);
            }
            return new SuccessResult("İlan statü geçmişi başarılı bir şekilde silindi.", 200);
        }

        public IDataResult<AdvertStatusHistory> Get(Expression<Func<AdvertStatusHistory, bool>> filter = null)
        {
            var advertStatusHistoryResult = adverStatusHistoryDAL.GetAsync(filter);

            if (advertStatusHistoryResult.Result == null) return new ErrorDataResult<AdvertStatusHistory>("İlan statü geçmişi bulunamadı.", 404);
            return new SuccessDataResult<AdvertStatusHistory>(advertStatusHistoryResult.Result, "İlan statü geçmişi getirildi.", 200);
        }

        public IDataResult<IEnumerable<AdvertStatusHistory>> GetAll(Expression<Func<AdvertStatusHistory, bool>> filter = null)
        {
            var advertStatusHistoryResult = adverStatusHistoryDAL.GetAllAsync(filter);

            if (advertStatusHistoryResult.Result == null) return new ErrorDataResult<IEnumerable<AdvertStatusHistory>>("Listelenecek ilan statü geçmişi bulunamadı.", 404);
            return new SuccessDataResult<IEnumerable<AdvertStatusHistory>>(advertStatusHistoryResult.Result, "İlan statü geçmişleri listelendi.", 200);
        }

        public IDataResult<AdvertStatusHistory> GetById(object id)
        {
            var advertStatusHistoryResult = adverStatusHistoryDAL.GetAsync(x => x.ID == (int)id);

            if (advertStatusHistoryResult.Result == null) return new ErrorDataResult<AdvertStatusHistory>("İlan statü geçmişi bulunamadı.", 404);
            return new SuccessDataResult<AdvertStatusHistory>(advertStatusHistoryResult.Result,"İlan statü geçmişi getirildi.", 200);
        }

        public IResult Update(AdvertStatusHistory entity)
        {
            var advertStatusHistoryResult = GetById(entity.ID);
            if (!advertStatusHistoryResult.Success) return new ErrorResult(advertStatusHistoryResult.Message, advertStatusHistoryResult.StatusCode);

            try
            {
                adverStatusHistoryDAL.Update(advertStatusHistoryResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("İlan statü geçmişi güncellenirken bir hata oluştu.", 404);
            }

            return new SuccessResult("İlan statü geçmişi başarılı bir şekilde güncellendi.", 200);
        }
    }
}
