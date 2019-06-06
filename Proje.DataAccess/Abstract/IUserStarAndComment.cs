using Proje.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
  public  interface IUserStarAndComment
    {
        UserStarAndComment Create(UserStarAndComment Entity);
        List<UserStarAndComment> Get();
        List<UserStarAndComment> Get(Expression<Func<UserStarAndComment, bool>> Filter);
        UserStarAndComment Get(int id);
        int Set(UserStarAndComment Entity);
        bool Delete(UserStarAndComment Entity);
        bool Delete(int id);
    }
}
