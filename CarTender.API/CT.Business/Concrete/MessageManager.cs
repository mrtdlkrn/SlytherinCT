using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CT.Business.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDAL messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            this.messageDAL = messageDAL;
        }

        public IResult Add(Message entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Message> Get(Expression<Func<Message, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Message>> GetAll(Expression<Func<Message, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Message> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
