﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Context;
using NetSatis.Entities._4_Validations;

namespace NetSatis.Entities._5_Data_Access
{
    class FisDAL:EntityRepositoryBase<NetSatisContext,Fis,FisValidator>
    {
    }
}
