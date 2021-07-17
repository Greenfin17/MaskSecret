using System;

namespace MaskSecret
{
    class Program
    {
        static void Main(string[] args)
        {
            int strLength = 0;
            Console.WriteLine("Enter secret string");
            string secret = Console.ReadLine();
            strLength = secret.Length;
            Console.WriteLine("Your secret:");
            {
                for(int i = 0; i < strLength - 4; i++)
                {
                    Console.Write('*');
                }
            }
            Console.Write($"{secret.Substring(strLength - 4)}");

            Console.WriteLine("\nEnter any key to exit");
            var key = Console.ReadKey();
        }
    }
}
