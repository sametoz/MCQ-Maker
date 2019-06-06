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
    public class SharedPhotoLogic : IGenericService<SharedPhoto>
    {
        readonly ProjeContext ProjeContext;
        public SharedPhotoLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public SharedPhoto Create(SharedPhoto Entity)
        {
            ProjeContext.SharedPhoto.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(SharedPhoto Entity)
        {
            ProjeContext.SharedPhoto.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public SharedPhoto Get(int id)
        {
            return ProjeContext.SharedPhoto.Where(x => x.SharedPhotoID == id).SingleOrDefault();
        }

        public List<SharedPhoto> GetAll()
        {
            return ProjeContext.SharedPhoto.ToList();
        }

        public List<SharedPhoto> GetAll(Expression<Func<SharedPhoto, bool>> Filter)
        {
            return ProjeContext.SharedPhoto.Where(Filter).ToList();
        }
        public int Set(SharedPhoto Entity)
        {
            ProjeContext.Set<SharedPhoto>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
