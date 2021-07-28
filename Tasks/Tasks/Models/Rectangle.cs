using System;
using Tasks.Abstract;

namespace Tasks.Models
{
    public class Rectangle : Shape
    {
        protected override double Area { get; set; }
        
        public Rectangle(double height, double width)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Neither height nor width can be less than 0");
            }
            Area = GetArea(height,width);
        }
        private double GetArea(double num1, double num2)
        {
            return num1 * num2;
        }
        public override string ToString()
        {
            return $"Area of Rectangle is : {Area}";
        }
    }
}