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
    public class AdvertLogic : IGenericService<Advert>
    {
        readonly ProjeContext ProjeContext;
        public AdvertLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Advert Create(Advert Entity)
        {
            ProjeContext.Advert.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Advert Entity)
        {
            ProjeContext.Advert.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Advert Get(int id)
        {
            return ProjeContext.Advert.Where(x => x.AdvertID == id).SingleOrDefault();
        }

        public List<Advert> GetAll()
        {
            return ProjeContext.Advert.ToList();
        }

        public List<Advert> GetAll(Expression<Func<Advert, bool>> Filter)
        {
            return ProjeContext.Advert.Where(Filter).ToList();
        }

        public int Set(Advert Entity)
        {
            ProjeContext.Set<Advert>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
