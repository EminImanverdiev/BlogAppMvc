using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
    }
}
