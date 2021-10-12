using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }


            
        }
    }
}
