using System;

namespace ShapeAreaCalculator
{
    
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(3.5);
            Shape myRectangle = new Rectangle(5, 4);

            Console.WriteLine("Shape Areas:");
            Console.WriteLine($"Circle Area: {myCircle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {myRectangle.GetArea():F2}");
        }
    }
}
