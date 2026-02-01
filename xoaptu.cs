using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("nhập số ký tự n ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"nhập vào giá trị cho phần tử {i}");
            mang[i] = int.Parse(Console.ReadLine());
        }
        int x;
        bool c;
        do
        {
            Console.Write("Nhập phần tử cần xoá: ");
            c = int.TryParse(Console.ReadLine(), out x);
        } while (!c);
        bool daXoa = false;
        for (int i = 0; i < n; i++)
        {
            if (daXoa)
            {
                mang[i - 1] = mang[i]; 
            }
            else if (mang[i] == x)
            {
                daXoa = true; 
            }
        }
        if (!daXoa)
        {
            Console.WriteLine("❌ Không tìm thấy phần tử cần xoá");
        }
        else
        {
            n--; 
            Console.WriteLine("Mảng sau khi xoá:");
            for (int i = 0; i < n; i++)
                Console.Write(mang[i] + " ");
        }
    }
}


