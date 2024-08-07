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
    public class SeconMessageManager : ISecondMessageService
    {
        ISecondMessageDal _secondMessageDal;

        public SeconMessageManager(ISecondMessageDal secondMessageDal)
        {
            _secondMessageDal = secondMessageDal;
        }

        public void Add(SecondMessage entity)
        {
            throw new NotImplementedException();
        }

        public List<SecondMessage> GetAll()
        {
            return _secondMessageDal.GetAll();
        }

        public SecondMessage GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<SecondMessage> GetInboxListByWriter(int Id)
        {
            return _secondMessageDal.GetAllWithMessageByWriter(Id);
        }

        public void Remove(SecondMessage entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SecondMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
