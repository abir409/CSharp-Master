using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public abstract class Shape
    {
        public string Name { get; private set; }    

        public string Color { get; protected set; }

        public Shape(string name)
        {
            Name = name;
        }
        public void SetColor(string color)
        {
            Color = color;
        }

        public abstract double CalculateArea();
       
    }
}
