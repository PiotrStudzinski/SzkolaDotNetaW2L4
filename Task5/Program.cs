using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj numer telefonu: ");
            string phone = Console.ReadLine();

            Console.Write("Podaj adres email: ");
            string email = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Podaj wzrost: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Podaj datę urodzenia (rrrr-mm-dd): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Podaj płać (\"m\" lub \"k\": ");
            char sex = char.Parse(Console.ReadLine());
        }
    }
}
