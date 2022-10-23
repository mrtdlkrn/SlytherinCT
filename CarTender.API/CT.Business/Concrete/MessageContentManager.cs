using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.DataAccess.Abstract;
using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.Business.Concrete
{
    public class MessageContentManager : IMessageContentService
    {
        private readonly IMessageContentDAL messageContentDAL;

        public MessageContentManager(IMessageContentDAL messageContentDAL)
        {
            this.messageContentDAL = messageContentDAL;
        }

        public IResult Add(MessageContent entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MessageContent> Get(Expression<Func<MessageContent, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<MessageContent>> GetAll(Expression<Func<MessageContent, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MessageContent> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MessageContent entity)
        {
            throw new NotImplementedException();
        }
    }
}
