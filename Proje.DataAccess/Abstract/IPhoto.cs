using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
    public interface IPhoto
    {
        Photo Create(Photo Entity);
        List<Photo> Get();
        List<Photo> Get(Expression<Func<Photo, bool>> Filter);
        Photo Get(int id);
        int Set(Photo Entity);
        bool Delete(Photo Entity);
        bool Delete(int id);
    }
}
