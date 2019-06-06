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
    public class PhotoLogic : IGenericService<Photo>
    {
        readonly ProjeContext ProjeContext;
        public PhotoLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Photo Create(Photo Entity)
        {
            ProjeContext.Photo.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Photo Entity)
        {
            ProjeContext.Photo.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Photo Get(int id)
        {
            return ProjeContext.Photo.Where(x => x.PhotoID == id).SingleOrDefault();
        }

        public List<Photo> GetAll()
        {
            return ProjeContext.Photo.ToList();
        }

        public List<Photo> GetAll(Expression<Func<Photo, bool>> Filter)
        {
            return ProjeContext.Photo.Where(Filter).ToList();
        }


        public int Set(Photo Entity)
        {
            ProjeContext.Set<Photo>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
