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
    public class UnivercityLogic :IGenericService<Univercity>
    {
        IGenericService<Univercity> Univercity;
        readonly ProjeContext ProjeContext;
        public UnivercityLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Univercity Create(Univercity Entity)
        {
            ProjeContext.Univercity.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Univercity Entity)
        {
            ProjeContext.Univercity.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Univercity Get(int id)
        {
            return ProjeContext.Univercity.Where(x => x.UnivercityID == id).SingleOrDefault();
        }

        public List<Univercity> GetAll()
        {
            return ProjeContext.Univercity.ToList();
        }

        public List<Univercity> GetAll(Expression<Func<Univercity, bool>> Filter)
        {
            return ProjeContext.Univercity.Where(Filter).ToList();
        }

        public int Set(Univercity Entity)
        {
            ProjeContext.Univercity.Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
