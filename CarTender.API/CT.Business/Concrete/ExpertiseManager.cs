using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class ExpertiseManager : IExpertiseService
    {
        private readonly IExpertiseDAL expertiseDAL;

        public ExpertiseManager(IExpertiseDAL expertiseDAL)
        {
            this.expertiseDAL = expertiseDAL;
        }

        public IResult Add(Expertise entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Expertise> Get(Expression<Func<Expertise, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Expertise>> GetAll(Expression<Func<Expertise, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Expertise> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Expertise entity)
        {
            throw new NotImplementedException();
        }
    }
}
