using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool:");
                string userPassword = Console.ReadLine();
                Console.WriteLine("Sisesta PIN-kood:");
                string userPIN = Console.ReadLine();

                if (userPIN.Length > 4)
                {
                    Console.WriteLine("Vale PIN proovi uuesti");
                }
                else if (userName == "user1" && userPassword == "password1" && userPIN == "1532")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti. ");
                    i = i + 1;
                }

            }
        }
    }
}
