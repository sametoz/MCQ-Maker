using Proje.DataAccess.Context;
using Proje.Entity.Model;
using Proje.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Proje.Business.Logic
{
    public class AdvertSeenUserLogic : IGenericService<AdvertSeenUser>
    {
        readonly ProjeContext ProjeContext;
        public AdvertSeenUserLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public AdvertSeenUser Create(AdvertSeenUser Entity)
        {
            ProjeContext.AdvertSeenUser.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(AdvertSeenUser Entity)
        {
            ProjeContext.AdvertSeenUser.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(item);
        }

        public AdvertSeenUser Get(int id)
        {
            return ProjeContext.AdvertSeenUser.Where(x => x.AdvertSeenUserID == id).SingleOrDefault();
        }

        public List<AdvertSeenUser> GetAll()
        {
            return ProjeContext.AdvertSeenUser.ToList();
        }

        public List<AdvertSeenUser> GetAll(Expression<Func<AdvertSeenUser, bool>> Filter)
        {
            return ProjeContext.AdvertSeenUser.Where(Filter).ToList();
        }

        public int Set(AdvertSeenUser Entity)
        {
            ProjeContext.Set<AdvertSeenUser>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
