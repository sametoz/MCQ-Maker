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
    public class OldPasswordLogic : IGenericService<OldPassword>
    {
        readonly ProjeContext ProjeContext;
        public OldPasswordLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public OldPassword Create(OldPassword Entity)
        {
            ProjeContext.OldPasswords.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(OldPassword Entity)
        {
            ProjeContext.OldPasswords.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public OldPassword Get(int id)
        {
            return ProjeContext.OldPasswords.Where(x => x.OldPasswordID == id).SingleOrDefault();
        }

        public List<OldPassword> GetAll()
        {
            return ProjeContext.OldPasswords.ToList();
        }

        public List<OldPassword> GetAll(Expression<Func<OldPassword, bool>> Filter)
        {
            return ProjeContext.OldPasswords.Where(Filter).ToList();
        }

        public int Set(OldPassword Entity)
        {
            ProjeContext.Set<OldPassword>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
