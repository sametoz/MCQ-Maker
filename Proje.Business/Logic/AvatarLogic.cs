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
    public class AvatarLogic : IGenericService<Avatar>
    {
        readonly ProjeContext ProjeContext;
        public AvatarLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Avatar Create(Avatar Entity)
        {
            ProjeContext.Avatar.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Avatar Entity)
        {
            ProjeContext.Avatar.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Avatar Get(int id)
        {
            return ProjeContext.Avatar.Where(x => x.AvatarID == id).SingleOrDefault();
        }

        public List<Avatar> GetAll()
        {
            return ProjeContext.Avatar.ToList();
        }

        public List<Avatar> GetAll(Expression<Func<Avatar, bool>> Filter)
        {
            return ProjeContext.Avatar.Where(Filter).ToList();
        }
        
        public int Set(Avatar Entity)
        {
            ProjeContext.Set<Avatar>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
