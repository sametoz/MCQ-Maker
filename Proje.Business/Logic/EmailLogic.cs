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
    public class EmailLogic : IGenericService<Email>
    {
        readonly ProjeContext ProjeContext;
        public EmailLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Email Create(Email Entity)
        {
            ProjeContext.Email.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Email Entity)
        {
            ProjeContext.Email.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Email Get(int id)
        {
            return ProjeContext.Email.Where(x => x.EmailID == id).SingleOrDefault();
        }

        public List<Email> GetAll()
        {
            return ProjeContext.Email.ToList();
        }

        public List<Email> GetAll(Expression<Func<Email, bool>> Filter)
        {
            return ProjeContext.Email.Where(Filter).ToList();
        }


        public int Set(Email Entity)
        {
            ProjeContext.Set<Email>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
