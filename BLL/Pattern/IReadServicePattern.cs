﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern
{
    public interface IReadServicePattern<T>  where T : class
    {
        T GetById(object id);
        List<T> GetAll();

    }
}
