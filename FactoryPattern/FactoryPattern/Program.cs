using System;
using System.ServiceProcess;
using System.Diagnostics;
using System.Threading;

namespace FactoryPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shapeCircle = shapeFactory.GetShape(ShapeTypes.Circle);
            shapeCircle.Draw();
            IShape shapeRectangle = shapeFactory.GetShape(ShapeTypes.Rectangle);
            shapeRectangle.Draw();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
