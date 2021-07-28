using System;
using Tasks.Abstract;

namespace Tasks.Models
{
    public class Triangle : Shape
    {
        protected override double Area { get; set; }
        
        public Triangle(double basis, double height)
        {
            if (basis < 0 || height < 0)
            {
                throw new ArgumentException("Neither height nor basis can be less than 0");
            }
            Area = GetArea(height, basis);
        }

        public double GetArea(double num1, double num2)
        {
            return (num1 * num2)/2;
        }

        public override string ToString()
        {
            return $"Area of Triangle is : {Area}";
        }
        
    }
}