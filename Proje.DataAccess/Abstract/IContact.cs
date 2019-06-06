using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IContact
    {
        Contact Create(Contact Entity);
        List<Contact> Get();
        List<Contact> Get(Expression<Func<Contact, bool>> Filter);
        Contact Get(int id);
        int Set(Contact Entity);
        bool Delete(Contact Entity);
        bool Delete(int id);
    }
}
