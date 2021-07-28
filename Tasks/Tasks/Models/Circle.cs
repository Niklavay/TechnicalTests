using System;
using Tasks.Abstract;

namespace Tasks.Models
{
    public class Circle : Shape
    {
        protected override double Area { get; set; }
        
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can not be less than 0");
            }
            
            Area = GetArea(radius);
        }

        private double GetArea(double num)
        {
            return (num * num) * Math.PI;
        }

        public override string ToString()
        {
            return $"Area of Circle is : {Area}";
        }
    }
}