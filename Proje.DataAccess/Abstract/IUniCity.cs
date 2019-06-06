using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Proje.DataAccess.Abstract
{
  public  interface IUniCity
    {
        UniCity Create(UniCity Entity);
        List<UniCity> Get();
        List<UniCity> Get(Expression<Func<UniCity, bool>> Filter);
        UniCity Get(int id);
        int Set(UniCity Entity);
        bool Delete(UniCity Entity);
        bool Delete(int id);
    }
}
