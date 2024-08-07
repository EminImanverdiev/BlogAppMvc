using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSecondMessageDal : EfEntityRepositoryBase<SecondMessage, AppDbContext>, ISecondMessageDal
    {
        public List<SecondMessage> GetAllWithMessageByWriter(int Id)
        {
           using (var context = new AppDbContext())
            {
                return context
                    .secondMessages
                    .Include(x=>x.SenderUser)
                    .Where(y=>y.MessageReceiverId==Id)
                    .ToList();
            }
        }
    }
}
