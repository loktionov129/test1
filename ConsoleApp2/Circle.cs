using System;

namespace ConsoleApp2
{
    public class Circle : Shape
    {
        public override string Name => "Круг";

        private readonly double _r;

        public Circle(double r)
        {
            this._r = r;
        }

        public override double GetPerimeter() => Math.Round(2 * Math.PI *  this._r, 2);

        public override double GetArea() => Math.Round(Math.PI * this._r * this._r, 2);
    }
}