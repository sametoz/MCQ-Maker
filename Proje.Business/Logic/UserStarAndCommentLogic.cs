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
    public class UserStarAndCommentLogic : IGenericService<UserStarAndComment>
    {
        readonly ProjeContext ProjeContext;
        public UserStarAndCommentLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public UserStarAndComment Create(UserStarAndComment Entity)
        {
            ProjeContext.UserStarAndComment.Add(Entity);
            ProjeContext.SaveChanges();
            return Entity;
        }

        public bool Delete(UserStarAndComment Entity)
        {
            ProjeContext.UserStarAndComment.Remove(Entity);
            return ProjeContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var item = Get(id);
            return Delete(id);
        }

        public UserStarAndComment Get(int id)
        {
            return ProjeContext.UserStarAndComment.Where(x => x.UserStarAndCommentID == id).SingleOrDefault();
        }

        public List<UserStarAndComment> GetAll()
        {
            return ProjeContext.UserStarAndComment.ToList();
        }

        public List<UserStarAndComment> GetAll(Expression<Func<UserStarAndComment, bool>> Filter)
        {
            return ProjeContext.UserStarAndComment.Where(Filter).ToList();
        }

        public int Set(UserStarAndComment Entity)
        {
            ProjeContext.UserStarAndComment.Update(Entity);
            return ProjeContext.SaveChanges();
        }

    }
}
