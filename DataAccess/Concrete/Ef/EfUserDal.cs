﻿using Core.DataAccess.Base;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Ef
{
    public class EfUserDal : EfEntityRepositoryBase<User, EfContext>, IUserDal
    {
       
    }
}
