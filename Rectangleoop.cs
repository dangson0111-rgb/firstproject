using System;
using System.Text;
namespace codethuanC_
{
    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        // Tính diện tích
        public int GetArea()
        {
            return width * height;
        }

        // Tính chu vi
        public int GetPerimeter()
        {
            return (width + height) * 2;
        }

        // Hiển thị thông tin
        public void Display()
        {
            Console.WriteLine("Width = " + width);
            Console.WriteLine("Height = " + height);
            Console.WriteLine("Area = " + GetArea());
            Console.WriteLine("Perimeter = " + GetPerimeter());
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("nhập vào chiều dài");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("nhập vào chiều cao");
            int b=int.Parse(Console.ReadLine());
            Rectangle r = new Rectangle( a, b);
            r.Display();
        }
    }
}
