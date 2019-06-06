using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Proje.Entity.Model;
using Proje.Interface;
using Proje.DataAccess.Abstract;
using Proje.DataAccess.Context;
using System.Linq;

namespace Proje.Business.Logic
{
    public class AdvertStatusLogic : IGenericService<AdvertStatus>
    {
        readonly ProjeContext ProjeContext;
        public AdvertStatusLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public AdvertStatus Create(AdvertStatus Entity)
        {
            ProjeContext.AdvertStatus.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(AdvertStatus Entity)
        {
            ProjeContext.AdvertStatus.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public AdvertStatus Get(int id)
        {
            return ProjeContext.AdvertStatus.Where(x => x.AdvertStatusID == id).SingleOrDefault();
        }

        public List<AdvertStatus> GetAll()
        {
            return ProjeContext.AdvertStatus.ToList();
        }

        public List<AdvertStatus> GetAll(Expression<Func<AdvertStatus, bool>> Filter)
        {
            return ProjeContext.AdvertStatus.Where(Filter).ToList();
        }
        
        public int Set(AdvertStatus Entity)
        {
            ProjeContext.Set<AdvertStatus>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
