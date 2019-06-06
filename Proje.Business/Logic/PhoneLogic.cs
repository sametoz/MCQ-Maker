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
    public class PhoneLogic : IGenericService<Phone>
    {
        readonly ProjeContext ProjeContext;
        public PhoneLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Phone Create(Phone Entity)
        {
            ProjeContext.Phone.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Phone Entity)
        {
            ProjeContext.Phone.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Phone Get(int id)
        {
            return ProjeContext.Phone.Where(x => x.PhoneID == id).SingleOrDefault();
        }

        public List<Phone> GetAll()
        {
            return ProjeContext.Phone.ToList();
        }

        public List<Phone> GetAll(Expression<Func<Phone, bool>> Filter)
        {
            return ProjeContext.Phone.Where(Filter).ToList();
        }

        public int Set(Phone Entity)
        {
            ProjeContext.Set<Phone>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
