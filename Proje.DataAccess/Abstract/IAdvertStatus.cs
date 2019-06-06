using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
    public interface IAdvertStatus
    {
        AdvertStatus Create(AdvertStatus Entity);
        List<AdvertStatus> Get();
        List<AdvertStatus> Get(Expression<Func<AdvertStatus, bool>> Filter);
        AdvertStatus Get(int id);
        int Set(AdvertStatus Entity);
        bool Delete(AdvertStatus Entity);
        bool Delete(int id);
    }
}
