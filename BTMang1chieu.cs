using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. BT1 - Tính tổng mảng");
            Console.WriteLine("2. BT2 - Tìm học sinh trong mảng");
            Console.WriteLine("3. BT3 - Tìm tỷ phú giàu nhất trong 20 người");
            Console.WriteLine("4. BT4 - Thay đổi giá trị ptử trong mảng");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BT1();
                    break;

                case 2:
                    BT2();
                    break;

                case 3:
                    Console.Write("Nhập n: ");
                    int n = int.Parse(Console.ReadLine());
                    Max(n);
                    break;
                case 4:
                    Addanelement();
                    break;

                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }

            Console.WriteLine(); // xuống dòng cho đẹp
        }
    }

    static void BT1()
    {
        int[] numbers = { 2, 5, 9, 6, 7 };
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Tổng mảng = " + sum);
    }

    static void BT2()
    {
        string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };

        Console.Write("Nhập tên học sinh: ");
        string input_name = Console.ReadLine();

        bool isExist = false;

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] == input_name)
            {
                Console.WriteLine("Vị trí của " + input_name + " là: " + (i + 1));
                isExist = true;
                break;
            }
        }

        if (!isExist)
        {
            Console.WriteLine(input_name + " không tồn tại trong mảng");
        }
    }

    static void Max(int n)
    {
        int[] mang = new int[n];
        if (n > 20)
        {
            Console.WriteLine("không được nhập vào quá 20 tỷ phú");

        }
        else
        {
            int i = 0;

            while (i < n)
            {
                Console.WriteLine("nhập vào tài sản của tỷ phú thứ {0}", i + 1);
                int a = int.Parse(Console.ReadLine());
                mang[i] = a;
                i++;
            }
            Console.WriteLine(string.Join(" ", mang));
            int max = mang[0];
            int b = 1;
            for (int j = 0; j < mang.Length; j++)
            {
                if (mang[j] > max)
                {
                    max = mang[j];
                    b = j + 1;
                }
            }
            Console.WriteLine("tỷ phú {0} có tải sản lớn nhất là {1} ", b, max, "tỷ đô");
        }
    }
    static void Addanelement()
    {
        Console.WriteLine("nhập vào số phần tử có trong mảng");
        int n = int.Parse(Console.ReadLine());
        int[] stt = new int[n];
        Console.Write("nhập vào vị trí và giá trị muốn thay đổi trong mảng: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        for (int i = 0; i < stt.Length; i++)
        {
            if (i == a)
            {
                stt[i-1] = b;
            }
        }
        Console.WriteLine("phần tử ở vị trí {0} đã thay đổi giá trị thành {1}",a, b);
        Console.WriteLine("mảng hiện tại là "+string.Join(" ", stt));
    }
}
