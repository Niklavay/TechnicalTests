using System;
using System.Collections.Generic;
using Tasks.Models;
using Tasks.Abstract;
namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var radius = 1.1234D;
            
            var width = 4.5D;
            
            var basis = 5D;
            
            var height = 2D;
            
            var side = 1.1234D;
            
            var shapes = new List<Shape>
            {
                new Square(side),
                new Rectangle(height,width),
                new Triangle(basis,height),
                new Circle(radius),
            };
            
            shapes.Sort();

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}