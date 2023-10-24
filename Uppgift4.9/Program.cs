using System;
namespace Uppgift_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur stor bas vill du ha på din triangel?");
            string bastext = Console.ReadLine();
            int bas = int.Parse(bastext);
            for(int i = 1; i <= bas; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        Console.ReadKey();
        }
    }
}