using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool rounded)
        {
            return rounded ? (AbstractFactory)new RoundedShapeFactory() : new ShapeFactory();
        }
    }
}
