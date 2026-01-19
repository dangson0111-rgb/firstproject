using System;
using System.Text;

namespace codethuanC_
{
    internal class bt
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("Kết quả là {0}!", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("vô số nghiệm x!");
                }
                else
                {
                    Console.Write("vô nghiệm");
                }
            }
        }
    }
}
