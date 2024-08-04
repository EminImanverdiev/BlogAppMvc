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
	public class WriterManager:IWriterService
	{
		IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public void Add(Writer writer)
		{
			_writerDal.Add(writer);
		}

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int Id)
        {
            return _writerDal.GetAll(w=>w.WriterId==Id);
        }

        public void Remove(Writer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer entity)
        {
            throw new NotImplementedException();
        }
    }
}
