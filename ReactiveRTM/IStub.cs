﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM
{
    public interface IStub
    {
        void SetTarget(object target);
        object GetTarget();
    }
}
