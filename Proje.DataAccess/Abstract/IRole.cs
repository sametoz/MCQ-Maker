using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Proje.DataAccess.Abstract
{
   public interface IRole
    {
        Role Create(Role Entity);
        List<Role> Get();
        List<Role> Get(Expression<Func<Role, bool>> Filter);
        Role Get(int id);
        int Set(Role Entity);
        bool Delete(Role Entity);
        bool Delete(int id);
    }
}
