using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper;
using CT.Entities.DTOs.Town;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CT.Business.Concrete
{
    public class TownManager : ITownService
    {
        private readonly ITownDAL townDAL;

        public TownManager(ITownDAL townDAL)
        {
            this.townDAL = townDAL;
        }

        public IResult Add(Town entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Town> Get(Expression<Func<Town, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<ListTownDTO>>> GetAll(Expression<Func<Town, bool>> filter = null)
        {
            var result = await townDAL.GetAllAsync(filter);

            if (result == null) return new ErrorDataResult<IEnumerable<ListTownDTO>>("Listelenecek ilçeler bulunamadı.", 404);
            return new SuccessDataResult<IEnumerable<ListTownDTO>>(result, "İlçeler listelendi.", 200);
        }

        public IDataResult<Town> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Town entity)
        {
            throw new NotImplementedException();
        }
    }
}
