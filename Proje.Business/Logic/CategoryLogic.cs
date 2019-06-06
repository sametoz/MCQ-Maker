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
    public class CategoryLogic : IGenericService<Category>
    {
        readonly ProjeContext ProjeContext;
        public CategoryLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Category Create(Category Entity)
        {
            ProjeContext.Category.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Category Entity)
        {
            ProjeContext.Category.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Category Get(int id)
        {
            return ProjeContext.Category.Where(x => x.CategoryID == id).SingleOrDefault();
        }

        public List<Category> GetAll()
        {
            return ProjeContext.Category.ToList();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> Filter)
        {
            return ProjeContext.Category.Where(Filter).ToList();
        }
        public int Set(Category Entity)
        {
            ProjeContext.Set<Category>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
