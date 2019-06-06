using Proje.DataAccess.Context;
using Proje.Entity.Model;
using Proje.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Proje.Business.Logic
{
    public class BlockedUserLogic : IGenericService<BlockedUser>
    {
        readonly ProjeContext ProjeContext;
        public BlockedUserLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public BlockedUser Create(BlockedUser Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(BlockedUser Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BlockedUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<BlockedUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<BlockedUser> GetAll(Expression<Func<BlockedUser, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public int Set(BlockedUser Entity)
        {
            ProjeContext.Set<BlockedUser>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
