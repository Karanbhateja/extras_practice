using System;

class Complex
{
    private int x;
    private int y;

    // Default constructor
    public Complex()
    {
        x = 0;
        y = 0;
    }

    // Parameterized constructor
    public Complex(int i, int j)
    {
        x = i;
        y = j;
    }

    public void ShowXY()
    {
        Console.WriteLine("{0} {1}", x, y);
    }

    // Overloaded + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.x = c1.x + c2.x;
        temp.y = c1.y + c2.y;
        return temp;
    }
}

class MyClient
{
    public static void Main()
    {
        Complex c1 = new Complex(10, 20);
        c1.ShowXY(); // displays 10 & 20

        Complex c2 = new Complex(20, 30);
        c2.ShowXY(); // displays 20 & 30

        Complex c3 = new Complex();
        c3 = c1 + c2;
        c3.ShowXY(); // displays 30 & 50
    }
}
