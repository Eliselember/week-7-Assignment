using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Tere {firstname[0]}. {lastname[0]}. ");

        }
    }
}
