﻿using inRiver.Remoting.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exjobb
{
    public interface IDataHandler
    {
        Entity UpdateEntity(Entity entity, string[] fieldTypeIds);
    }
}