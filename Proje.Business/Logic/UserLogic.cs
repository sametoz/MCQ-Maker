using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Proje.Entity.Model;
using Proje.DataAccess.Abstract;
using Proje.Interface;
using Proje.DataAccess.Context;
using System.Linq;

namespace Proje.Business.Logic
{
    public class UserLogic : IGenericService<User>
    {
        readonly ProjeContext ProjeContext;
        public UserLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public User Create(User Entity)
        {
            ProjeContext.User.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(User Entity)
        {
            ProjeContext.User.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(item);
        }

        public User Get(int id)

        {
            return ProjeContext.User.Where(x => x.UserID == id).SingleOrDefault();
        }

        public List<User> GetAll()
        {
            return ProjeContext.User.ToList();
        }

        public List<User> GetAll(Expression<Func<User, bool>> Filter)
        {
            return ProjeContext.User.Where(Filter).ToList();
        }

        public int Set(User Entity)
        {
            ProjeContext.Set<User>().Update(Entity);
            return ProjeContext.SaveChanges();
        }

    }
}
