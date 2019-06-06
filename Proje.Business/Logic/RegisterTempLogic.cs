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
    public class RegisterTempLogic : IGenericService<RegisterTemp>
    {
        readonly ProjeContext ProjeContext;
        public RegisterTempLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public RegisterTemp Create(RegisterTemp Entity)
        {
            ProjeContext.RegisterTemp.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(RegisterTemp Entity)
        {
            ProjeContext.RegisterTemp.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public RegisterTemp Get(int id)
        {
            return ProjeContext.RegisterTemp.Where(x => x.RegisterTempID == id).SingleOrDefault();
        }

        public List<RegisterTemp> GetAll()
        {
            return ProjeContext.RegisterTemp.ToList();
        }

        public List<RegisterTemp> GetAll(Expression<Func<RegisterTemp, bool>> Filter)
        {
            return ProjeContext.RegisterTemp.Where(Filter).ToList();
        }


        public int Set(RegisterTemp Entity)
        {
            ProjeContext.Set<RegisterTemp>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
