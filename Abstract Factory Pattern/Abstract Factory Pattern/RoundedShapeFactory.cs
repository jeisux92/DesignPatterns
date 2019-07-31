using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeTypes shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypes.Rectangle:
                    return new RoundedRectangle();
                case ShapeTypes.Square:
                    return new RoundedSquare();
                default:
                    return null;
            }
        }
    }
}
