using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    // todo: marka ve modelleri tek manager ile yonetmek biraz sıkıntı olabilir.
    public class BrandModelManager : IBrandModelService
    {
        private readonly IBrandModelDAL brandModelDAL;

        public BrandModelManager(IBrandModelDAL brandModelDAL)
        {
            this.brandModelDAL = brandModelDAL;
        }

        public IResult Add(BrandModel entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BrandModel> Get(Expression<Func<BrandModel, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<BrandModel>> GetAll(Expression<Func<BrandModel, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BrandModel> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BrandModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
