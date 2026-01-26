using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("1. Hình chữ nhật");
        Console.WriteLine("2. Tam giác trái tăng");
        Console.WriteLine("3. Tam giác trái giảm");
        Console.WriteLine("4. Tam giác phải tăng");
        Console.WriteLine("5. Tam giác phải giảm");
        Console.WriteLine("6. Tam giác cân");

        Console.Write("Nhập lựa chọn: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số dòng n: ");
        int n = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 1: 
                Console.Write("Nhập số cột m: ");
                int m = int.Parse(Console.ReadLine());
                HinhChuNhat(n, m);
                break;
            case 2: TamGiacTraiTang(n); break;
            case 3: TamGiacTraiGiam(n); break;
            case 4:TamGiacPhaiTang(n); break;
            case 5:TamGiacPhaiGiam(n);break;
            case 6:TamGiacCan(n); break;    
            default: Console.WriteLine("Chưa làm chức năng này"); break;
        }
    }

    static void HinhChuNhat(int n, int m)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }

    static void TamGiacTraiTang(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
    static void TamGiacTraiGiam(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
    static void TamGiacPhaiTang(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j=1;j<=n-i;j++)
                Console.Write(" ") ;
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
    static void TamGiacPhaiGiam(int n)
    {
        for (int i=n;i>=1;i--)
        {
            for (int j=1;j<=n-i;j++)    
                Console.Write(" ") ;
            for(int j = 1;j<=i;j++)
                Console.Write("*"); 
            Console.WriteLine();
        }    
    }
    static void TamGiacCan(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n-i;j++)
                Console.Write(" ") ;
            for(int j = 1; j<=2*i-1;j++)
                Console.Write("*") ;
            Console.WriteLine();    
        }
    }
}
