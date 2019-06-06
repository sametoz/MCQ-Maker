using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface IAdvert
    {
        Advert Create(Advert Entity);
        List<Advert> Get();
        List<Advert> Get(Expression<Func<Advert,bool>> Filter);
        Advert Get(int id);
        int Set(Advert Entity);
        bool Delete(Advert Entity);
        bool Delete(int id);
    }
}
