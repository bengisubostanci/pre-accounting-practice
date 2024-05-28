using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using NetSatis.Entities._6_Interfaces;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities._5_Data_Access
{
    public class CariDAL : EntityRepositoryBase<NetSatisContext, Cari,CariValidator>
    {

      //  : EntityRepositoryBase<NetSatisContext, Cari>

        //public void AddOrUpdate(NetSatisContext context, Cari entity)
        //{
        //    context.Cariler.AddOrUpdate(entity);
        //}

        //public void Delete(NetSatisContext context, Expression<Func<Cari, bool>> filter)
        //{
        //    context.Cariler.RemoveRange(context.Cariler.Where(filter));
        //}

        //public void Save(NetSatisContext context)
        //{
        //    context.SaveChanges();
        //}
    }
}
