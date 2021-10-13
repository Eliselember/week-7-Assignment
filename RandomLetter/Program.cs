using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Random rnd = new Random();

            int taht = rnd.Next(0, firstName.Length - 1);
            Console.WriteLine(firstName[taht]);


            
        }
    }
}
