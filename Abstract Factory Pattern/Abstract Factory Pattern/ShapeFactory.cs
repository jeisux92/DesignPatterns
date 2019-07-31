using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeTypes shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypes.Rectangle:
                    return new Rectangle();
                case ShapeTypes.Square:
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
