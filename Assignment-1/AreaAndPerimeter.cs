using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class AreaAndPerimeter
    {
        public AreaAndPerimeter(double diameter)
        {
            double radius = diameter / 2;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine(perimeter);
            double Area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(Area);
        }
        
    }
}
