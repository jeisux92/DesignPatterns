using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(ShapeTypes shapeTypes)
        {
            switch (shapeTypes)
            {
                case ShapeTypes.Circle:
                    return new Circle();
                case ShapeTypes.Rectangle:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
