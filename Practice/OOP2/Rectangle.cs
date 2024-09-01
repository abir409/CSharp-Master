using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Rectangle : Shape
    {
        public double Height {  get; private set; }

        public double Width { get; private set; }  

        public Rectangle(double height, double width, string name) : base(name) 
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

    }
}
