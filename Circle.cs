using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCLE_OBJECTS
{
    public class Circle
    {
        //properties
        public double Radius { get; set; }

        //constructor
        public  Circle(double _radius)
        {
            Radius = _radius;
        }
       //methods
       public double CalculateDiameter()
        {
            return Radius * 2;
        }
        public double CalculateCircumference()
        {
            return Math.PI * Radius * 2;
        }
            public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
            public void Grow()
        {
            Radius=Radius * 2;
        }
            public double GetRadius()
        {
            return (double) Radius;
        }

    }
}
