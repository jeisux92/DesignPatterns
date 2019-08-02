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
            IShape shapeCircle = ShapeFactory.GetShape(ShapeTypes.Circle);
            shapeCircle.Draw();
            IShape shapeRectangle = ShapeFactory.GetShape(ShapeTypes.Rectangle);
            shapeRectangle.Draw();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
