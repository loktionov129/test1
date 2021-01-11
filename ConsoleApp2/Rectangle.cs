namespace ConsoleApp2
{
    public class Rectangle : Shape
    {
        public override string Name => "Прямоугольник";

        private readonly double _a;

        private readonly double _b;

        public Rectangle(double a, double b)
        {
            this._a = a;
            this._b = b;
        }

        public override double GetPerimeter() => (this._a + this._b) * 2;

        public override double GetArea() => this._a * this._b;
    }
}