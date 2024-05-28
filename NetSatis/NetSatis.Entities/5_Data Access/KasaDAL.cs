using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities._5_Data_Access
{
    class KasaDAL : EntityRepositoryBase<NetSatisContext, Kasa,KasaValidator>
    {
    }
}
