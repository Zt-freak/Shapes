using Shapes.Models;
using System;

namespace Shapes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Spongebob = new Rectangle
            {
                Width = 5,
                Height = 10
            };
            Console.WriteLine(Spongebob.Area);

            Square Malevich = new Square
            {
                Width = 5
            };
            Console.WriteLine(Malevich.Area);

            Ellipse Egg = new Ellipse
            {
                Width = 5,
                Height = 10
            };
            Console.WriteLine(Egg.Area);

            Circle Doughnut = new Circle
            {
                Width = 5
            };
            Console.WriteLine(Doughnut.Area);

            Console.ReadLine();
        }
    }
}
