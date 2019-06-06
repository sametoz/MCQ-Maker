using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IOldPassword
    {
        OldPassword Create(OldPassword Entity);
        List<OldPassword> Get();
        List<OldPassword> Get(Expression<Func<OldPassword, bool>> Filter);
        OldPassword Get(int id);
        int Set(OldPassword Entity);
        bool Delete(OldPassword Entity);
        bool Delete(int id);
    }
}
