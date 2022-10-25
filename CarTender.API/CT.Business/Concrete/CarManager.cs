using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDAL carDAL;

        public CarManager(ICarDAL carDAL)
        {
            this.carDAL = carDAL;
        }

        public IResult Add(Car entity)
        {
            var carResult = Get();

            if (carResult.Success) return new ErrorResult("Araba zaten kayıtlı.", 404);

            try
            {
                carDAL.Add(entity);
            }
            catch (Exception)
            {
                return new ErrorResult("Araba kayıt edilirken bir hata oluştu.", 404);
            }

            return new SuccessResult("Araba başarılı bir şekilde kayıt edildi.", 200);
        }

        public IResult Delete(object id)
        {
            var carResult = GetById(id);

            if (!carResult.Success) return new ErrorResult(carResult.Message, carResult.StatusCode);

            try
            {
                carDAL.Delete(carResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("Araba silinirken bir hata oluştu.", 404);
            }
            return new SuccessResult("Araba başarılı bir şekilde silindi.", 200);
        }

        public IDataResult<Car> Get(Expression<Func<Car, bool>> filter = null)
        {
            var carResult = carDAL.GetAsync(filter);

            if (carResult.Result == null) return new ErrorDataResult<Car>("Araba bulunamadı.", 404);
            return new SuccessDataResult<Car>(carResult.Result, "Araba getirildi.", 200);
        }

        public IDataResult<IEnumerable<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            var carResult = carDAL.GetAllAsync(filter);

            if (carResult.Result == null) return new ErrorDataResult<IEnumerable<Car>>("Listelenecek arba bulunamadı.", 404);
            return new SuccessDataResult<IEnumerable<Car>>(carResult.Result, "Arabalar listelendi.", 200);
        }

        public IDataResult<Car> GetById(object id)
        {
            var carResult = carDAL.GetAsync(x => x.ID == (int)id);

            if (carResult.Result == null) return new ErrorDataResult<Car>("Araba bulunamadı.", 404);
            return new SuccessDataResult<Car>(carResult.Result, "Araba getirildi.", 200);
        }

        public IResult Update(Car entity)
        {
            var carResult = GetById(entity.ID);
            if (!carResult.Success) return new ErrorResult(carResult.Message, carResult.StatusCode);

            try
            {
                carDAL.Update(carResult.Data);
            }
            catch (Exception)
            {
                return new ErrorResult("Araba güncellenirken bir hata oluştu.", 404);
            }

            return new SuccessResult("Araba başarılı bir şekilde güncellendi.", 200);
        }
    }
}
