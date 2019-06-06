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
    public class UserTimeLogic : IGenericService<UserTime>
    {
        readonly ProjeContext ProjeContext;
        public UserTimeLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public UserTime Create(UserTime Entity)
        {
            ProjeContext.UserTime.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(UserTime Entity)
        {
            ProjeContext.UserTime.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public UserTime Get(int id)
        {
            return ProjeContext.UserTime.Where(x => x.UserTimeID == id).SingleOrDefault();
        }

        public List<UserTime> GetAll()
        {
            return ProjeContext.UserTime.ToList();
        }

        public List<UserTime> GetAll(Expression<Func<UserTime, bool>> Filter)
        {
            return ProjeContext.UserTime.Where(Filter).ToList();
        }

        public int Set(UserTime Entity)
        {
            ProjeContext.UserTime.Update(Entity);
            return ProjeContext.SaveChanges();
        }

    }
}
