namespace ConsoleApp2
{
    public class Square : Shape
    {
        public override string Name => "Квадрат";

        private readonly double _a;

        public Square(double a)
        {
            this._a = a;
        }

        public override double GetPerimeter() => this._a * 4;

        public override double GetArea() => this._a * this._a;
    }
}