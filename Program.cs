using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Method Overloading (Compile-Time Polymorphism)
        Calculator calculator = new Calculator();
        Console.WriteLine("Addition of integers: " + calculator.Add(5, 10));
        Console.WriteLine("Addition of doubles: " + calculator.Add(3.5, 7.2));

        // Method Overriding (Runtime Polymorphism)
        Shape[] shapes = new Shape[2];
        shapes[0] = new Circle();
        shapes[1] = new Square();

        foreach(Shape shape in shapes)
        {
            shape.Draw(); // Dynamic Polymorphism
        }
    }
}
