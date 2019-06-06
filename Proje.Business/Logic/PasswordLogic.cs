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
    public class PasswordLogic : IGenericService<Password>
    {
        readonly ProjeContext ProjeContext;
        public PasswordLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Password Create(Password Entity)
        {
            ProjeContext.Password.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Password Entity)
        {
            ProjeContext.Password.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Password Get(int id)
        {
            return ProjeContext.Password.Where(x => x.PasswordId == id).SingleOrDefault();
        }

        public List<Password> GetAll()
        {
            return ProjeContext.Password.ToList();
        }

        public List<Password> GetAll(Expression<Func<Password, bool>> Filter)
        {
            return ProjeContext.Password.Where(Filter).ToList();
        }


        public int Set(Password Entity)
        {
            ProjeContext.Set<Password>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
