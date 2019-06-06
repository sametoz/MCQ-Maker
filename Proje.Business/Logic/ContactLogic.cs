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
    public class ContactLogic : IGenericService<Contact>
    {
        IGenericService<Contact> Contact;
        readonly ProjeContext ProjeContext;
        public ContactLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Contact Create(Contact Entity)
        {
            ProjeContext.Contact.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Contact Entity)
        {
            ProjeContext.Contact.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Contact Get(int id)
        {
            return ProjeContext.Contact.Where(x => x.ContactID == id).SingleOrDefault();
        }

        public List<Contact> GetAll()
        {
            return ProjeContext.Contact.ToList();
        }

        public List<Contact> GetAll(Expression<Func<Contact, bool>> Filter)
        {
            return ProjeContext.Contact.Where(Filter).ToList();
        }

        public int Set(Contact Entity)
        {
            ProjeContext.Set<Contact>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
