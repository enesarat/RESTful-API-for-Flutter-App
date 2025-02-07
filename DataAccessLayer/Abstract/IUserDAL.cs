﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IUserDAL:IGenericEntityDAL<User>
    {
        List<User> GetListWithRoles();
    }
}
