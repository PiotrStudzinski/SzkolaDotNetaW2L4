using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthRectangle;
            double lenghtRectangle;
            double diagonalRectangle;

            Console.Write("Podaj szerokość boku prostokąta: ");
            widthRectangle = double.Parse(Console.ReadLine());
            Console.Write("Podaj wysokość boku prostokąta: ");
            lenghtRectangle = double.Parse(Console.ReadLine());
            Console.WriteLine();

            diagonalRectangle = Math.Sqrt(Math.Pow(widthRectangle, 2) + Math.Pow(lenghtRectangle, 2));
            Console.WriteLine($"Przekątna prostokąta dla podanych danych wynosi: {diagonalRectangle}.");

        }
    }
}
