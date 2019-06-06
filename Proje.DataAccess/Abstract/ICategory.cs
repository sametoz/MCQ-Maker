using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public interface ICategory
    {
        Category Create(Category Entity);
        List<Category> Get();
        List<Category> Get(Expression<Func<Category, bool>> Filter);
        Category Get(int id);
        int Set(Category Entity);
        bool Delete(Category Entity);
        bool Delete(int id);
    }
}
