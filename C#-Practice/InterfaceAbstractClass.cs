using System;

// Define an interface
public interface IDrawable
{
    void Draw(); // Interface method with no implementation
}

// Define an abstract class implementing the interface
public abstract class Shape : IDrawable
{
    // Abstract method to be implemented by derived classes
    public abstract void Draw();

    // Regular method with implementation
    public void Move()
    {
        Console.WriteLine("Moving the shape.");
    }
}

// Implement a concrete class (derived from the abstract class)
public class Circle : Shape
{
    // Implementation of the abstract method from the abstract class
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

// Implement another concrete class (derived from the abstract class)
public class Square : Shape
{
    // Implementation of the abstract method from the abstract class
    public override void Draw()
    {
        Console.WriteLine("Drawing a square.");
    }
}

// Main program to demonstrate the usage
class Program
{
    static void Main()
    {
        // Create instances of concrete classes
        Circle circle = new Circle();
        Square square = new Square();

        // Call methods from the interface and abstract class
        circle.Draw();
        circle.Move();

        square.Draw();
        square.Move();
    }
}
