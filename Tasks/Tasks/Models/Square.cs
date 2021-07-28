using System;
using Tasks.Abstract;

namespace Tasks.Models
{
    public class Square : Shape
    {
        protected override double Area { get; set; }
        public Square(double side)
        {
            if (side < 0)
            {
                throw new ArgumentException("Side of square can not be less than 0");
            }
            Area = GetArea(side);
        }
        private double GetArea(double side)
        {
            return side * side;
        }
        
        public override string ToString()
        {
            return $"Area of Square is : {Area}";
        }
    }
}