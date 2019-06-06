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
    public class UserLocationLogic : IGenericService<UserLocation>
    {
        readonly ProjeContext ProjeContext;
        public UserLocationLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public UserLocation Create(UserLocation Entity)
        {
            ProjeContext.UserLocation.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(UserLocation Entity)
        {
            ProjeContext.UserLocation.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public UserLocation Get(int id)
        {
            return ProjeContext.UserLocation.Where(x => x.UserLocationId == id).SingleOrDefault();
        }

        public List<UserLocation> GetAll()
        {
            return ProjeContext.UserLocation.ToList();
        }

        public List<UserLocation> GetAll(Expression<Func<UserLocation, bool>> Filter)
        {
            return ProjeContext.UserLocation.Where(Filter).ToList();
        }

        public int Set(UserLocation Entity)
        {
            ProjeContext.Set<UserLocation>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
