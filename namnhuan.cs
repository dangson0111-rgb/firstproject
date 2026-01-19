using System;
using System.Text;

namespace KiemTraNamNhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một năm: ");
            string input = Console.ReadLine();
            bool ok = int.TryParse(input, out int year);
            if (!ok)
            {
                Console.WriteLine("Bạn phải nhập một số nguyên.");
                return;
            }

            bool laNamNhuan;

            if (year % 400 == 0)
                laNamNhuan = true;
            else if (year % 100 == 0)
                laNamNhuan = false;
            else if (year % 4 == 0)
                laNamNhuan = true;
            else
                laNamNhuan = false;

            if (laNamNhuan)
                Console.WriteLine($"Năm {year} là năm nhuận.");
            else
                Console.WriteLine($"Năm {year} không phải là năm nhuận.");
        }
    }
}
