using System;
namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rectangle = new Rectangle(5, 4);
            Console.WriteLine($"Area of the rectangle: {Rectangle.Area}");
            Console.WriteLine($"Perimeter of the rectangle: {Rectangle.Perimeter}");
        }
    }
}
