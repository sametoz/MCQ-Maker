using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IUser
    {
        User Create(User Entity);
        List<User> Get();
        List<User> Get(Expression<Func<User, bool>> Filter);
        User Get(int id);
        int Set(User Entity);
        bool Delete(User Entity);
        bool Delete(int id);
    }
}
