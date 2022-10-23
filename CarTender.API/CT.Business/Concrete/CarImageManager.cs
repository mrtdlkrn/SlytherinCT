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
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDAL carImageDAL;

        public CarImageManager(ICarImageDAL carImageDAL)
        {
            this.carImageDAL = carImageDAL;
        }

        public IResult Add(CarImage entity)
        {
            var carImageResult = Get();

            if (carImageResult.Success) return new ErrorResult("Fotoğraf zaten kayıtlı.", 404);

            try
            {
                carImageDAL.Add(entity);
            }
            catch (Exception)
            {
                return new ErrorResult("Fotoğraf kayıt edilirken bir hata oluştu.", 404);
            }

            return new SuccessResult("Fotoğraf başarılı bir şekilde kayıt edildi.", 200);
        }

        public IResult Delete(object id)
        {
            var carImageResult = GetById(id);

            if (!carImageResult.Success) return new ErrorResult(carImageResult.Message, carImageResult.StatusCode);

            try
            {
                carImageDAL.Delete(carImageResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("Fotoğraf silinirken bir hata oluştu.", 404);
            }
            return new SuccessResult("Fotoğraf başarılı bir şekilde silindi.", 200);
        }

        public IDataResult<CarImage> Get(Expression<Func<CarImage, bool>> filter = null)
        {
            var carImageResult = carImageDAL.GetAsync(filter);

            if (carImageResult.Result == null) return new ErrorDataResult<CarImage>("Fotoğraf bulunamadı.", 404);
            return new SuccessDataResult<CarImage>(carImageResult.Result, "Fotoğraf getirildi.", 200);
        }

        public IDataResult<IEnumerable<CarImage>> GetAll(Expression<Func<CarImage, bool>> filter = null)
        {
            var carImageResult = carImageDAL.GetAllAsync(filter);

            if (carImageResult.Result == null) return new ErrorDataResult<IEnumerable<CarImage>>("Listelenecek Fotoğraf bulunamadı.", 404);
            return new SuccessDataResult<IEnumerable<CarImage>>(carImageResult.Result, "Fotoğraflar listelendi.", 200);
        }

        public IDataResult<CarImage> GetById(object id)
        {
            var carImageResult = carImageDAL.GetAsync(x => x.ID == (int)id);

            if (carImageResult.Result == null) return new ErrorDataResult<CarImage("Fotoğraf bulunamadı.", 404);
            return new SuccessDataResult<CarImage>(carImageResult.Result, "Fotoğraf getirildi.", 200);
        }

        public IResult Update(CarImage entity)
        {
            var carImageResult = GetById(entity.ID);
            if (!carImageResult.Success) return new ErrorResult(carImageResult.Message, carImageResult.StatusCode);

            try
            {
                carImageDAL.Update(carImageResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("Fotoğraf güncellenirken bir hata oluştu.", 404);
            }

            return new SuccessResult("Fotoğraf başarılı bir şekilde güncellendi.", 200);
        }
    }
}
