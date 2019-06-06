using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
    public interface IMessage
    {
        Message Create(Message Entity);
        List<Message> Get();
        List<Message> Get(Expression<Func<Message, bool>> Filter);
        Message Get(int id);
        int Set(Message Entity);
        bool Delete(Message Entity);
        bool Delete(int id);
    }
}
