using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class NeighborhoodManager : INeighborhoodService
    {
        private readonly INeighborhoodDAL neighborhoodDAL;

        public NeighborhoodManager(INeighborhoodDAL neighborhoodDAL)
        {
            this.neighborhoodDAL = neighborhoodDAL;
        }

        public IResult Add(Neighborhood entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Neighborhood> Get(Expression<Func<Neighborhood, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Neighborhood>> GetAll(Expression<Func<Neighborhood, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Neighborhood> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Neighborhood entity)
        {
            throw new NotImplementedException();
        }
    }
}
