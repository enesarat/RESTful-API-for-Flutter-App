﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        List<User> GetUserListWithRole();
    }
}
