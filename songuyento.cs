using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        for (int i = 2; i < 100; i++)
        {
            bool isPrime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine(i + " là số nguyên tố");
          
        }

        Console.ReadLine();
    }
}
