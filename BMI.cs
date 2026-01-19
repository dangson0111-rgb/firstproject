using System;
using System.Text;

namespace codethuanC_
{
    internal class bt
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.Write("Nhập chiều cao của bạn (m): ");
            string a = Console.ReadLine();

            Console.Write("Nhập cân nặng của bạn (kg): ");
            string b = Console.ReadLine();

            bool ok1 = double.TryParse(a, out double chieuCao);
            bool ok2 = double.TryParse(b, out double canNang);

            if (!ok1 || !ok2)
            {
                Console.WriteLine("Bạn phải nhập số hợp lệ.");
                return;
            }

            double c = canNang / (chieuCao * chieuCao);

            if (c >= 30)
            {
                Console.WriteLine("Obese");
            }
            else if (c >= 25)
            {
                Console.WriteLine("Overweight");
            }
            else if (c >= 18.5)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Underweight");
            }
        }
    }
}
