using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;   
        string str = "lap trinh csharp";
        Console.Write("Nhập ký tự cần đếm: ");
        char kyTu =char.Parse( Console.ReadLine());
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (kyTu == str[i])
            {
                count++;
            }
        }
        Console.WriteLine($"Ký tự '{kyTu}' xuất hiện {count} lần trong chuỗi.");
    }
}
