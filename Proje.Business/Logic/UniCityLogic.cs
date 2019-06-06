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
    public class UniCityLogic : IGenericService<UniCity>
    {
        readonly ProjeContext ProjeContext;
        public UniCityLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public UniCity Create(UniCity Entity)
        {
            ProjeContext.UniCity.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(UniCity Entity)
        {
            ProjeContext.UniCity.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public UniCity Get(int id)
        {
            return ProjeContext.UniCity.Where(x => x.UniCityID == id).SingleOrDefault();
        }

        public List<UniCity> GetAll()
        {
            return ProjeContext.UniCity.ToList();
        }

        public List<UniCity> GetAll(Expression<Func<UniCity, bool>> Filter)
        {
            return ProjeContext.UniCity.Where(Filter).ToList();
        }

        public int Set(UniCity Entity)
        {
            ProjeContext.Set<UniCity>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
