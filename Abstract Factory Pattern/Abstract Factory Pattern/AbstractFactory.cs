﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(ShapeTypes shapeType);
    }
}
