using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Proje.DataAccess.Abstract
{
   public interface IRegisterTemp
    {
        RegisterTemp Create(RegisterTemp Entity);
        List<RegisterTemp> Get();
        List<RegisterTemp> Get(Expression<Func<RegisterTemp, bool>> Filter);
        RegisterTemp Get(int id);
        int Set(RegisterTemp Entity);
        bool Delete(RegisterTemp Entity);
        bool Delete(int id);
    }
}
