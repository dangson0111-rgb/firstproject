using System;
using System.Collections.Generic;
using System.Text;


namespace codethuanC_
{

    public class VuKhi
    {
        private string TenVK;
        private int Satthuong;
        public VuKhi(string TenVK, int Satthuong)
        {
            this.TenVK = TenVK;
            this.Satthuong = Satthuong;
        }
        public string Ten
        {
            get { return TenVK; }
            set { TenVK = value; }
        }
        public int SatThuong
        {
            get { return Satthuong; }
            set { Satthuong = value; }
        }

        public void TanCong()
        {
            Console.WriteLine($"Vũ khí {TenVK} gây ra sát thương {Satthuong} máu");
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            QuaiVat.Main2();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số lượng vũ khí bạn muốn thêm vào kho chú cụ");
            int n = int.Parse(Console.ReadLine());
            List<VuKhi> khochucu = new List<VuKhi>();
            int i = 0;
            int s = 0;
            while (i < n)
            {
                Console.WriteLine($"Nhập tên vũ khí {i + 1}:");
                string a = Console.ReadLine();
                Console.WriteLine($"Nhập sát thương vũ khí {i + 1}:");
                int b = int.Parse(Console.ReadLine());
                khochucu.Add(new VuKhi(a, b));
                i++;
                s += b;
            }

            Console.WriteLine("\nDanh sách vũ khí trong kho:");
            foreach (VuKhi vk in khochucu)
            {
                vk.TanCong();
            }
            Console.WriteLine("Tổng sát thương vũ khí là " + s);
        }

    }
}
