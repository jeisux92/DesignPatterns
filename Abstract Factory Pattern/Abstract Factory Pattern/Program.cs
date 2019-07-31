using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory = FactoryProducer.GetFactory(true);
            IShape shape = abstractFactory.GetShape(ShapeTypes.Rectangle);
            shape.Draw();
            Console.ReadKey();
        }
    }
}
