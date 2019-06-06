using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Interface
{
    public interface IGenericService<T> where T : class
    {
        T Create(T Entity);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> Filter);
        T Get(int id);
        int Set(T Entity);
        bool Delete(T Entity );
        bool Delete(int id);
    }
}
