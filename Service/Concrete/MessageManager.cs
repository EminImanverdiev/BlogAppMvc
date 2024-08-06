using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message entity)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetAll(m=>m.MessageReceiver==p);
        }

        public Message GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Message entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
