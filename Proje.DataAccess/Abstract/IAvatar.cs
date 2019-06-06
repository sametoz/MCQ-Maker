using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
    public interface IAvatar
    {
        Avatar Create(Avatar Entity);
        List<Avatar> Get();
        List<Avatar> Get(Expression<Func<Avatar, bool>> Filter);
        Avatar Get(int id);
        int Set(Avatar Entity);
        bool Delete(Avatar Entity);
        bool Delete(int id);
    }
}
