namespace ConsoleApp2
{
    public abstract class Shape
    {
        public abstract string Name { get; }

        public abstract double GetPerimeter();
        
        public abstract double GetArea();
    }
}