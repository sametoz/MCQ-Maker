using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Proje.DataAccess.Abstract
{
   public interface IUnivercity
    {
        Univercity Create(Univercity Entity);
        List<Univercity> Get();
        List<Univercity> Get(Expression<Func<Univercity, bool>> Filter);
        Univercity Get(int id);
        int Set(Univercity Entity);
        bool Delete(Univercity Entity);
        bool Delete(int id);
    }
}
