using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Proje.DataAccess.Abstract
{
   public interface ICity
    {
        City Create(City Entity);
        List<City> Get();
        List<City> Get(Expression<Func<City, bool>> Filter);
        City Get(int id);
        int Set(City Entity);
        bool Delete(City Entity);
        bool Delete(int id);
    }
}
