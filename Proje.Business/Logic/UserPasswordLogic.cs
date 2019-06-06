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
    public class UserPasswordLogic : IGenericService<UserPassword>
    {
        readonly ProjeContext ProjeContext;
        public UserPasswordLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public UserPassword Create(UserPassword Entity)
        {
            ProjeContext.UserPassword.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(UserPassword Entity)
        {
            ProjeContext.UserPassword.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public UserPassword Get(int id)
        {
            return ProjeContext.UserPassword.Where(x => x.UserPasswordID == id).SingleOrDefault();
        }

        public List<UserPassword> GetAll()
        {
            return ProjeContext.UserPassword.ToList();
        }

        public List<UserPassword> GetAll(Expression<Func<UserPassword, bool>> Filter)
        {
            return ProjeContext.UserPassword.Where(Filter).ToList();
        }

        public int Set(UserPassword Entity)
        {
            ProjeContext.UserPassword.Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
