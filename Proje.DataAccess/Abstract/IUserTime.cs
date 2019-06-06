using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IUserTime
    {
        UserTime Create(UserTime Entity);
        List<UserTime> Get();
        List<UserTime> Get(Expression<Func<UserTime, bool>> Filter);
        UserTime Get(int id);
        int Set(UserTime Entity);
        bool Delete(UserTime Entity);
        bool Delete(int id);
    }
}
