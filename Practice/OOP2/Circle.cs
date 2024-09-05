using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius, string name) : base(name) 
        {
            Radius = radius;
        }

        public override double CalculateArea()
        { 
            return Math.PI * Radius * Radius;
        }

        public new void SetColor(string color)
        {
            Color = "#" + color;
        }
    }
}
