﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Log.Abstract
{
    public interface IAbstractFactory<T>
    {
        public T Create();
    }
}
