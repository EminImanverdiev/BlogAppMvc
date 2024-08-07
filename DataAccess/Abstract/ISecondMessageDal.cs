using Core.DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ISecondMessageDal : IEntityRepository<SecondMessage>
    {
        List<SecondMessage> GetAllWithMessageByWriter(int Id);

    }

}
