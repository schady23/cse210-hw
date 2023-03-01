using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("blue", 5);
        Rectangle myRectangle = new Rectangle("green", 3, 6);
        Circle myCircle = new Circle("red", 4);

        Console.WriteLine("Area of my {0} square is {1}", mySquare.GetColor(), mySquare.GetArea());
        Console.WriteLine("Area of my {0} rectangle is {1}", myRectangle.GetColor(), myRectangle.GetArea());
        Console.WriteLine("Area of my {0} circle is {1}", myCircle.GetColor(), myCircle.GetArea());
    }
}