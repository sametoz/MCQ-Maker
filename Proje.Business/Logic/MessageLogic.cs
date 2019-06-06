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
    public class MessageLogic : IGenericService<Message>
    {

        IGenericService<Message> Message;
        readonly ProjeContext ProjeContext;
        public MessageLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Message Create(Message Entity)
        {
            ProjeContext.Message.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(Message Entity)
        {
            ProjeContext.Message.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public Message Get(int id)
        {
            return ProjeContext.Message.Where(x => x.MessageID == id).SingleOrDefault();
        }

        public List<Message> GetAll()
        {
            return ProjeContext.Message.ToList();
        }

        public List<Message> GetAll(Expression<Func<Message, bool>> Filter)
        {
            return ProjeContext.Message.Where(Filter).ToList();
        }


        public int Set(Message Entity)
        {
            ProjeContext.Set<Message>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
