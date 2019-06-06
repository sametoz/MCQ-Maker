using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Proje.DataAccess.Abstract
{
   public interface IPassword
    {
        Password Create(Password Entity);
        List<Password> Get();
        List<Password> Get(Expression<Func<Password, bool>> Filter);
        Password Get(int id);
        int Set(Password Entity);
        bool Delete(Password Entity);
        bool Delete(int id);
    }
}
