using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface ISharedPhoto
    {
        SharedPhoto Create(SharedPhoto Entity);
        List<SharedPhoto> Get();
        List<SharedPhoto> Get(Expression<Func<SharedPhoto, bool>> Filter);
        SharedPhoto Get(int id);
        int Set(SharedPhoto Entity);
        bool Delete(SharedPhoto Entity);
        bool Delete(int id);
    }
}
