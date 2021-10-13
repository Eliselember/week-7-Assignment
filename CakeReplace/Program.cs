using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string lause = "The c4ke i3 4 l1e.";

            lause = lause.Replace('1', 'i');
            lause = lause.Replace('3', 's');
            lause = lause.Replace('4', 'a');
            Console.WriteLine(lause);

        }
    }
}
