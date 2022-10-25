using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class BidManager : IBidService
    {
        private readonly IBidDAL bidDAL;

        public BidManager(IBidDAL bidDAL)
        {
            this.bidDAL = bidDAL;
        }

        public IResult Add(Bid entity)
        {
            var bidResult = Get();

            if (bidResult.Success) return new ErrorResult("İhale zaten kayıtlı.", 404);

            try
            {
                bidDAL.Add(entity);
            }
            catch (Exception)
            {
                return new ErrorResult("İhale kayıt edilirken bir hata oluştu.", 404);
            }

            return new SuccessResult("İhale başarılı bir şekilde kayıt edildi.", 200);
        }

        public IResult Delete(object id)
        {
            var bidResult = GetById(id);

            if (!bidResult.Success) return new ErrorResult(bidResult.Message, bidResult.StatusCode);

            try
            {
                bidDAL.Delete(bidResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("İhale silinirken bir hata oluştu.", 404);
            }
            return new SuccessResult("İhale başarılı bir şekilde silindi.", 200);
        }

        public IDataResult<Bid> Get(Expression<Func<Bid, bool>> filter = null)
        {
            var bidResult = bidDAL.GetAsync(filter);

            if (bidResult.Result == null) return new ErrorDataResult<Bid>("İhale bulunamadı.", 404);
            return new SuccessDataResult<Bid>(bidResult.Result, "İhale getirildi.", 200);
        }

        public IDataResult<IEnumerable<Bid>> GetAll(Expression<Func<Bid, bool>> filter = null)
        {
            var bidResult = bidDAL.GetAllAsync(filter);

            if (bidResult.Result == null) return new ErrorDataResult<IEnumerable<Bid>>("Listelenecek ihale bulunamadı.", 404);
            return new SuccessDataResult<IEnumerable<Bid>>(bidResult.Result, "İhaleler listelendi.", 200);
        }

        public IDataResult<Bid> GetById(object id)
        {
            var bidResult = bidDAL.GetAsync(x => x.ID == (int)id);

            if (bidResult.Result == null) return new ErrorDataResult<Bid>("İhale bulunamadı.", 404);
            return new SuccessDataResult<Bid>(bidResult.Result, "İhale getirildi.", 200);
        }

        public IResult Update(Bid entity)
        {
            var bidResult = GetById(entity.ID);
            if (!bidResult.Success) return new ErrorResult(bidResult.Message, bidResult.StatusCode);

            try
            {
                bidDAL.Update(bidResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("İhale güncellenirken bir hata oluştu.", 404);
            }

            return new SuccessResult("İhale başarılı bir şekilde güncellendi.", 200);
        }
    }
}
