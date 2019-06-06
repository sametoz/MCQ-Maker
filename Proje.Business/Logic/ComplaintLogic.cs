using Proje.DataAccess.Context;
using Proje.Entity.Model;
using Proje.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Proje.Business.Logic
{
    public class ComplaintLogic : IGenericService<Complaint>
    {
        readonly ProjeContext ProjeContext;
        public ComplaintLogic(ProjeContext projeContext)
        {
            ProjeContext = projeContext;
        }
        public Complaint Create(Complaint Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Complaint Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Complaint Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Complaint> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Complaint> GetAll(Expression<Func<Complaint, bool>> Filter)
        {
            throw new NotImplementedException();
        }


        public int Set(Complaint Entity)
        {
            ProjeContext.Set<Complaint>().Update(Entity);
            return ProjeContext.SaveChanges();
        }
    }
}
