using Proje.DataAccess.Context;
using Proje.Entity.Model;
using Proje.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Proje.Business.Logic
{
    public class FavAdvertLogic : IGenericService<FavAdvert>
    {
        readonly ProjeContext ProjeContext;
        public FavAdvertLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public FavAdvert Create(FavAdvert Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(FavAdvert Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FavAdvert Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<FavAdvert> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<FavAdvert> GetAll(Expression<Func<FavAdvert, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public int Set(FavAdvert Entity)
        {
            ProjeContext.Set<FavAdvert>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
