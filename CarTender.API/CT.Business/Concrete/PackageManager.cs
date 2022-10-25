using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class PackageManager : IPackageService
    {
        private readonly IPackageDAL packageDAL;

        public PackageManager(IPackageDAL packageDAL)
        {
            this.packageDAL = packageDAL;
        }

        public IResult Add(Package entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Package> Get(Expression<Func<Package, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Package>> GetAll(Expression<Func<Package, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Package> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Package entity)
        {
            throw new NotImplementedException();
        }
    }
}
