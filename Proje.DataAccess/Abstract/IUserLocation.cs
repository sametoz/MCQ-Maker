using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Proje.DataAccess.Abstract
{
    public interface IUserLocation
    {
        UserLocation Create(UserLocation Entity);
        List<UserLocation> Get();
        List<UserLocation> Get(Expression<Func<UserLocation, bool>> Filter);
        UserLocation Get(int id);
        int Set(UserLocation Entity);
        bool Delete(UserLocation Entity);
        bool Delete(int id);
    }
}
