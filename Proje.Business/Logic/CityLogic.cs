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
    public class CityLogic : IGenericService<City>
    {
        readonly ProjeContext ProjeContext;
        public CityLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public City Create(City Entity)
        {
            ProjeContext.City.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(City Entity)
        {
            ProjeContext.City.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public City Get(int id)
        {
            return ProjeContext.City.Where(x => x.CityID == id).SingleOrDefault();
        }

        public List<City> GetAll()
        {
            return ProjeContext.City.ToList();
        }

        public List<City> GetAll(Expression<Func<City, bool>> Filter)
        {
            return ProjeContext.City.Where(Filter).ToList();
        }


        public int Set(City Entity)
        {
            ProjeContext.Set<City>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
