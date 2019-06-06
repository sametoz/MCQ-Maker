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
    public class RoleLogic : IGenericService<Role>
    {
        readonly ProjeContext ProjeContext;
        public RoleLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Role Create(Role Entity)
        {
            ProjeContext.Role.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Role Entity)
        {
            ProjeContext.Role.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Role Get(int id)
        {
            return ProjeContext.Role.Where(x => x.RoleID == id).SingleOrDefault();
        }

        public List<Role> GetAll()
        {
            return ProjeContext.Role.ToList();
        }

        public List<Role> GetAll(Expression<Func<Role, bool>> Filter)
        {
            return ProjeContext.Role.Where(Filter).ToList();
        }
        public int Set(Role Entity)
        {
            ProjeContext.Set<Role>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
