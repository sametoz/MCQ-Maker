using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IUserPassword
    {
        UserPassword Create(UserPassword Entity);
        List<UserPassword> Get();
        List<UserPassword> Get(Expression<Func<UserPassword, bool>> Filter);
        UserPassword Get(int id);
        int Set(UserPassword Entity);
        bool Delete(UserPassword Entity);
        bool Delete(int id);
    }
}
