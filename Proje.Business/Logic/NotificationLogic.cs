using Proje.DataAccess.Context;
using Proje.Entity.Model;
using Proje.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Proje.Business.Logic
{
    public class NotificationLogic : IGenericService<Notification>
    {
        readonly ProjeContext ProjeContext;
        public NotificationLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Notification Create(Notification Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Notification Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Notification Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetAll(Expression<Func<Notification, bool>> Filter)
        {
            throw new NotImplementedException();
        }
        public int Set(Notification Entity)
        {
            ProjeContext.Set<Notification>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
