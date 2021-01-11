using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Circle(4),
                new Rectangle(7, 8),
                new Square(5)
            };
            
            shapes.ForEach(PrintShape);
        }

        private static void PrintShape(Shape shape)
        {
            Console.WriteLine($"Фигура: {shape.Name}");
            Console.WriteLine($"P: {shape.GetPerimeter()}");
            Console.WriteLine($"S: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}