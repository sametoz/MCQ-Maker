using Proje.DataAccess.Context;
using Proje.Entity.Model;
using Proje.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Proje.Business.Logic
{
    public class NotificationTypeLogic : IGenericService<NotificationType>
    {
        readonly ProjeContext ProjeContext;
        public NotificationTypeLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public NotificationType Create(NotificationType Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(NotificationType Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public NotificationType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<NotificationType> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<NotificationType> GetAll(Expression<Func<NotificationType, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public int Set(NotificationType Entity)
        {
            ProjeContext.Set<NotificationType>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
