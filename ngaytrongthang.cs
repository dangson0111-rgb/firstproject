using System;
using System.Text;

namespace SoNgayTrongThang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tháng (1-12): ");
            string input = Console.ReadLine();

            bool ok = int.TryParse(input, out int thang);
            if (!ok || thang < 1 || thang > 12)
            {
                Console.WriteLine("Tháng không hợp lệ.");
                return;
            }

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Tháng {thang} có 31 ngày.");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Tháng {thang} có 30 ngày.");
                    break;

                case 2:
                    Console.Write("Nhập năm: ");
                    string y = Console.ReadLine();
                    if (!int.TryParse(y, out int nam))
                    {
                        Console.WriteLine("Năm không hợp lệ.");
                        return;
                    }

                    bool laNamNhuan =
                        (nam % 400 == 0) ||
                        (nam % 4 == 0 && nam % 100 != 0);

                    if (laNamNhuan)
                        Console.WriteLine($"Tháng 2 năm {nam} có 29 ngày.");
                    else
                        Console.WriteLine($"Tháng 2 năm {nam} có 28 ngày.");
                    break;
            }
        }
    }
}
