using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IPhone
    {
        Phone Create(Phone Entity);
        List<Phone> Get();
        List<Phone> Get(Expression<Func<Phone, bool>> Filter);
        Phone Get(int id);
        int Set(Phone Entity);
        bool Delete(Phone Entity);
        bool Delete(int id);
    }
}
