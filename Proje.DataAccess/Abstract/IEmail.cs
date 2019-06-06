using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IEmail
    {
        Email Create(Email Entity);
        List<Email> Get();
        List<Email> Get(Expression<Func<Email, bool>> Filter);
        Email Get(int id);
        int Set(Email Entity);
        bool Delete(Email Entity);
        bool Delete(int id);
    }
}
